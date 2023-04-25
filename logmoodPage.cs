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
    public partial class logmoodPage : Form
    {
        public logmoodPage()
        {
            InitializeComponent();
        }
        string filepath = "C:\\Users\\patrw\\source\\repos\\dddProject2\\journal.txt";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void logmoodPage_Load(object sender, EventArgs e)
        { 

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var home = new HelloStudent();
            home.Show();
        }

        private void howbtn_Click(object sender, EventArgs e)
        {
            mediationandMindfullness mediationandMindfullness = new mediationandMindfullness();
            mediationandMindfullness.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Get the text entered in the text box
            string userInput = inputtextbox.Text;

            // Create a StreamWriter object to write to the text file
            using (StreamWriter writer = new StreamWriter(filepath, true))
            {
                // Append the user input to the text file on a new line
                writer.WriteLine(userInput);
            }

            // Clear the text box
            inputtextbox.Text = "";
        }

        private void inputtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
