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
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
        }

        public string id = "";

        private void FormServices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoServiceDataSet.CurrentClientService' table. You can move, or remove it, as needed.
            this.currentClientServiceTableAdapter.Fill(this.autoServiceDataSet.CurrentClientService);
            SqlConnection con = new SqlConnection(frmMain.TxtCon);
            con.Open();
            SqlCommand query = new SqlCommand($@"SELECT        Service.Title, ClientService.StartTime
FROM            ClientService INNER JOIN
                         Client ON ClientService.ClientID = Client.ID INNER JOIN
                         Service ON ClientService.ServiceID = Service.ID
where ClientID = {id}", con);
            SqlDataReader res = query.ExecuteReader();
            while(res.Read())
            {
                dgvServices.Rows.Add($@"{res["StartTime"]}
{res["Title"]}");
            }
            con.Close();
        }
    }
}
