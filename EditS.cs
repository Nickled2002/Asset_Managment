using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Managment
{
    public partial class EditS : Form
    {
        public EditS()
        {
            InitializeComponent();
        }

        private void EditS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2001975DataSet5.Asset_Manager_Software' table. You can move, or remove it, as needed.
            this.asset_Manager_SoftwareTableAdapter.Fill(this.mssql2001975DataSet5.Asset_Manager_Software);

        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            var Main = new Form1();//main form loaded this form closed
            Main.Show();
            this.Close();
        }
    }
}
