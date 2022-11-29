namespace Asset_Managment
{
    partial class ThisMachineS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThisMachineS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ManuTB = new System.Windows.Forms.TextBox();
            this.OSNameTB = new System.Windows.Forms.TextBox();
            this.VersionTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.label2.Text = "ScottishGlen Software Assets";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(282, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(293, 29);
            this.label11.TabIndex = 48;
            this.label11.Text = "This machines details are:";
            // 
            // ManuTB
            // 
            this.ManuTB.Location = new System.Drawing.Point(287, 210);
            this.ManuTB.Multiline = true;
            this.ManuTB.Name = "ManuTB";
            this.ManuTB.ReadOnly = true;
            this.ManuTB.Size = new System.Drawing.Size(336, 30);
            this.ManuTB.TabIndex = 47;
            // 
            // OSNameTB
            // 
            this.OSNameTB.Location = new System.Drawing.Point(287, 141);
            this.OSNameTB.Multiline = true;
            this.OSNameTB.Name = "OSNameTB";
            this.OSNameTB.ReadOnly = true;
            this.OSNameTB.Size = new System.Drawing.Size(336, 30);
            this.OSNameTB.TabIndex = 46;
            // 
            // VersionTB
            // 
            this.VersionTB.Location = new System.Drawing.Point(287, 173);
            this.VersionTB.Multiline = true;
            this.VersionTB.Name = "VersionTB";
            this.VersionTB.ReadOnly = true;
            this.VersionTB.Size = new System.Drawing.Size(336, 30);
            this.VersionTB.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(123, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "Manufacturer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(180, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(4, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Operating System Name:";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(660, 397);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(128, 41);
            this.AddBtn.TabIndex = 50;
            this.AddBtn.Text = "Add to database";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 397);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(128, 41);
            this.BackBtn.TabIndex = 49;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ThisMachineS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ManuTB);
            this.Controls.Add(this.OSNameTB);
            this.Controls.Add(this.VersionTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThisMachineS";
            this.Text = "Add this machine";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ManuTB;
        private System.Windows.Forms.TextBox OSNameTB;
        private System.Windows.Forms.TextBox VersionTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}