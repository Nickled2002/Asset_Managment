namespace Asset_Managment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.assetManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Dlt_Btn = new System.Windows.Forms.Button();
            this.This_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.assetManagerHardwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssql2001975DataSet1 = new Asset_Managment.mssql2001975DataSet1();
            this.assetManagerHardwareBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asset_Manager_HardwareTableAdapter = new Asset_Managment.mssql2001975DataSet1TableAdapters.Asset_Manager_HardwareTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hardwareIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerHardwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerHardwareBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(12, 395);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(110, 43);
            this.Add_Btn.TabIndex = 4;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.Location = new System.Drawing.Point(128, 395);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(110, 43);
            this.Edit_Btn.TabIndex = 5;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // Dlt_Btn
            // 
            this.Dlt_Btn.Location = new System.Drawing.Point(244, 395);
            this.Dlt_Btn.Name = "Dlt_Btn";
            this.Dlt_Btn.Size = new System.Drawing.Size(110, 43);
            this.Dlt_Btn.TabIndex = 6;
            this.Dlt_Btn.Text = "Delete";
            this.Dlt_Btn.UseVisualStyleBackColor = true;
            this.Dlt_Btn.Click += new System.EventHandler(this.Dlt_Btn_Click);
            // 
            // This_Btn
            // 
            this.This_Btn.Location = new System.Drawing.Point(360, 395);
            this.This_Btn.Name = "This_Btn";
            this.This_Btn.Size = new System.Drawing.Size(110, 43);
            this.This_Btn.TabIndex = 7;
            this.This_Btn.Text = "This machine";
            this.This_Btn.UseVisualStyleBackColor = true;
            this.This_Btn.Click += new System.EventHandler(this.This_Btn_Click);
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
            this.label1.Size = new System.Drawing.Size(926, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "ScottishGlen Hardware Assets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 80);
            this.panel2.TabIndex = 2;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(804, 395);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(110, 43);
            this.BackBtn.TabIndex = 8;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // mssql2001975DataSet1
            // 
            this.mssql2001975DataSet1.DataSetName = "mssql2001975DataSet1";
            this.mssql2001975DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetManagerHardwareBindingSource1
            // 
            this.assetManagerHardwareBindingSource1.DataMember = "Asset_Manager_Hardware";
            this.assetManagerHardwareBindingSource1.DataSource = this.mssql2001975DataSet1;
            // 
            // asset_Manager_HardwareTableAdapter
            // 
            this.asset_Manager_HardwareTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(926, 300);
            this.dataGridView1.TabIndex = 9;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.This_Btn);
            this.Controls.Add(this.Dlt_Btn);
            this.Controls.Add(this.Edit_Btn);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hardware Asset Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerHardwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerHardwareBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource assetManagerBindingSource;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Dlt_Btn;
        private System.Windows.Forms.Button This_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.BindingSource assetManagerHardwareBindingSource;
        private mssql2001975DataSet1 mssql2001975DataSet1;
        private System.Windows.Forms.BindingSource assetManagerHardwareBindingSource1;
        private mssql2001975DataSet1TableAdapters.Asset_Manager_HardwareTableAdapter asset_Manager_HardwareTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
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

