using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Managment
{
    public partial class Link : Form
    {
        public Link()
        {
            InitializeComponent();
        }

        private void Link_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2001975DataSet8.Asset_Manager_Software' table. You can move, or remove it, as needed.
            this.asset_Manager_SoftwareTableAdapter.Fill(this.mssql2001975DataSet8.Asset_Manager_Software);
            // TODO: This line of code loads data into the 'mssql2001975DataSet7.Asset_Manager_Hardware' table. You can move, or remove it, as needed.
            this.asset_Manager_HardwareTableAdapter.Fill(this.mssql2001975DataSet7.Asset_Manager_Hardware);

        }

        private void LinkBtn_Click(object sender, EventArgs e)
        {
            int HardIndex = dataGridView1.SelectedCells[0].RowIndex;
            String Hardware_Id = dataGridView1.Rows[HardIndex].Cells[0].Value.ToString();
            String Hardware_Name = dataGridView1.Rows[HardIndex].Cells[1].Value.ToString();
            int SoftIndex = dataGridView2.SelectedCells[0].RowIndex;
            String Software_Id = dataGridView2.Rows[SoftIndex].Cells[0].Value.ToString();
            String Software_Name = dataGridView2.Rows[SoftIndex].Cells[1].Value.ToString();
            DialogResult YesOrNo = MessageBox.Show("Are you sure you want to link system " + Hardware_Id+": "+Hardware_Name+" with the operating system " + Software_Id + ": " + Software_Name, "Link", MessageBoxButtons.YesNo);
            if (YesOrNo == DialogResult.Yes)
            {
                SqlConnection connect;
                connect = new SqlConnection(Tools.ConCreds);
                connect.Open();
                String Addition = "Insert into Asset_Manager_Link (Hardware_Id,Hardware_Name,Software_Id,Software_Name) values(@HardwareId,@HardwareName,@SoftwareId,@SoftwareName)";
                SqlCommand command = new SqlCommand(Addition, connect);
                command.Parameters.AddWithValue("@HardwareId", Hardware_Id);
                command.Parameters.AddWithValue("@HardwareName", Hardware_Name);
                command.Parameters.AddWithValue("@SoftwareId", Software_Id);
                command.Parameters.AddWithValue("@SoftwareName", Software_Name);
                SqlDataAdapter addcomm = new SqlDataAdapter();
                addcomm.InsertCommand = command;
                addcomm.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                connect.Close();
                SoftwareAndHardware Main = new SoftwareAndHardware();
                MessageBox.Show("Assets succesfully linked", "Link Assets", MessageBoxButtons.OK, MessageBoxIcon.Information);// show message of success
                Main.Show();
                this.Close();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            SoftwareAndHardware softwareAndHardware = new SoftwareAndHardware();
            softwareAndHardware.Show();
            this.Close();
        }
    }
}
