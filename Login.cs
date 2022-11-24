using System;
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
            int i = 1;
            if (i == 1)
            {
                MainMenu add = new MainMenu();
                add.Show();
                this.Hide();
            }
            else
            {
                //database connection
                SqlConnection connect;
                connect = new SqlConnection(Tools.ConCreds);// Connect to database using credentials
                connect.Open();//connection opened

                SqlCommand command;
                SqlDataAdapter addcomm = new SqlDataAdapter();
                String select = "";//connecting to database and
                select = "SELECT * FROM `User_Login`  WHERE `Username`=@Username AND `Password`=@pass";// searching for in the Username and password fields for
                command = new SqlCommand(select, connect);//lines 30 31
                DataTable table = new DataTable();
                String Password = Tools.GetHashed(PasswordTb.Text);
                String Username = UserNameTb.Text;
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
                addcomm.InsertCommand = command;
                addcomm.InsertCommand.ExecuteNonQuery();
                addcomm.Fill(table);
                if (table.Rows.Count > 0)
                {
                    //success
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
}
