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
            if (IdTb.Text == "")
            {
                MessageBox.Show("Hardware Id is missing", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sId = IdTb.Text;
                SqlConnection connect;
                connect = new SqlConnection(Tools.ConCreds);// Connect to database using credentials
                SqlDataAdapter addcomm = new SqlDataAdapter();
                //connecting to database and
                String select = "SELECT * FROM Asset_Manager_Hardware  WHERE Hardware_Id = @systemId";// searching for in the Username and password fields for
                SqlCommand command = new SqlCommand(select, connect);
                command.Parameters.AddWithValue("@systemId", sId);
                connect.Open();//connection opened
                SqlDataReader delfind = command.ExecuteReader();
                if (delfind.HasRows)
                {
                    DialogResult YesOrNo = MessageBox.Show("Are you sure you want to delete system: " + sId, "Found", MessageBoxButtons.YesNo);
                    if (YesOrNo == DialogResult.Yes)
                    {
                        connect.Close();
                        //do something to be implemented
                        SqlConnection connect1;
                        connect1 = new SqlConnection(Tools.ConCreds);
                        String Delsel = "DELETE FROM Asset_Manager_Hardware WHERE Hardware_Id = @systemId ";
                        SqlCommand commandDlt = new SqlCommand(Delsel, connect1);
                        commandDlt.Parameters.AddWithValue("@systemId", sId);
                        connect1.Open();//connection opened
                        commandDlt.ExecuteNonQuery();
                        connect1.Close();
                        var Main = new Form1();//main form loaded this form closed
                        Main.Show();
                        this.Close();

                    }
                    else if (YesOrNo == DialogResult.No)
                    {
                        connect.Close();
                        var Main = new Form1();//main form loaded this form closed
                        Main.Show();
                        this.Close();
                    }
                }
                else//failure to login
                {
                    connect.Close();
                    MessageBox.Show("Hardware Id doesnt exist", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }   

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();//main form loaded this form closed
            Main.Show();
            this.Close();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2001975DataSet2.Asset_Manager_Hardware' table. You can move, or remove it, as needed.
            this.asset_Manager_HardwareTableAdapter.Fill(this.mssql2001975DataSet2.Asset_Manager_Hardware);

        }
    }
}
