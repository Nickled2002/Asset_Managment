﻿using System;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void HardDbBtn_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            add.Show();
            this.Close();
        }

        private void SoftDbBtn_Click(object sender, EventArgs e)
        {
            SoftwareMain softwareMain = new SoftwareMain();
            softwareMain.Show();
            this.Close();
        }

        private void VulnSrchBtn_Click(object sender, EventArgs e)
        {

        }

        private void SnHBtn_Click(object sender, EventArgs e)
        {
            SoftwareAndHardware softwareAndHardware = new SoftwareAndHardware();
            softwareAndHardware.Show();
            this.Close();
        }
    }
}
