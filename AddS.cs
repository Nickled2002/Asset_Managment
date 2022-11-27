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
    public partial class AddS : Form
    {
        public AddS()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            SoftwareMain softwareMain = new SoftwareMain();
            softwareMain.Show();
            this.Close();
        }
    }
}
