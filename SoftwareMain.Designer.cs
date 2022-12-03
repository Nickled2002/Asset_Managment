namespace Asset_Managment
{
    partial class SoftwareMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.assetManagerSoftwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.assetManagerSoftwareBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assetManagerSoftwareBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatingSystemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetManagerSoftwareBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mssql2001975DataSet = new Asset_Managment.mssql2001975DataSet();
            this.asset_Manager_SoftwareTableAdapter = new Asset_Managment.mssql2001975DataSetTableAdapters.Asset_Manager_SoftwareTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 80);
            this.panel1.TabIndex = 4;
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
            this.label2.Size = new System.Drawing.Size(683, 80);
            this.label2.TabIndex = 0;
            this.label2.Text = "ScottishGlen Software Assets";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(9, 324);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(108, 50);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(123, 324);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(108, 50);
            this.EditBtn.TabIndex = 7;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(237, 324);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(108, 50);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(564, 324);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(108, 50);
            this.BackBtn.TabIndex = 10;
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
            this.dataGridViewTextBoxColumn4,
            this.operatingSystemNameDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assetManagerSoftwareBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(1, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(683, 233);
            this.dataGridView1.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Software_Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Software_Id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
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
            // assetManagerSoftwareBindingSource3
            // 
            this.assetManagerSoftwareBindingSource3.DataMember = "Asset_Manager_Software";
            this.assetManagerSoftwareBindingSource3.DataSource = this.mssql2001975DataSet;
            // 
            // mssql2001975DataSet
            // 
            this.mssql2001975DataSet.DataSetName = "mssql2001975DataSet";
            this.mssql2001975DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asset_Manager_SoftwareTableAdapter
            // 
            this.asset_Manager_SoftwareTableAdapter.ClearBeforeFill = true;
            // 
            // SoftwareMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 386);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoftwareMain";
            this.Text = "Software Asset Manager";
            this.Load += new System.EventHandler(this.SoftwareMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource assetManagerSoftwareBindingSource;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.BindingSource assetManagerSoftwareBindingSource1;
        private System.Windows.Forms.BindingSource assetManagerSoftwareBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mssql2001975DataSet mssql2001975DataSet;
        private System.Windows.Forms.BindingSource assetManagerSoftwareBindingSource3;
        private mssql2001975DataSetTableAdapters.Asset_Manager_SoftwareTableAdapter asset_Manager_SoftwareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatingSystemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
    }
}