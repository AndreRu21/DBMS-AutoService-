
namespace СУБД_Автосервис_Рудаков
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.PanelZag = new System.Windows.Forms.Panel();
            this.LblClients = new System.Windows.Forms.Label();
            this.StsZapisi = new System.Windows.Forms.StatusStrip();
            this.TsLblZapisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblFindType = new System.Windows.Forms.Label();
            this.LblFindText = new System.Windows.Forms.Label();
            this.LblGenderFilter = new System.Windows.Forms.Label();
            this.LblSortType = new System.Windows.Forms.Label();
            this.LblCountZap = new System.Windows.Forms.Label();
            this.CmbFindType = new System.Windows.Forms.ComboBox();
            this.CmbGenderFilter = new System.Windows.Forms.ComboBox();
            this.CmbSortType = new System.Windows.Forms.ComboBox();
            this.CmbCountZap = new System.Windows.Forms.ComboBox();
            this.TbxFind = new System.Windows.Forms.TextBox();
            this.DgvClients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnPosesh = new System.Windows.Forms.Button();
            this.PanelPages = new System.Windows.Forms.Panel();
            this.LblNext = new System.Windows.Forms.Label();
            this.LblBack = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.PanelZag.SuspendLayout();
            this.StsZapisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClients)).BeginInit();
            this.PanelPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelZag
            // 
            this.PanelZag.BackColor = System.Drawing.Color.LightGray;
            this.PanelZag.Controls.Add(this.LblClients);
            this.PanelZag.Controls.Add(this.PbxLogo);
            this.PanelZag.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelZag.Location = new System.Drawing.Point(0, 0);
            this.PanelZag.Name = "PanelZag";
            this.PanelZag.Size = new System.Drawing.Size(810, 100);
            this.PanelZag.TabIndex = 0;
            // 
            // LblClients
            // 
            this.LblClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblClients.AutoSize = true;
            this.LblClients.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblClients.Location = new System.Drawing.Point(133, 25);
            this.LblClients.Name = "LblClients";
            this.LblClients.Size = new System.Drawing.Size(458, 54);
            this.LblClients.TabIndex = 1;
            this.LblClients.Text = "Список клиентов";
            // 
            // StsZapisi
            // 
            this.StsZapisi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsLblZapisi});
            this.StsZapisi.Location = new System.Drawing.Point(0, 498);
            this.StsZapisi.Name = "StsZapisi";
            this.StsZapisi.Size = new System.Drawing.Size(810, 22);
            this.StsZapisi.TabIndex = 1;
            this.StsZapisi.Text = "statusStrip1";
            // 
            // TsLblZapisi
            // 
            this.TsLblZapisi.Name = "TsLblZapisi";
            this.TsLblZapisi.Size = new System.Drawing.Size(180, 17);
            this.TsLblZapisi.Text = "Всего записей: , отображается: ";
            // 
            // LblFindType
            // 
            this.LblFindType.AutoSize = true;
            this.LblFindType.Location = new System.Drawing.Point(139, 115);
            this.LblFindType.Name = "LblFindType";
            this.LblFindType.Size = new System.Drawing.Size(70, 15);
            this.LblFindType.TabIndex = 2;
            this.LblFindType.Text = "Поиск по:";
            // 
            // LblFindText
            // 
            this.LblFindText.AutoSize = true;
            this.LblFindText.Location = new System.Drawing.Point(266, 115);
            this.LblFindText.Name = "LblFindText";
            this.LblFindText.Size = new System.Drawing.Size(182, 15);
            this.LblFindText.TabIndex = 3;
            this.LblFindText.Text = "Введите текст для поиска:";
            // 
            // LblGenderFilter
            // 
            this.LblGenderFilter.AutoSize = true;
            this.LblGenderFilter.Location = new System.Drawing.Point(451, 115);
            this.LblGenderFilter.Name = "LblGenderFilter";
            this.LblGenderFilter.Size = new System.Drawing.Size(140, 15);
            this.LblGenderFilter.TabIndex = 4;
            this.LblGenderFilter.Text = "Фильтрация по полу:";
            // 
            // LblSortType
            // 
            this.LblSortType.AutoSize = true;
            this.LblSortType.Location = new System.Drawing.Point(594, 115);
            this.LblSortType.Name = "LblSortType";
            this.LblSortType.Size = new System.Drawing.Size(112, 15);
            this.LblSortType.TabIndex = 5;
            this.LblSortType.Text = "Сортировать по:";
            // 
            // LblCountZap
            // 
            this.LblCountZap.AutoSize = true;
            this.LblCountZap.Location = new System.Drawing.Point(9, 115);
            this.LblCountZap.Name = "LblCountZap";
            this.LblCountZap.Size = new System.Drawing.Size(112, 15);
            this.LblCountZap.TabIndex = 6;
            this.LblCountZap.Text = "Кол-во записей:";
            // 
            // CmbFindType
            // 
            this.CmbFindType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFindType.FormattingEnabled = true;
            this.CmbFindType.Items.AddRange(new object[] {
            "Фамилии",
            "Имени",
            "Отчеству"});
            this.CmbFindType.Location = new System.Drawing.Point(142, 133);
            this.CmbFindType.Name = "CmbFindType";
            this.CmbFindType.Size = new System.Drawing.Size(121, 23);
            this.CmbFindType.TabIndex = 7;
            this.CmbFindType.SelectedIndexChanged += new System.EventHandler(this.CmbFindType_SelectedIndexChanged);
            // 
            // CmbGenderFilter
            // 
            this.CmbGenderFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGenderFilter.FormattingEnabled = true;
            this.CmbGenderFilter.Items.AddRange(new object[] {
            "М",
            "Ж",
            "Все"});
            this.CmbGenderFilter.Location = new System.Drawing.Point(454, 133);
            this.CmbGenderFilter.Name = "CmbGenderFilter";
            this.CmbGenderFilter.Size = new System.Drawing.Size(137, 23);
            this.CmbGenderFilter.TabIndex = 8;
            this.CmbGenderFilter.SelectedIndexChanged += new System.EventHandler(this.CmbGenderFilter_SelectedIndexChanged);
            // 
            // CmbSortType
            // 
            this.CmbSortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSortType.FormattingEnabled = true;
            this.CmbSortType.Items.AddRange(new object[] {
            "Без сортировки",
            "Фамилии",
            "Дате последнего посещения",
            "Кол-ву посещений"});
            this.CmbSortType.Location = new System.Drawing.Point(597, 133);
            this.CmbSortType.Name = "CmbSortType";
            this.CmbSortType.Size = new System.Drawing.Size(203, 23);
            this.CmbSortType.TabIndex = 9;
            this.CmbSortType.SelectedIndexChanged += new System.EventHandler(this.CmbSortType_SelectedIndexChanged);
            // 
            // CmbCountZap
            // 
            this.CmbCountZap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCountZap.FormattingEnabled = true;
            this.CmbCountZap.Items.AddRange(new object[] {
            "5",
            "10",
            "все"});
            this.CmbCountZap.Location = new System.Drawing.Point(12, 133);
            this.CmbCountZap.Name = "CmbCountZap";
            this.CmbCountZap.Size = new System.Drawing.Size(121, 23);
            this.CmbCountZap.TabIndex = 10;
            this.CmbCountZap.SelectedIndexChanged += new System.EventHandler(this.CmbCountZap_SelectedIndexChanged);
            // 
            // TbxFind
            // 
            this.TbxFind.Location = new System.Drawing.Point(269, 133);
            this.TbxFind.Name = "TbxFind";
            this.TbxFind.Size = new System.Drawing.Size(179, 21);
            this.TbxFind.TabIndex = 11;
            this.TbxFind.TextChanged += new System.EventHandler(this.TbxFind_TextChanged);
            // 
            // DgvClients
            // 
            this.DgvClients.AllowUserToAddRows = false;
            this.DgvClients.AllowUserToDeleteRows = false;
            this.DgvClients.AllowUserToResizeColumns = false;
            this.DgvClients.AllowUserToResizeRows = false;
            this.DgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClients.ColumnHeadersVisible = false;
            this.DgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvClients.Location = new System.Drawing.Point(12, 174);
            this.DgvClients.Name = "DgvClients";
            this.DgvClients.ReadOnly = true;
            this.DgvClients.RowHeadersVisible = false;
            this.DgvClients.RowTemplate.Height = 70;
            this.DgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClients.Size = new System.Drawing.Size(786, 228);
            this.DgvClients.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фото";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Информация";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.BtnAdd.Location = new System.Drawing.Point(12, 422);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(95, 23);
            this.BtnAdd.TabIndex = 13;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.BtnEdit.Location = new System.Drawing.Point(113, 422);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(150, 23);
            this.BtnEdit.TabIndex = 14;
            this.BtnEdit.Text = "Редактировать";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.BtnDelete.Location = new System.Drawing.Point(269, 422);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(105, 23);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnPosesh
            // 
            this.BtnPosesh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPosesh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.BtnPosesh.Location = new System.Drawing.Point(654, 422);
            this.BtnPosesh.Name = "BtnPosesh";
            this.BtnPosesh.Size = new System.Drawing.Size(144, 23);
            this.BtnPosesh.TabIndex = 16;
            this.BtnPosesh.Text = "Посещения";
            this.BtnPosesh.UseVisualStyleBackColor = false;
            this.BtnPosesh.Click += new System.EventHandler(this.BtnPosesh_Click);
            // 
            // PanelPages
            // 
            this.PanelPages.Controls.Add(this.LblNext);
            this.PanelPages.Controls.Add(this.LblBack);
            this.PanelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelPages.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PanelPages.Location = new System.Drawing.Point(0, 465);
            this.PanelPages.Name = "PanelPages";
            this.PanelPages.Size = new System.Drawing.Size(810, 33);
            this.PanelPages.TabIndex = 17;
            // 
            // LblNext
            // 
            this.LblNext.AutoSize = true;
            this.LblNext.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblNext.Location = new System.Drawing.Point(115, 15);
            this.LblNext.Name = "LblNext";
            this.LblNext.Size = new System.Drawing.Size(18, 18);
            this.LblNext.TabIndex = 1;
            this.LblNext.Text = ">";
            this.LblNext.Click += new System.EventHandler(this.LblNext_Click);
            // 
            // LblBack
            // 
            this.LblBack.AutoSize = true;
            this.LblBack.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblBack.Location = new System.Drawing.Point(12, 15);
            this.LblBack.Name = "LblBack";
            this.LblBack.Size = new System.Drawing.Size(18, 18);
            this.LblBack.TabIndex = 0;
            this.LblBack.Text = "<";
            this.LblBack.Click += new System.EventHandler(this.LblBack_Click);
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = global::СУБД_Автосервис_Рудаков.Properties.Resources.service_logo;
            this.PbxLogo.Location = new System.Drawing.Point(710, 0);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(100, 100);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 520);
            this.Controls.Add(this.PanelPages);
            this.Controls.Add(this.BtnPosesh);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DgvClients);
            this.Controls.Add(this.TbxFind);
            this.Controls.Add(this.CmbCountZap);
            this.Controls.Add(this.CmbSortType);
            this.Controls.Add(this.CmbGenderFilter);
            this.Controls.Add(this.CmbFindType);
            this.Controls.Add(this.LblCountZap);
            this.Controls.Add(this.LblSortType);
            this.Controls.Add(this.LblGenderFilter);
            this.Controls.Add(this.LblFindText);
            this.Controls.Add(this.LblFindType);
            this.Controls.Add(this.StsZapisi);
            this.Controls.Add(this.PanelZag);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(826, 559);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Автосервис";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.PanelZag.ResumeLayout(false);
            this.PanelZag.PerformLayout();
            this.StsZapisi.ResumeLayout(false);
            this.StsZapisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClients)).EndInit();
            this.PanelPages.ResumeLayout(false);
            this.PanelPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelZag;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Label LblClients;
        private System.Windows.Forms.StatusStrip StsZapisi;
        private System.Windows.Forms.ToolStripStatusLabel TsLblZapisi;
        private System.Windows.Forms.Label LblFindType;
        private System.Windows.Forms.Label LblFindText;
        private System.Windows.Forms.Label LblGenderFilter;
        private System.Windows.Forms.Label LblSortType;
        private System.Windows.Forms.Label LblCountZap;
        private System.Windows.Forms.ComboBox CmbFindType;
        private System.Windows.Forms.ComboBox CmbGenderFilter;
        private System.Windows.Forms.ComboBox CmbSortType;
        private System.Windows.Forms.ComboBox CmbCountZap;
        private System.Windows.Forms.TextBox TbxFind;
        private System.Windows.Forms.DataGridView DgvClients;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnPosesh;
        private System.Windows.Forms.Panel PanelPages;
        private System.Windows.Forms.Label LblNext;
        private System.Windows.Forms.Label LblBack;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

