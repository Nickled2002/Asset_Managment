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
            //database connection
            SqlConnection connect;
            connect = new SqlConnection(Tools.ConCreds);// Connect to database using credentials
            connect.Open();//connection opened

            SqlCommand command;
            SqlDataAdapter addcomm = new SqlDataAdapter();
            String Val = "";//connecting to database and
            Val = "SELECT * FROM `User_Login`  WHERE `Username`=@Username AND `Password`=@pass";// searching for in the Username and password fields for
            command = new SqlCommand(Val, connect);//lines 30 31
            DataTable table = new DataTable();
            String Password = Tools.PasswordHashed(PasswordTb.Text);
            String Username = UserNameTb.Text;
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;//values
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
            addcomm.InsertCommand = command;
            addcomm.InsertCommand.ExecuteNonQuery();
            addcomm.Fill(table);
            if (table.Rows.Count > 0)
            {

            }
            else
            {
                if (UserNameTb.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (PasswordTb.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username Or Password Doesn't Exists", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            command.Dispose();
            connect.Close();//database closed
        }
    }
}
