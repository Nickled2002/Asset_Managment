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
    public partial class SoftwareMain : Form
    {
        public SoftwareMain()
        {
            InitializeComponent();
        }

        private void SoftwareMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2001975DataSet1.Asset_Manager_Software' table. You can move, or remove it, as needed.
            this.asset_Manager_SoftwareTableAdapter.Fill(this.mssql2001975DataSet1.Asset_Manager_Software);

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddS adds = new AddS();
            adds.Show();
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void TMSBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
