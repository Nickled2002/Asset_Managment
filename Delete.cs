using System;
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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void DltBtn_Click(object sender, EventArgs e)
        {
            if (SystemNameTb.Text == "")
            {
                MessageBox.Show("System Name is missing", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sName = SystemNameTb.Text;
                SqlConnection connect;
                connect = new SqlConnection(Tools.ConCreds);// Connect to database using credentials
                SqlDataAdapter addcomm = new SqlDataAdapter();
                //connecting to database and
                String select = "SELECT * FROM Asset_Manager  WHERE System_Name = @systemnamE";// searching for in the Username and password fields for
                SqlCommand command = new SqlCommand(select, connect);
                command.Parameters.AddWithValue("@systemnamE", sName);
                connect.Open();//connection opened
                SqlDataReader delfind = command.ExecuteReader();
                if (delfind.HasRows)
                {
                    DialogResult YesOrNo = MessageBox.Show("Are you sure you want to delete system: " + sName, "Found", MessageBoxButtons.YesNo);
                    if (YesOrNo == DialogResult.Yes)
                    {
                        //do something to be implemented
                    }
                    else if (YesOrNo == DialogResult.No)
                    {
                        var Main = new Form1();//main form loaded this form closed
                        Main.Show();
                        this.Close();
                    }
                }
                else//failure to login
                {
                    MessageBox.Show("System Name doesnt exist", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }   

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var Main = new Form1();//main form loaded this form closed
            Main.Show();
            this.Close();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2001975DataSet2.Asset_Manager' table. You can move, or remove it, as needed.
            this.asset_ManagerTableAdapter.Fill(this.mssql2001975DataSet2.Asset_Manager);

        }
    }
}
