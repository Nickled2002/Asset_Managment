using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Managment
{
    public partial class ThisMachine : Form
    {
        public ThisMachine()
        {
            InitializeComponent();
            string hostname = Dns.GetHostName(); // Retrive the Name of HOST
            Console.WriteLine(hostname);
            string IPAddy = Dns.GetHostByName(hostname).AddressList[0].ToString();
            NameTB.Text = Tools.NameDeets;
            ManuTB.Text = Tools.ManuDeets;
            ModelTB.Text = Tools.ModelDeets;
            TypeTB.Text = Tools.TypeDeets;
            IPTB.Text = IPAddy;
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
                    Addition = "Insert into Asset_Manager (System_Name,Model,Manufacturer,Type,IP_Address,Purchase_Date,Note) values('" + SystemName + "','" + Model + "','" + Manufacturer + "','" + Type + "','" + IPAddress + "','" + Date + "','" + Note + "')";
                    command = new SqlCommand(Addition, connect);
                    addcomm.InsertCommand = new SqlCommand(Addition, connect);
                    addcomm.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    connect.Close();//database closed
                    Form1 Main = new Form1();//main form loaded again and this form is closed
                    MessageBox.Show("Asset added sucessfully", "Add Asset", MessageBoxButtons.OK, MessageBoxIcon.Information);// show message of success
                    Main.Show();
                    this.Close();
                }
                else
                {
                    if ((String.IsNullOrEmpty(DayTB.Text)) && (String.IsNullOrEmpty(MonthTB.Text)) && (String.IsNullOrEmpty(YearTB.Text)))
                    {//all mandatory fields completed 
                        connect.Open();
                        SqlCommand command;
                        SqlDataAdapter addcomm = new SqlDataAdapter();
                        String Addition = "";//inserting and connecting to database
                        Addition = "Insert into Asset_Manager (System_Name,Model,Manufacturer,Type,IP_Address,Purchase_Date,Note) values('" + SystemName + "','" + Model + "','" + Manufacturer + "','" + Type + "','" + IPAddress + "','null','" + Note + "')";
                        command = new SqlCommand(Addition, connect);
                        addcomm.InsertCommand = new SqlCommand(Addition, connect);
                        addcomm.InsertCommand.ExecuteNonQuery();
                        command.Dispose();
                        connect.Close();
                        Form1 Main = new Form1();//main form loaded this form closed
                        MessageBox.Show("Asset added sucessfully", "Add Asset", MessageBoxButtons.OK, MessageBoxIcon.Information);// show message of success
                        Main.Show();
                        this.Close();

                    }
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();//main form loaded this form closes
            Main.Show();
            this.Close();
        }
    }
}
