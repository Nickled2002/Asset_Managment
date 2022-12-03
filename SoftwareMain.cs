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
            // TODO: This line of code loads data into the 'mssql2001975DataSet.Asset_Manager_Software' table. You can move, or remove it, as needed.
            this.asset_Manager_SoftwareTableAdapter.Fill(this.mssql2001975DataSet.Asset_Manager_Software);


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ThisMachineS thisMachineS = new ThisMachineS();
            thisMachineS.Show();
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = MessageBox.Show("Are you sure you want to edit the table? The changes are permanent and cannot be automatically undone: ", "Edit Table", MessageBoxButtons.YesNo);
            if (YesOrNo == DialogResult.Yes)
            {
                EditS edits = new EditS();
                edits.Show();
                this.Close();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteS deleteS = new DeleteS();
            deleteS.Show();
            this.Close();
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
