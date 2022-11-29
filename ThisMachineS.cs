﻿using System;
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
    public partial class ThisMachineS : Form
    {
        public ThisMachineS()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            SoftwareMain softwareMain = new SoftwareMain(); 
            softwareMain.Show();
            this.Close();
            OSNameTB.Text = Tools.OSNameDeets;
            ManuTB.Text = Tools.OSManuDeets;
            VersionTB.Text = Tools.OSVersionDeets;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //text fields converted to strings to add to the database
            string OSName = OSNameTB.Text;
            string Version = VersionTB.Text;
            string Manufacturer = ManuTB.Text;
            //database connection
            SqlConnection connect;
            connect = new SqlConnection(Tools.ConCreds);
            connect.Open();
            SqlCommand command;
            SqlDataAdapter addcomm = new SqlDataAdapter();
            String Addition = "";//connecting to database and inserting values
            Addition = "Insert into Asset_Manager_Software (Operating_System_Name,Version,Manufacturer) values('" + OSName + "','" + Version + "','" + Manufacturer + "')";
            command = new SqlCommand(Addition, connect);
            addcomm.InsertCommand = new SqlCommand(Addition, connect);
            addcomm.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            connect.Close();//database closed
            SoftwareMain SMain = new SoftwareMain();//main form loaded again and this form is closed
            MessageBox.Show("Asset added sucessfully", "Add Asset", MessageBoxButtons.OK, MessageBoxIcon.Information);// show message of success
            SMain.Show();
            this.Close();
        }
    }
}
