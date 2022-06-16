using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Автосервис_Рудаков
{
    public partial class FormAddEdit : Form
    {
        public FormAddEdit()
        {
            InitializeComponent();
        }

        public bool Adding = false;

        private void FormAddEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoServiceDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.autoServiceDataSet.Client);
            if (Adding)
            {
                LblType.Text = "Добавление клиента";
                BsClient.AddNew();
                DataRowView drv = (DataRowView)BsClient.Current;
                drv["RegistrationDate"] = DateTime.Now;

                LblGenderCode.Text = "м";
            }
            else
            {
                LblType.Text = "Редактирование клиента";
                if (LblGenderCode.Text == "м")
                    RbtMGender.Checked = true;
                else
                    RbtFGender.Checked = true;
                try
                {
                    pbxPhoto.Load(Application.StartupPath + "\\" + LblPhotoPath.Text);
                }
                catch
                {
                   pbxPhoto.Image = Properties.Resources.blank;
                }
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(TbxName.Text.Trim() == "" || TbxFam.Text.Trim() == "" || TbxPhone.Text.Trim() == "")
            {
                MessageBox.Show("Фамилия/имя/телефон являются обязательными для заполнения!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if (TbxMail.Text.Trim() != "")
                {
                    MailAddress address = new MailAddress(TbxMail.Text);
                }
            }
            catch
            {
                MessageBox.Show("Почта не соответствует требованиям!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BsClient.EndEdit();
            this.clientTableAdapter.Update(this.autoServiceDataSet.Client);
            this.Close();
        }

        private void RbtMGender_CheckedChanged(object sender, EventArgs e)
        {
            LblGenderCode.Text = "м";
        }

        private void RbtFGender_CheckedChanged(object sender, EventArgs e)
        {
            LblGenderCode.Text = "ж";
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if(OpenPhoto.ShowDialog() == DialogResult.OK)
            {
                FileInfo FInfo = new FileInfo(OpenPhoto.FileName);
                if(FInfo.Length > 2097152)
                {
                    MessageBox.Show("Файл не должен превышать 2 МБайта!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                try
                {
                    pbxPhoto.Load(OpenPhoto.FileName);
                    string FileName = GetNewFileName(Path.GetFileName(OpenPhoto.FileName));
                    string NewFile = Application.StartupPath + "\\" + "Клиенты\\" + FileName;
                    File.Copy(OpenPhoto.FileName, NewFile);
                    LblPhotoPath.Text = "Клиенты\\" + FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить изображение из файла!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        string GetNewFileName(string FileName)
        {
           
            Random rnd = new Random();
            while(File.Exists(Application.StartupPath + "\\Клиенты\\" + FileName))
            {
                FileName = TbxFam.Text + rnd.Next(1000000, 9999999);
            }
            return FileName;
        }

        private void TbxFam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            if (e.KeyChar == ' ' || e.KeyChar == '-')
                e.Handled = false;
            if(e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }
    }
}
