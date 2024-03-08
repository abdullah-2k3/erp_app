﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_registerHere_Click(object sender, EventArgs e)
        {
            frmSignup sForm = new frmSignup();
            sForm.ShowDialog();
            this.Hide();
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpass.Checked)
            {
                login_password.PasswordChar = '\0';
                login_password.Font = new Font(login_password.Font.FontFamily, 10, FontStyle.Regular);
            }
            else
            {
                login_password.PasswordChar = '*';
                login_password.Font = new Font(login_password.Font.FontFamily, 12, FontStyle.Bold);
            }
        }
    }
}
