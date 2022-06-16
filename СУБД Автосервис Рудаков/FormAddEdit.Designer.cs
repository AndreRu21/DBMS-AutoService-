
namespace СУБД_Автосервис_Рудаков
{
    partial class FormAddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEdit));
            this.PanelZag = new System.Windows.Forms.Panel();
            this.LblType = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.autoServiceDataSet = new СУБД_Автосервис_Рудаков.AutoServiceDataSet();
            this.BsClient = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new СУБД_Автосервис_Рудаков.AutoServiceDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new СУБД_Автосервис_Рудаков.AutoServiceDataSetTableAdapters.TableAdapterManager();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxFam = new System.Windows.Forms.TextBox();
            this.TbxPatron = new System.Windows.Forms.TextBox();
            this.DtpBirth = new System.Windows.Forms.DateTimePicker();
            this.TbxMail = new System.Windows.Forms.TextBox();
            this.TbxPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RbtMGender = new System.Windows.Forms.RadioButton();
            this.RbtFGender = new System.Windows.Forms.RadioButton();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblGenderCode = new System.Windows.Forms.Label();
            this.LblPhotoPath = new System.Windows.Forms.Label();
            this.OpenPhoto = new System.Windows.Forms.OpenFileDialog();
            this.registrationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            this.PanelZag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(73, 143);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(35, 14);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "Имя:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(45, 117);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(63, 14);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Фамилия:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(38, 169);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(70, 14);
            patronymicLabel.TabIndex = 5;
            patronymicLabel.Text = "Отчество:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(3, 249);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(105, 14);
            birthdayLabel.TabIndex = 7;
            birthdayLabel.Text = "Дата рождения:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(59, 195);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(49, 14);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(45, 221);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(63, 14);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Телефон:";
            // 
            // PanelZag
            // 
            this.PanelZag.BackColor = System.Drawing.Color.LightGray;
            this.PanelZag.Controls.Add(this.LblType);
            this.PanelZag.Controls.Add(this.PbxLogo);
            this.PanelZag.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelZag.Location = new System.Drawing.Point(0, 0);
            this.PanelZag.Name = "PanelZag";
            this.PanelZag.Size = new System.Drawing.Size(524, 108);
            this.PanelZag.TabIndex = 1;
            // 
            // LblType
            // 
            this.LblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblType.Location = new System.Drawing.Point(95, 47);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(252, 22);
            this.LblType.TabIndex = 1;
            this.LblType.Text = "Редактирование клиента";
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = global::СУБД_Автосервис_Рудаков.Properties.Resources.service_logo;
            this.PbxLogo.Location = new System.Drawing.Point(407, 0);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(117, 108);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // autoServiceDataSet
            // 
            this.autoServiceDataSet.DataSetName = "AutoServiceDataSet";
            this.autoServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BsClient
            // 
            this.BsClient.DataMember = "Client";
            this.BsClient.DataSource = this.autoServiceDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientServiceTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Автосервис_Рудаков.AutoServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TbxName
            // 
            this.TbxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsClient, "FirstName", true));
            this.TbxName.Location = new System.Drawing.Point(114, 140);
            this.TbxName.MaxLength = 50;
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(201, 20);
            this.TbxName.TabIndex = 1;
            this.TbxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxFam_KeyPress);
            // 
            // TbxFam
            // 
            this.TbxFam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxFam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsClient, "LastName", true));
            this.TbxFam.Location = new System.Drawing.Point(114, 114);
            this.TbxFam.MaxLength = 50;
            this.TbxFam.Name = "TbxFam";
            this.TbxFam.Size = new System.Drawing.Size(201, 20);
            this.TbxFam.TabIndex = 0;
            this.TbxFam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxFam_KeyPress);
            // 
            // TbxPatron
            // 
            this.TbxPatron.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxPatron.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsClient, "Patronymic", true));
            this.TbxPatron.Location = new System.Drawing.Point(114, 166);
            this.TbxPatron.MaxLength = 50;
            this.TbxPatron.Name = "TbxPatron";
            this.TbxPatron.Size = new System.Drawing.Size(201, 20);
            this.TbxPatron.TabIndex = 2;
            this.TbxPatron.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxFam_KeyPress);
            // 
            // DtpBirth
            // 
            this.DtpBirth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BsClient, "Birthday", true));
            this.DtpBirth.Location = new System.Drawing.Point(114, 244);
            this.DtpBirth.Name = "DtpBirth";
            this.DtpBirth.Size = new System.Drawing.Size(172, 20);
            this.DtpBirth.TabIndex = 5;
            // 
            // TbxMail
            // 
            this.TbxMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsClient, "Email", true));
            this.TbxMail.Location = new System.Drawing.Point(114, 192);
            this.TbxMail.Name = "TbxMail";
            this.TbxMail.Size = new System.Drawing.Size(201, 20);
            this.TbxMail.TabIndex = 3;
            // 
            // TbxPhone
            // 
            this.TbxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsClient, "Phone", true));
            this.TbxPhone.Location = new System.Drawing.Point(114, 218);
            this.TbxPhone.Name = "TbxPhone";
            this.TbxPhone.Size = new System.Drawing.Size(201, 20);
            this.TbxPhone.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Пол:";
            // 
            // RbtMGender
            // 
            this.RbtMGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbtMGender.AutoSize = true;
            this.RbtMGender.Checked = true;
            this.RbtMGender.Location = new System.Drawing.Point(393, 110);
            this.RbtMGender.Name = "RbtMGender";
            this.RbtMGender.Size = new System.Drawing.Size(32, 18);
            this.RbtMGender.TabIndex = 6;
            this.RbtMGender.TabStop = true;
            this.RbtMGender.Text = "м";
            this.RbtMGender.UseVisualStyleBackColor = true;
            this.RbtMGender.CheckedChanged += new System.EventHandler(this.RbtMGender_CheckedChanged);
            // 
            // RbtFGender
            // 
            this.RbtFGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbtFGender.AutoSize = true;
            this.RbtFGender.Location = new System.Drawing.Point(431, 110);
            this.RbtFGender.Name = "RbtFGender";
            this.RbtFGender.Size = new System.Drawing.Size(32, 18);
            this.RbtFGender.TabIndex = 7;
            this.RbtFGender.TabStop = true;
            this.RbtFGender.Text = "ж";
            this.RbtFGender.UseVisualStyleBackColor = true;
            this.RbtFGender.CheckedChanged += new System.EventHandler(this.RbtFGender_CheckedChanged);
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPhoto.Location = new System.Drawing.Point(381, 129);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(108, 106);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 16;
            this.pbxPhoto.TabStop = false;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.BtnLoad.Location = new System.Drawing.Point(381, 238);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(108, 26);
            this.BtnLoad.TabIndex = 8;
            this.BtnLoad.Text = "Загрузить";
            this.BtnLoad.UseVisualStyleBackColor = false;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.BtnOK.Location = new System.Drawing.Point(330, 299);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(95, 23);
            this.BtnOK.TabIndex = 9;
            this.BtnOK.Text = "ОК";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(125, 299);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(95, 23);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // LblGenderCode
            // 
            this.LblGenderCode.BackColor = System.Drawing.SystemColors.Window;
            this.LblGenderCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsClient, "GenderCode", true));
            this.LblGenderCode.ForeColor = System.Drawing.Color.White;
            this.LblGenderCode.Location = new System.Drawing.Point(25, 350);
            this.LblGenderCode.Name = "LblGenderCode";
            this.LblGenderCode.Size = new System.Drawing.Size(100, 23);
            this.LblGenderCode.TabIndex = 21;
            this.LblGenderCode.Text = "label2";
            // 
            // LblPhotoPath
            // 
            this.LblPhotoPath.BackColor = System.Drawing.SystemColors.Window;
            this.LblPhotoPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsClient, "PhotoPath", true));
            this.LblPhotoPath.ForeColor = System.Drawing.Color.White;
            this.LblPhotoPath.Location = new System.Drawing.Point(109, 350);
            this.LblPhotoPath.Name = "LblPhotoPath";
            this.LblPhotoPath.Size = new System.Drawing.Size(100, 23);
            this.LblPhotoPath.TabIndex = 23;
            this.LblPhotoPath.Text = "label2";
            // 
            // OpenPhoto
            // 
            this.OpenPhoto.FileName = "openFileDialog1";
            // 
            // registrationDateDateTimePicker
            // 
            this.registrationDateDateTimePicker.CalendarForeColor = System.Drawing.Color.White;
            this.registrationDateDateTimePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.registrationDateDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.White;
            this.registrationDateDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.White;
            this.registrationDateDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.registrationDateDateTimePicker.Checked = false;
            this.registrationDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BsClient, "RegistrationDate", true));
            this.registrationDateDateTimePicker.Location = new System.Drawing.Point(238, 503);
            this.registrationDateDateTimePicker.Name = "registrationDateDateTimePicker";
            this.registrationDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.registrationDateDateTimePicker.TabIndex = 24;
            // 
            // FormAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 343);
            this.Controls.Add(this.registrationDateDateTimePicker);
            this.Controls.Add(this.LblPhotoPath);
            this.Controls.Add(this.LblGenderCode);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.RbtFGender);
            this.Controls.Add(this.RbtMGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.TbxPhone);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.TbxMail);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.DtpBirth);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.TbxPatron);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.TbxFam);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.PanelZag);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 382);
            this.MinimumSize = new System.Drawing.Size(540, 382);
            this.Name = "FormAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "СУБД \"Автосервис\"";
            this.Load += new System.EventHandler(this.FormAddEdit_Load);
            this.PanelZag.ResumeLayout(false);
            this.PanelZag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelZag;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.PictureBox PbxLogo;
        private AutoServiceDataSet autoServiceDataSet;
        private AutoServiceDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private AutoServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.TextBox TbxFam;
        private System.Windows.Forms.TextBox TbxPatron;
        private System.Windows.Forms.DateTimePicker DtpBirth;
        private System.Windows.Forms.TextBox TbxMail;
        private System.Windows.Forms.TextBox TbxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbtMGender;
        private System.Windows.Forms.RadioButton RbtFGender;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        public System.Windows.Forms.BindingSource BsClient;
        private System.Windows.Forms.Label LblGenderCode;
        private System.Windows.Forms.Label LblPhotoPath;
        private System.Windows.Forms.OpenFileDialog OpenPhoto;
        private System.Windows.Forms.DateTimePicker registrationDateDateTimePicker;
    }
}