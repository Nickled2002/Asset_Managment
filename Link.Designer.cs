namespace Asset_Managment
{
    partial class Link
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Link));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mssql2001975DataSet7 = new Asset_Managment.mssql2001975DataSet7();
            this.assetManagerHardwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asset_Manager_HardwareTableAdapter = new Asset_Managment.mssql2001975DataSet7TableAdapters.Asset_Manager_HardwareTableAdapter();
            this.hardwareIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mssql2001975DataSet8 = new Asset_Managment.mssql2001975DataSet8();
            this.assetManagerSoftwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asset_Manager_SoftwareTableAdapter = new Asset_Managment.mssql2001975DataSet8TableAdapters.Asset_Manager_SoftwareTableAdapter();
            this.softwareIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatingSystemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.LinkBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerHardwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 80);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(132)))), ((int)(((byte)(4)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(797, 80);
            this.label2.TabIndex = 0;
            this.label2.Text = "ScottishGlen Linked Assets";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hardwareIdDataGridViewTextBoxColumn,
            this.systemNameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.iPAddressDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assetManagerHardwareBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(419, 203);
            this.dataGridView1.TabIndex = 8;
            // 
            // mssql2001975DataSet7
            // 
            this.mssql2001975DataSet7.DataSetName = "mssql2001975DataSet7";
            this.mssql2001975DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetManagerHardwareBindingSource
            // 
            this.assetManagerHardwareBindingSource.DataMember = "Asset_Manager_Hardware";
            this.assetManagerHardwareBindingSource.DataSource = this.mssql2001975DataSet7;
            // 
            // asset_Manager_HardwareTableAdapter
            // 
            this.asset_Manager_HardwareTableAdapter.ClearBeforeFill = true;
            // 
            // hardwareIdDataGridViewTextBoxColumn
            // 
            this.hardwareIdDataGridViewTextBoxColumn.DataPropertyName = "Hardware_Id";
            this.hardwareIdDataGridViewTextBoxColumn.HeaderText = "Hardware_Id";
            this.hardwareIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hardwareIdDataGridViewTextBoxColumn.Name = "hardwareIdDataGridViewTextBoxColumn";
            this.hardwareIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.hardwareIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // systemNameDataGridViewTextBoxColumn
            // 
            this.systemNameDataGridViewTextBoxColumn.DataPropertyName = "System_Name";
            this.systemNameDataGridViewTextBoxColumn.HeaderText = "System_Name";
            this.systemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.systemNameDataGridViewTextBoxColumn.Name = "systemNameDataGridViewTextBoxColumn";
            this.systemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.systemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // iPAddressDataGridViewTextBoxColumn
            // 
            this.iPAddressDataGridViewTextBoxColumn.DataPropertyName = "IP_Address";
            this.iPAddressDataGridViewTextBoxColumn.HeaderText = "IP_Address";
            this.iPAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iPAddressDataGridViewTextBoxColumn.Name = "iPAddressDataGridViewTextBoxColumn";
            this.iPAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.iPAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "Purchase_Date";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "Purchase_Date";
            this.purchaseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchaseDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.softwareIdDataGridViewTextBoxColumn,
            this.operatingSystemNameDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.assetManagerSoftwareBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(421, 134);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(378, 203);
            this.dataGridView2.TabIndex = 9;
            // 
            // mssql2001975DataSet8
            // 
            this.mssql2001975DataSet8.DataSetName = "mssql2001975DataSet8";
            this.mssql2001975DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetManagerSoftwareBindingSource
            // 
            this.assetManagerSoftwareBindingSource.DataMember = "Asset_Manager_Software";
            this.assetManagerSoftwareBindingSource.DataSource = this.mssql2001975DataSet8;
            // 
            // asset_Manager_SoftwareTableAdapter
            // 
            this.asset_Manager_SoftwareTableAdapter.ClearBeforeFill = true;
            // 
            // softwareIdDataGridViewTextBoxColumn
            // 
            this.softwareIdDataGridViewTextBoxColumn.DataPropertyName = "Software_Id";
            this.softwareIdDataGridViewTextBoxColumn.HeaderText = "Software_Id";
            this.softwareIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.softwareIdDataGridViewTextBoxColumn.Name = "softwareIdDataGridViewTextBoxColumn";
            this.softwareIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.softwareIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // operatingSystemNameDataGridViewTextBoxColumn
            // 
            this.operatingSystemNameDataGridViewTextBoxColumn.DataPropertyName = "Operating_System_Name";
            this.operatingSystemNameDataGridViewTextBoxColumn.HeaderText = "Operating_System_Name";
            this.operatingSystemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operatingSystemNameDataGridViewTextBoxColumn.Name = "operatingSystemNameDataGridViewTextBoxColumn";
            this.operatingSystemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatingSystemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.ReadOnly = true;
            this.versionDataGridViewTextBoxColumn.Width = 125;
            // 
            // manufacturerDataGridViewTextBoxColumn1
            // 
            this.manufacturerDataGridViewTextBoxColumn1.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn1.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.manufacturerDataGridViewTextBoxColumn1.Name = "manufacturerDataGridViewTextBoxColumn1";
            this.manufacturerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn1.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Clck the assets you want to link together";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 394);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(117, 44);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LinkBtn
            // 
            this.LinkBtn.Location = new System.Drawing.Point(671, 394);
            this.LinkBtn.Name = "LinkBtn";
            this.LinkBtn.Size = new System.Drawing.Size(117, 44);
            this.LinkBtn.TabIndex = 12;
            this.LinkBtn.Text = "Link";
            this.LinkBtn.UseVisualStyleBackColor = true;
            this.LinkBtn.Click += new System.EventHandler(this.LinkBtn_Click);
            // 
            // Link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LinkBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Link";
            this.Text = "Link";
            this.Load += new System.EventHandler(this.Link_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerHardwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mssql2001975DataSet7 mssql2001975DataSet7;
        private System.Windows.Forms.BindingSource assetManagerHardwareBindingSource;
        private mssql2001975DataSet7TableAdapters.Asset_Manager_HardwareTableAdapter asset_Manager_HardwareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardwareIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private mssql2001975DataSet8 mssql2001975DataSet8;
        private System.Windows.Forms.BindingSource assetManagerSoftwareBindingSource;
        private mssql2001975DataSet8TableAdapters.Asset_Manager_SoftwareTableAdapter asset_Manager_SoftwareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatingSystemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button LinkBtn;
    }
}