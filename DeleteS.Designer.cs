namespace Asset_Managment
{
    partial class DeleteS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.assetManagerSoftwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BackBtn = new System.Windows.Forms.Button();
            this.DltBtn = new System.Windows.Forms.Button();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.assetManagerSoftwareBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mssql2001975DataSet3 = new Asset_Managment.mssql2001975DataSet3();
            this.assetManagerSoftwareBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.asset_Manager_SoftwareTableAdapter = new Asset_Managment.mssql2001975DataSet3TableAdapters.Asset_Manager_SoftwareTableAdapter();
            this.softwareIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatingSystemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 80);
            this.panel1.TabIndex = 5;
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
            this.label2.Text = "ScottishGlen Software Assets";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(10, 397);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(200, 45);
            this.BackBtn.TabIndex = 13;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DltBtn
            // 
            this.DltBtn.Location = new System.Drawing.Point(588, 397);
            this.DltBtn.Name = "DltBtn";
            this.DltBtn.Size = new System.Drawing.Size(200, 45);
            this.DltBtn.TabIndex = 12;
            this.DltBtn.Text = "Delete";
            this.DltBtn.UseVisualStyleBackColor = true;
            this.DltBtn.Click += new System.EventHandler(this.DltBtn_Click);
            // 
            // IdTb
            // 
            this.IdTb.Location = new System.Drawing.Point(564, 348);
            this.IdTb.Multiline = true;
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(224, 33);
            this.IdTb.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter the Id of the operating system that you would like to delete";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.softwareIdDataGridViewTextBoxColumn,
            this.operatingSystemNameDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assetManagerSoftwareBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(4, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 253);
            this.dataGridView1.TabIndex = 14;
            // 
            // mssql2001975DataSet3
            // 
            this.mssql2001975DataSet3.DataSetName = "mssql2001975DataSet3";
            this.mssql2001975DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetManagerSoftwareBindingSource2
            // 
            this.assetManagerSoftwareBindingSource2.DataMember = "Asset_Manager_Software";
            this.assetManagerSoftwareBindingSource2.DataSource = this.mssql2001975DataSet3;
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
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn.Width = 125;
            // 
            // DeleteS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DltBtn);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteS";
            this.Text = "Delete Item";
            this.Load += new System.EventHandler(this.DeleteS_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource assetManagerSoftwareBindingSource;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DltBtn;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource assetManagerSoftwareBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mssql2001975DataSet3 mssql2001975DataSet3;
        private System.Windows.Forms.BindingSource assetManagerSoftwareBindingSource2;
        private mssql2001975DataSet3TableAdapters.Asset_Manager_SoftwareTableAdapter asset_Manager_SoftwareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatingSystemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
    }
}