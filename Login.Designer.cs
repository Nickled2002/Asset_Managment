namespace Asset_Managment
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.Lgn_Btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassC = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(7, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // UserNameTb
            // 
            this.UserNameTb.Location = new System.Drawing.Point(160, 164);
            this.UserNameTb.Multiline = true;
            this.UserNameTb.Name = "UserNameTb";
            this.UserNameTb.Size = new System.Drawing.Size(204, 31);
            this.UserNameTb.TabIndex = 3;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(160, 201);
            this.PasswordTb.Multiline = true;
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(204, 31);
            this.PasswordTb.TabIndex = 4;
            // 
            // Lgn_Btn
            // 
            this.Lgn_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Lgn_Btn.Location = new System.Drawing.Point(7, 269);
            this.Lgn_Btn.Name = "Lgn_Btn";
            this.Lgn_Btn.Size = new System.Drawing.Size(357, 44);
            this.Lgn_Btn.TabIndex = 5;
            this.Lgn_Btn.Text = "Login";
            this.Lgn_Btn.UseVisualStyleBackColor = true;
            this.Lgn_Btn.Click += new System.EventHandler(this.Lgn_Btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Asset_Managment.Properties.Resources.LoginLogo;
            this.pictureBox2.Location = new System.Drawing.Point(32, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(325, 135);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(211, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Show Password";
            // 
            // PassC
            // 
            this.PassC.AutoSize = true;
            this.PassC.Location = new System.Drawing.Point(346, 246);
            this.PassC.Name = "PassC";
            this.PassC.Size = new System.Drawing.Size(18, 17);
            this.PassC.TabIndex = 8;
            this.PassC.UseVisualStyleBackColor = true;
            this.PassC.CheckedChanged += new System.EventHandler(this.PassC_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 323);
            this.Controls.Add(this.PassC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Lgn_Btn);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UserNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameTb;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Button Lgn_Btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox PassC;
    }
}