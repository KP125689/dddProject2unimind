﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dddProject2
{
    public partial class LoginPage : Form
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
            //the title 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // user enters text into box and store in txt file
        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {
            // user enters password adn its stored in txt
        }

        private void loginbutton2_Click(object sender, EventArgs e)
        {
            // user can log in, also lead to another page
            string username = usernametextbox.Text;
            string password = passwordbox.Text;


            logmoodPage log = new logmoodPage();
            log.Show();
            this.Hide();


        }
        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void gobackbutton_Click(object sender, EventArgs e)
        {
            Homepage2 homepage = new Homepage2();
            homepage.Show();
            this.Hide();
        }
    }
}
