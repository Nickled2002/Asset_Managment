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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2001975DataSet.Asset_Manager' table. You can move, or remove it, as needed.
            this.asset_ManagerTableAdapter.Fill(this.mssql2001975DataSet.Asset_Manager);

        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            //once button add is clicked new form is loaded main form is hidden
            var add = new Add();
            add.Show();
            this.Hide();
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Dlt_Btn_Click(object sender, EventArgs e)
        {
        //implement same system as github add name of or id or anything that the thing you want to delete has to confirm.
        //check fields delete
        }

        private void This_Btn_Click(object sender, EventArgs e)
        {
        //fields get autocompleted with the information of this machine
        //possibility to add to database
        //possibility to go back
        }
    }
}
