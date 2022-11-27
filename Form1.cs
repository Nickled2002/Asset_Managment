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
            Add add = new Add();
            add.Show();
            this.Close();
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = MessageBox.Show("Are you sure you want to edit the table? The changes are permanent and cannot be automatically undone: ", "Edit Table", MessageBoxButtons.YesNo);
            if (YesOrNo == DialogResult.Yes)
            {
                Edit edit = new Edit();//main form loaded this form closed
                edit.Show();
                this.Close();
            }
            else if (YesOrNo == DialogResult.No)
            {
                
            }
        }

        private void Dlt_Btn_Click(object sender, EventArgs e)
        {
        Delete delete = new Delete();
        delete.Show();
        this.Close();
        }

        private void This_Btn_Click(object sender, EventArgs e)
        {
            ThisMachine TM = new ThisMachine();
            TM.Show();
            this.Close();
            //fields get autocompleted with the information of this machine
            //possibility to add to database
            //possibility to go back
        }
    }
}
