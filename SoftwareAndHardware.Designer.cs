namespace Asset_Managment
{
    partial class SoftwareAndHardware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareAndHardware));
            this.assetManagerLinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.LinkBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mssql2001975DataSet6 = new Asset_Managment.mssql2001975DataSet6();
            this.assetManagerLinkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asset_Manager_LinkTableAdapter = new Asset_Managment.mssql2001975DataSet6TableAdapters.Asset_Manager_LinkTableAdapter();
            this.linkIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerLinkBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerLinkBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 80);
            this.panel1.TabIndex = 6;
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
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 389);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(121, 49);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LinkBtn
            // 
            this.LinkBtn.Location = new System.Drawing.Point(667, 389);
            this.LinkBtn.Name = "LinkBtn";
            this.LinkBtn.Size = new System.Drawing.Size(121, 49);
            this.LinkBtn.TabIndex = 8;
            this.LinkBtn.Text = "Link Assets";
            this.LinkBtn.UseVisualStyleBackColor = true;
            this.LinkBtn.Click += new System.EventHandler(this.LinkBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.assetManagerLinkBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 276);
            this.dataGridView1.TabIndex = 9;
            // 
            // mssql2001975DataSet6
            // 
            this.mssql2001975DataSet6.DataSetName = "mssql2001975DataSet6";
            this.mssql2001975DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetManagerLinkBindingSource1
            // 
            this.assetManagerLinkBindingSource1.DataMember = "Asset_Manager_Link";
            this.assetManagerLinkBindingSource1.DataSource = this.mssql2001975DataSet6;
            // 
            // asset_Manager_LinkTableAdapter
            // 
            this.asset_Manager_LinkTableAdapter.ClearBeforeFill = true;
            // 
            // linkIdDataGridViewTextBoxColumn
            // 
            this.linkIdDataGridViewTextBoxColumn.DataPropertyName = "Link_Id";
            this.linkIdDataGridViewTextBoxColumn.HeaderText = "Link_Id";
            this.linkIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.linkIdDataGridViewTextBoxColumn.Name = "linkIdDataGridViewTextBoxColumn";
            this.linkIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Hardware_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Hardware_Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Hardware_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hardware_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Software_Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Software_Id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Software_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Software_Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // SoftwareAndHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LinkBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoftwareAndHardware";
            this.Text = "SoftwareAndHardware";
            this.Load += new System.EventHandler(this.SoftwareAndHardware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerLinkBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001975DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetManagerLinkBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource assetManagerLinkBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button LinkBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mssql2001975DataSet6 mssql2001975DataSet6;
        private System.Windows.Forms.BindingSource assetManagerLinkBindingSource1;
        private mssql2001975DataSet6TableAdapters.Asset_Manager_LinkTableAdapter asset_Manager_LinkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}