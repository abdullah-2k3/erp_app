﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class frmAddCustomer : Form
    {
        private string ConnectionString = "Data Source=Customer.db;Version=3;";

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);

            con.Open();


            string name = tbName.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;
            string gender = comboBoxGender.SelectedItem.ToString();
            string city = tbCity.Text;


            string Query = "INSERT INTO CustomerProfTbl(Name, Gender, City, Contact, Email) VALUES ('"+name+"', '"+gender+ "', '"+city+ "', '"+phone+"', '" + email+ "')";

            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Customer has been added!");
        }
    }
}
