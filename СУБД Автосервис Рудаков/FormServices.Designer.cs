
namespace СУБД_Автосервис_Рудаков
{
    partial class FormServices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServices));
            this.PanelZag = new System.Windows.Forms.Panel();
            this.LblClients = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.autoServiceDataSet = new СУБД_Автосервис_Рудаков.AutoServiceDataSet();
            this.bsCurrentClientService = new System.Windows.Forms.BindingSource(this.components);
            this.currentClientServiceTableAdapter = new СУБД_Автосервис_Рудаков.AutoServiceDataSetTableAdapters.CurrentClientServiceTableAdapter();
            this.tableAdapterManager = new СУБД_Автосервис_Рудаков.AutoServiceDataSetTableAdapters.TableAdapterManager();
            this.txtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelZag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrentClientService)).BeginInit();
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
            this.PanelZag.Size = new System.Drawing.Size(799, 108);
            this.PanelZag.TabIndex = 1;
            // 
            // LblClients
            // 
            this.LblClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblClients.AutoSize = true;
            this.LblClients.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblClients.Location = new System.Drawing.Point(119, 28);
            this.LblClients.Name = "LblClients";
            this.LblClients.Size = new System.Drawing.Size(487, 54);
            this.LblClients.TabIndex = 1;
            this.LblClients.Text = "Список посещений";
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = global::СУБД_Автосервис_Рудаков.Properties.Resources.service_logo;
            this.PbxLogo.Location = new System.Drawing.Point(682, 0);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(117, 108);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(233, 390);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(325, 52);
            this.BtnOK.TabIndex = 17;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = false;
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeColumns = false;
            this.dgvServices.AllowUserToResizeRows = false;
            this.dgvServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServices.BackgroundColor = System.Drawing.Color.White;
            this.dgvServices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.ColumnHeadersVisible = false;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvServices.GridColor = System.Drawing.Color.White;
            this.dgvServices.Location = new System.Drawing.Point(49, 125);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvServices.RowTemplate.DividerHeight = 10;
            this.dgvServices.RowTemplate.Height = 40;
            this.dgvServices.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(703, 259);
            this.dgvServices.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AllowUserToResizeColumns = false;
            this.dgv2.AllowUserToResizeRows = false;
            this.dgv2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv2.AutoGenerateColumns = false;
            this.dgv2.BackgroundColor = System.Drawing.Color.White;
            this.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.ColumnHeadersVisible = false;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtDataGridViewTextBoxColumn});
            this.dgv2.DataSource = this.bsCurrentClientService;
            this.dgv2.GridColor = System.Drawing.Color.White;
            this.dgv2.Location = new System.Drawing.Point(790, 453);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv2.RowTemplate.DividerHeight = 10;
            this.dgv2.RowTemplate.Height = 40;
            this.dgv2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(266, 126);
            this.dgv2.TabIndex = 19;
            // 
            // autoServiceDataSet
            // 
            this.autoServiceDataSet.DataSetName = "AutoServiceDataSet";
            this.autoServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsCurrentClientService
            // 
            this.bsCurrentClientService.DataMember = "CurrentClientService";
            this.bsCurrentClientService.DataSource = this.autoServiceDataSet;
            // 
            // currentClientServiceTableAdapter
            // 
            this.currentClientServiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientServiceTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Автосервис_Рудаков.AutoServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtDataGridViewTextBoxColumn
            // 
            this.txtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtDataGridViewTextBoxColumn.DataPropertyName = "Txt";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.txtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtDataGridViewTextBoxColumn.HeaderText = "Txt";
            this.txtDataGridViewTextBoxColumn.Name = "txtDataGridViewTextBoxColumn";
            this.txtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 454);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.PanelZag);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(815, 493);
            this.Name = "FormServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "СУБД Автосервис";
            this.Load += new System.EventHandler(this.FormServices_Load);
            this.PanelZag.ResumeLayout(false);
            this.PanelZag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrentClientService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelZag;
        private System.Windows.Forms.Label LblClients;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgv2;
        private AutoServiceDataSet autoServiceDataSet;
        private AutoServiceDataSetTableAdapters.CurrentClientServiceTableAdapter currentClientServiceTableAdapter;
        private AutoServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingSource bsCurrentClientService;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDataGridViewTextBoxColumn;
    }
}