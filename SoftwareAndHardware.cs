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
    public partial class SoftwareAndHardware : Form
    {
        public SoftwareAndHardware()
        {
            InitializeComponent();
        }

        private void SoftwareAndHardware_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2001975DataSet6.Asset_Manager_Link' table. You can move, or remove it, as needed.
            this.asset_Manager_LinkTableAdapter.Fill(this.mssql2001975DataSet6.Asset_Manager_Link);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
            this.Close();
        }

        private void LinkBtn_Click(object sender, EventArgs e)
        {
            Link link = new Link();
            link.Show();
            this.Close();
        }
    }
}
