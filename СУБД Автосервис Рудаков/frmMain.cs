using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace СУБД_Автосервис_Рудаков
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static string TxtCon = @"Data Source=213.155.192.79,3002;Initial Catalog=AutoService;Persist Security Info=True;User ID=u47_12;Password=fgm8";
        
        struct Client
        {
            public string ID, PhotoPath, LastName, FirstName, Patronymic, GenderCode, CountService, LastDate;
        }

        List<Client> LstClient = new List<Client>();

        int CountPerPage = 5;
        int NBegin = 0;


        /// <summary>
        /// Чтение данных из базы данных 
        /// </summary>
        void GetDateFromDB()
        {
            SqlConnection con = new SqlConnection(TxtCon);
            con.Open();

            string Uslovie = "";
            if(CmbFindType.Text == "Фамилии")
                Uslovie += $" Where LastName LIKE '{TbxFind.Text}%'";

            else if(CmbFindType.Text == "Имени")
                Uslovie += $" Where FirstName LIKE '{TbxFind.Text}%'";
            
            else if(CmbFindType.Text == "Отчеству")
                Uslovie += $" Where Patronymic LIKE '{TbxFind.Text}%'";

            if (CmbGenderFilter.Text == "М")
                Uslovie += " and GenderCode = 'м'";
            else if (CmbGenderFilter.Text == "Ж")
                Uslovie += " and GenderCode = 'ж'";
            else Uslovie += " and GenderCode like '%'";
           
            if (CmbSortType.Text == "Фамилии")
                Uslovie += " order by LastName";
            else if (CmbSortType.Text == "Дате последнего посещения")
                Uslovie += " order by LastDate desc";
            else if (CmbSortType.Text == "Кол-ву посещений")
                Uslovie += " order by CountService desc";
       
                

            string TxtQuery = @"select ID, PhotoPath, LastName, FirstName, Patronymic, GenderCode, 
	(select  COUNT(ServiceID)
	from ClientService
	Where ClientID = Client.ID) as CountService, 
	(select  max(StartTime)
	from ClientService
	Where ClientID = Client.ID) as LastDate
from Client" + " " + Uslovie;
            SqlCommand query = new SqlCommand(TxtQuery,con);
            SqlDataReader res = query.ExecuteReader();

            LstClient.Clear();
            while(res.Read())
            {
                Client client = new Client();
                client.ID = res["ID"].ToString();
                client.PhotoPath = res["PhotoPath"].ToString();
                client.LastName = res["LastName"].ToString();
                client.FirstName = res["FirstName"].ToString();
                client.Patronymic = res["Patronymic"].ToString();
                client.GenderCode = res["GenderCode"].ToString();
                client.CountService = res["CountService"].ToString();
                client.LastDate = res["LastDate"].ToString();
                
                LstClient.Add(client);
            }
            con.Close();
        }

        /// <summary>
        /// Вывод данных в DataGridView
        /// </summary>
        void FillDgvClient()
        {
            DgvClients.Rows.Clear();
            for(int i = NBegin; i< NBegin+CountPerPage;i++)
            {
                if (i > LstClient.Count - 1)
                    break;
                string Mess = $@"{LstClient[i].LastName} {LstClient[i].FirstName} {LstClient[i].Patronymic}
Количество посещений: {LstClient[i].CountService}
Дата последнего посещения: {LstClient[i].LastDate}";
                try
                {
                    DgvClients.Rows.Add(Image.FromFile(Application.StartupPath + "\\" + LstClient[i].PhotoPath), Mess, LstClient[i].ID);
                }
                catch
                {
                    DgvClients.Rows.Add(Properties.Resources.blank, Mess, LstClient[i].ID);
                }
                if (int.Parse(LstClient[i].CountService) == 0)
                    DgvClients.Rows[DgvClients.RowCount - 1].DefaultCellStyle.BackColor = Color.Blue;

            }

            int CntPages = LstClient.Count / CountPerPage;
            if (LstClient.Count % CountPerPage != 0)
                CntPages++;
            PanelPages.Controls.Clear();
           
            LblNext.Dock = DockStyle.Left;
            
            PanelPages.Controls.Add(LblNext);
            for (int i = CntPages; i>= 1;i--)
            {
                Label lbl = new Label();
                lbl.Text = i.ToString();
                lbl.AutoSize = true;
                lbl.Dock = DockStyle.Left;
                lbl.Click += Lbl_Click;
                if (i == (NBegin + CountPerPage) / CountPerPage)
                    lbl.BackColor = Color.FromArgb(161, 99, 245);
                PanelPages.Controls.Add(lbl);
            }
            LblBack.Dock = DockStyle.Left;
            PanelPages.Controls.Add(LblBack);

            TsLblZapisi.Text = $"Всего записей: {LstClient.Count}, отображается: {DgvClients.Rows.Count}";
        }

        /// <summary>
        /// Переключение на нужную страницу
        /// </summary>
     
        private void Lbl_Click(object sender, EventArgs e)
        {
            int n = int.Parse((sender as Label).Text);
            NBegin = (n - 1) * CountPerPage;
            (sender as Label).BackColor = Color.Blue;
            FillDgvClient();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CmbCountZap.SelectedIndex = 0;
            CmbFindType.SelectedIndex = 0;
            CmbGenderFilter.SelectedIndex = 2;
            CmbSortType.SelectedIndex = 0;
            GetDateFromDB();
            FillDgvClient();
            
        }

        /// <summary>
        /// Переключение к следующей странице
        /// </summary>
      
        private void LblNext_Click(object sender, EventArgs e)
        {
            if (NBegin + CountPerPage < LstClient.Count)
            {
                NBegin += CountPerPage;
                FillDgvClient();
            }
        }

        /// <summary>
        /// Переключение к предыдущей странице
        /// </summary>
        
        private void LblBack_Click(object sender, EventArgs e)
        {
            if (NBegin > 0)
            {
                NBegin -= CountPerPage;
                FillDgvClient();
            }
        }

        /// <summary>
        /// Изменение кол-ва строк на одной странице
        /// </summary>
        
        private void CmbCountZap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCountZap.Text != "все")
                CountPerPage = int.Parse(CmbCountZap.Text);
            else CountPerPage = LstClient.Count;

            NBegin = 0;
            FillDgvClient();
        }
    /// <summary>
    /// Поиск по различным полям
    /// </summary>

        private void TbxFind_TextChanged(object sender, EventArgs e)
        {
            GetDateFromDB();
            FillDgvClient();
        }

        /// <summary>
        /// Изменение поля для поиска
        /// </summary>
      
        private void CmbFindType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDateFromDB();
            FillDgvClient();
        }
        /// <summary>
        /// Фильтрация по полу
        /// </summary>
    
        private void CmbGenderFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDateFromDB();
            FillDgvClient();
        }

        /// <summary>
        /// Сортировка по различным полям
        /// </summary>
     
        private void CmbSortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDateFromDB();
            FillDgvClient();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormAddEdit frm = new FormAddEdit();
            frm.Adding = true;
            frm.ShowDialog();
            GetDateFromDB();
            FillDgvClient();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FormAddEdit frm = new FormAddEdit();
            frm.Adding = false;
            frm.BsClient.Filter = "ID = " + DgvClients.CurrentRow.Cells[2].Value.ToString();
            //frm.BsClient.Filter = "ID = " + LstClient[DgvClients.CurrentRow.Index + NBegin].ID;
            frm.ShowDialog();
            GetDateFromDB();
            FillDgvClient();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (int.Parse(LstClient[DgvClients.CurrentRow.Index + NBegin].CountService) != 0)
            {
                MessageBox.Show("У данного клиента есть информация о посещениях. \r\nУдаление невозможно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить клиента?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(TxtCon);
                con.Open();

                SqlCommand query = new SqlCommand($@"Delete from Client where ID = {DgvClients.CurrentRow.Cells[2].Value}", con);
                query.ExecuteNonQuery();
                con.Close();
                GetDateFromDB();
                FillDgvClient();
                MessageBox.Show("Удаление клиента завершено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnPosesh_Click(object sender, EventArgs e)
        {
            FormServices frm = new FormServices();
            frm.id = DgvClients.CurrentRow.Cells[2].Value.ToString();
            frm.bsCurrentClientService.Filter = "ClientID = " + DgvClients.CurrentRow.Cells[2].Value.ToString();
            frm.ShowDialog();
        }
    }
}
