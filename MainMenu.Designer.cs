namespace Asset_Managment
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HardDbBtn = new System.Windows.Forms.Button();
            this.SoftDbBtn = new System.Windows.Forms.Button();
            this.VulnSrchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Asset_Managment.Properties.Resources.LoginLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 102);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(259, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to the ScottishGlen Asset Manager";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.VulnSrchBtn);
            this.groupBox1.Controls.Add(this.SoftDbBtn);
            this.groupBox1.Controls.Add(this.HardDbBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 300);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "G";
            // 
            // HardDbBtn
            // 
            this.HardDbBtn.Location = new System.Drawing.Point(6, 21);
            this.HardDbBtn.Name = "HardDbBtn";
            this.HardDbBtn.Size = new System.Drawing.Size(163, 55);
            this.HardDbBtn.TabIndex = 0;
            this.HardDbBtn.Text = "Hardware Databse";
            this.HardDbBtn.UseVisualStyleBackColor = true;
            this.HardDbBtn.Click += new System.EventHandler(this.HardDbBtn_Click);
            // 
            // SoftDbBtn
            // 
            this.SoftDbBtn.Location = new System.Drawing.Point(6, 82);
            this.SoftDbBtn.Name = "SoftDbBtn";
            this.SoftDbBtn.Size = new System.Drawing.Size(163, 55);
            this.SoftDbBtn.TabIndex = 1;
            this.SoftDbBtn.Text = "Software Datebase";
            this.SoftDbBtn.UseVisualStyleBackColor = true;
            this.SoftDbBtn.Click += new System.EventHandler(this.SoftDbBtn_Click);
            // 
            // VulnSrchBtn
            // 
            this.VulnSrchBtn.Location = new System.Drawing.Point(6, 143);
            this.VulnSrchBtn.Name = "VulnSrchBtn";
            this.VulnSrchBtn.Size = new System.Drawing.Size(163, 55);
            this.VulnSrchBtn.TabIndex = 2;
            this.VulnSrchBtn.Text = "Vulnerability Search";
            this.VulnSrchBtn.UseVisualStyleBackColor = true;
            this.VulnSrchBtn.Click += new System.EventHandler(this.VulnSrchBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button VulnSrchBtn;
        private System.Windows.Forms.Button SoftDbBtn;
        private System.Windows.Forms.Button HardDbBtn;
    }
}