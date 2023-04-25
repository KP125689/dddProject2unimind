using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dddProject2
{
    public partial class LoginPage : Form
    {
        string filePath = "C:\\Users\\patrw\\source\\repos\\dddProject2\\userData.csv";
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

            // Read all lines from the CSV file
            string[] lines = File.ReadAllLines(filePath);

            // Loop through each line in the file
            foreach (string line in lines)
            {
                // Split the line by commas to get the individual values
                string[] values = line.Split(',');

                // Check if the username and password match the values in this row
                if (values[0] == username && values[1] == password)
                {
                    MessageBox.Show("log in successfull");
                    HelloStudent hello2 = new HelloStudent();
                    hello2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid details please try again");
                }
            }
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
