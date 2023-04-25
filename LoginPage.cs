using Newtonsoft.Json.Linq;
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
        string filePath = "C:\\Users\\patrw\\source\\repos\\dddProject2\\userdata2.txt";
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
            // user enters text into box and store in CSV file
        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {
            // user enters password adn its stored in CSV
        }

        private void loginbutton2_Click(object sender, EventArgs e)
        {
            // user can log in, also lead to another page
            string username = usernametextbox.Text;
            string password = passwordbox.Text;

            try
            {
                // Read the user data from the text file
                
                string[] lines = File.ReadAllLines(filePath);

                // Check if the entered username and password match a record in the file
                bool found = false;
                foreach (string line in lines)
                {
                    string[] fields = line.Split(' ');
                    string txtUsername = fields[0];
                    string txtPassword = fields[1];

                    if (username == txtUsername && password == txtPassword)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    // The entered username and password match a record in the file
                    // Perform the desired action (e.g. show a success message or open a new window)
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    // The entered username and password do not match any record in the file
                    // Show an error message
                    MessageBox.Show("Invalid username or password!");
                }
            }
            catch (Exception ex)
            {
                // Show an error message
                MessageBox.Show("Login failed: " + ex.Message);
            }






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
