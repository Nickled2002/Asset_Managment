namespace Asset_Managment
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SystemNameTb = new System.Windows.Forms.TextBox();
            this.DltBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.assetManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetManagerHardwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mssql2001975DataSet2 = new Asset_Managment.mssql2001975DataSet2();
            this.assetManagerHardwareBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asset_Manager_HardwareTableAdapter = new Asset_Managment.mssql2001975DataSet2TableAdapters.Asset_Manager_HardwareTableAdapter();
            this.hardwareIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerHardwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerHardwareBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 80);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(132)))), ((int)(((byte)(4)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "ScottishGlen Hardware Assets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter the system name that you would like to delete";
            // 
            // SystemNameTb
            // 
            this.SystemNameTb.Location = new System.Drawing.Point(520, 344);
            this.SystemNameTb.Multiline = true;
            this.SystemNameTb.Name = "SystemNameTb";
            this.SystemNameTb.Size = new System.Drawing.Size(268, 33);
            this.SystemNameTb.TabIndex = 7;
            // 
            // DltBtn
            // 
            this.DltBtn.Location = new System.Drawing.Point(588, 393);
            this.DltBtn.Name = "DltBtn";
            this.DltBtn.Size = new System.Drawing.Size(200, 45);
            this.DltBtn.TabIndex = 8;
            this.DltBtn.Text = "Delete";
            this.DltBtn.UseVisualStyleBackColor = true;
            this.DltBtn.Click += new System.EventHandler(this.DltBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(10, 393);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(200, 45);
            this.BackBtn.TabIndex = 9;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
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
            this.dataGridView1.DataSource = this.assetManagerHardwareBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 248);
            this.dataGridView1.TabIndex = 10;
            // 
            // mssql2001975DataSet2
            // 
            this.mssql2001975DataSet2.DataSetName = "mssql2001975DataSet2";
            this.mssql2001975DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetManagerHardwareBindingSource1
            // 
            this.assetManagerHardwareBindingSource1.DataMember = "Asset_Manager_Hardware";
            this.assetManagerHardwareBindingSource1.DataSource = this.mssql2001975DataSet2;
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
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DltBtn);
            this.Controls.Add(this.SystemNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Delete";
            this.Text = "Delete Item";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerHardwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerHardwareBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SystemNameTb;
        private System.Windows.Forms.Button DltBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.BindingSource assetManagerBindingSource;
        private System.Windows.Forms.BindingSource assetManagerHardwareBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mssql2001975DataSet2 mssql2001975DataSet2;
        private System.Windows.Forms.BindingSource assetManagerHardwareBindingSource1;
        private mssql2001975DataSet2TableAdapters.Asset_Manager_HardwareTableAdapter asset_Manager_HardwareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardwareIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}