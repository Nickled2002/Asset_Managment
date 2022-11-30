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
    public partial class DeleteS : Form
    {
        public DeleteS()
        {
            InitializeComponent();
        }

        private void DeleteS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2001975DataSet3.Asset_Manager_Software' table. You can move, or remove it, as needed.
            this.asset_Manager_SoftwareTableAdapter.Fill(this.mssql2001975DataSet3.Asset_Manager_Software);

        }

        private void DltBtn_Click(object sender, EventArgs e)
        {
            if (SystemNameTb.Text == "")
            {
                MessageBox.Show("Operation System Name is missing", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string osName = SystemNameTb.Text;
                SqlConnection connect;
                connect = new SqlConnection(Tools.ConCreds);// Connect to database using credentials
                SqlDataAdapter addcomm = new SqlDataAdapter();
                //connecting to database and
                String select = "SELECT * FROM Asset_Manager  WHERE System_Name = @opersystemnamE";// searching for in the Username and password fields for
                SqlCommand command = new SqlCommand(select, connect);
                command.Parameters.AddWithValue("@opersystemnamE", osName);
                connect.Open();//connection opened
                SqlDataReader delfind = command.ExecuteReader();
                if (delfind.HasRows)
                {
                    DialogResult YesOrNo = MessageBox.Show("Are you sure you want to delete system: " + osName, "Found", MessageBoxButtons.YesNo);
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
            Form1 Main = new Form1();//main form loaded this form closed
            Main.Show();
            this.Close();
        }
    }
}
