namespace Asset_Managment
{
    partial class EditS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditS));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mssql2001975DataSet5 = new Asset_Managment.mssql2001975DataSet5();
            this.assetManagerSoftwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asset_Manager_SoftwareTableAdapter = new Asset_Managment.mssql2001975DataSet5TableAdapters.Asset_Manager_SoftwareTableAdapter();
            this.operatingSystemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 80);
            this.panel2.TabIndex = 26;
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
            this.label1.Text = "ScottishGlen Software Assets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operatingSystemNameDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assetManagerSoftwareBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 235);
            this.dataGridView1.TabIndex = 27;
            // 
            // mssql2001975DataSet5
            // 
            this.mssql2001975DataSet5.DataSetName = "mssql2001975DataSet5";
            this.mssql2001975DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetManagerSoftwareBindingSource
            // 
            this.assetManagerSoftwareBindingSource.DataMember = "Asset_Manager_Software";
            this.assetManagerSoftwareBindingSource.DataSource = this.mssql2001975DataSet5;
            // 
            // asset_Manager_SoftwareTableAdapter
            // 
            this.asset_Manager_SoftwareTableAdapter.ClearBeforeFill = true;
            // 
            // operatingSystemNameDataGridViewTextBoxColumn
            // 
            this.operatingSystemNameDataGridViewTextBoxColumn.DataPropertyName = "Operating_System_Name";
            this.operatingSystemNameDataGridViewTextBoxColumn.HeaderText = "Operating_System_Name";
            this.operatingSystemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operatingSystemNameDataGridViewTextBoxColumn.Name = "operatingSystemNameDataGridViewTextBoxColumn";
            this.operatingSystemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.Width = 125;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "To edit a field click on the field you want to edit and complete the changes";
            // 
            // FinishBtn
            // 
            this.FinishBtn.Location = new System.Drawing.Point(263, 375);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(237, 63);
            this.FinishBtn.TabIndex = 29;
            this.FinishBtn.Text = "Finish Editing";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // EditS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditS";
            this.Text = "Edit Item";
            this.Load += new System.EventHandler(this.EditS_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerSoftwareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mssql2001975DataSet5 mssql2001975DataSet5;
        private System.Windows.Forms.BindingSource assetManagerSoftwareBindingSource;
        private mssql2001975DataSet5TableAdapters.Asset_Manager_SoftwareTableAdapter asset_Manager_SoftwareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatingSystemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FinishBtn;
    }
}