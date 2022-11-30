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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //text fields converted to strings to add to the database
            string SystemName = NameTB.Text;
            string Model = ModelTB.Text;
            string Manufacturer = ManuTB.Text;
            string Type = TypeTB.Text;
            string IPAddress = IPTB.Text;
            string Date = DayTB.Text + "/" + MonthTB.Text + "/" + YearTB.Text;
            string Note = NoteTB.Text;
            //database connection
            SqlConnection connect;
            connect = new SqlConnection(Tools.ConCreds);

            //exeptions for missing fields
            if (String.IsNullOrEmpty(NameTB.Text))
            {
                MessageBox.Show("System Name is missing", "Add Asset", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (String.IsNullOrEmpty(ModelTB.Text))
                {
                    MessageBox.Show("Model is missing", "Add Asset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (String.IsNullOrEmpty(ManuTB.Text))
                    {
                        MessageBox.Show("Manufacturer name is missing", "Add Asset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(TypeTB.Text))
                        {
                            MessageBox.Show("Type is missing", "Add Asset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(IPTB.Text))
                            {
                                MessageBox.Show("IP adress is missing", "Add Asset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                if ((String.IsNullOrEmpty(DayTB.Text)) && (String.IsNullOrEmpty(MonthTB.Text)) && (String.IsNullOrEmpty(YearTB.Text)))
                                {//all mandatory fields completed 
                                    connect.Open();
                                    SqlCommand command;
                                    SqlDataAdapter addcomm = new SqlDataAdapter();
                                    String Addition = "";//inserting and connecting to database
                                    Addition = "Insert into Asset_Manager_Hardware (System_Name,Model,Manufacturer,Type,IP_Address,Purchase_Date,Note) values('" + SystemName + "','" + Model + "','" + Manufacturer + "','" + Type + "','" + IPAddress + "','null','" + Note + "')";
                                    command = new SqlCommand(Addition, connect);
                                    addcomm.InsertCommand = new SqlCommand(Addition, connect);
                                    addcomm.InsertCommand.ExecuteNonQuery();
                                    command.Dispose();
                                    connect.Close();
                                    var Main = new Form1();//main form loaded this form closed
                                    MessageBox.Show("Asset added sucessfully", "Add Asset", MessageBoxButtons.OK, MessageBoxIcon.Information);// show message of success
                                    Main.Show();
                                    this.Close();

                                }
                                if ((!String.IsNullOrEmpty(DayTB.Text)) || (!String.IsNullOrEmpty(MonthTB.Text)) || (!String.IsNullOrEmpty(YearTB.Text)))
                                {
                                    if (String.IsNullOrEmpty(DayTB.Text))
                                    {
                                        MessageBox.Show("Day is missing", "Add Asset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    if (String.IsNullOrEmpty(MonthTB.Text))
                                    {
                                        MessageBox.Show("Month is missing", "Add Asset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    if (String.IsNullOrEmpty(YearTB.Text))
                                    {
                                        MessageBox.Show("Year is missing", "Add Asset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    if ((!String.IsNullOrEmpty(DayTB.Text)) && (!String.IsNullOrEmpty(MonthTB.Text)) && (!String.IsNullOrEmpty(YearTB.Text)))
                                    {//all fields okay
                                        connect.Open();
                                        SqlCommand command;
                                        SqlDataAdapter addcomm = new SqlDataAdapter();
                                        String Addition = "";//connecting to database and inserting values
                                        Addition = "Insert into Asset_Manager_Hardware (System_Name,Model,Manufacturer,Type,IP_Address,Purchase_Date,Note) values('" + SystemName + "','" + Model + "','" + Manufacturer + "','" + Type + "','" + IPAddress + "','" + Date + "','" + Note + "')";
                                        command = new SqlCommand(Addition, connect);
                                        addcomm.InsertCommand = new SqlCommand(Addition, connect);
                                        addcomm.InsertCommand.ExecuteNonQuery();
                                        command.Dispose();
                                        connect.Close();//database closed
                                        var Main = new Form1();//main form loaded again and this form is closed
                                        MessageBox.Show("Asset added sucessfully", "Add Asset", MessageBoxButtons.OK, MessageBoxIcon.Information);// show message of success
                                        Main.Show();
                                        this.Close();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var Main = new Form1();//main form loaded this form closed
            Main.Show();
            this.Close();
        }
    }
}
