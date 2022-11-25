﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Managment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
            private void Lgn_Btn_Click(object sender, EventArgs e)
            {
            //database connection
            SqlConnection connect;
            connect = new SqlConnection(Tools.ConCreds);// Connect to database using credentials
            String Password = Tools.GetHashed(PasswordTb.Text);
            String Username = UserNameTb.Text;
            SqlDataAdapter addcomm = new SqlDataAdapter();
            //connecting to database and
            String select = "SELECT * FROM User_Login  WHERE Username = @usernamE AND Password ='" + Password + "'";// searching for in the Username and password fields for
            SqlCommand command = new SqlCommand(select, connect);
            command.Parameters.AddWithValue("@usernamE", Username);
            connect.Open();//connection opened
            SqlDataReader passfind = command.ExecuteReader(); ;
            // row = connect.ExecuteReader(select);
                if (passfind.HasRows)
                {
                    MainMenu add = new MainMenu();
                    add.Show();
                    this.Hide();
                }
                else//failure to login
                {
                    if (Username.Trim().Equals(""))//conditions for failure shown to user
                    {
                        MessageBox.Show("Enter Your Username to Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Password.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter Your Password to Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("This Username Or Password Doesn't Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            command.Dispose();
            connect.Close();//database closed
           
            }
    }
}
