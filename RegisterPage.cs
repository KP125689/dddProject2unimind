﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace dddProject2
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confpass_Click(object sender, EventArgs e)
        {

        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void FNbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void completeRegister_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = Passwordbox.Text;
            string confirmPassword = ConfirmPasswordBox.Text;
            string firstName = FNbox.Text;
            string lastName = LNbox.Text;

            if (password == confirmPassword)
            {
                // The passwords match, add the user to the CSV file

                // Combine the input values into a comma-separated string
                string line = string.Join(",", username, firstName, lastName, password);

                // Append the line to the CSV file
                using (StreamWriter file = new StreamWriter("userData.csv", true))
                {
                    file.WriteLine(line);
                }

                MessageBox.Show("registration successfull");
                
            }
            else
            {
                MessageBox.Show("registration invalid please try again");
            }
        }

        private void gobackbutton2_Click(object sender, EventArgs e)
        {

        }
    }
}
