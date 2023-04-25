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
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace dddProject2
{
    public partial class logmoodPage : Form
    {
        public logmoodPage()
        {
            InitializeComponent();
        }
        string filename = "C:\\Users\\patrw\\source\\repos\\dddProject2\\userData.csv";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //log mood button
            HelloStudent hello = new HelloStudent();
            hello.Show();
            this.Hide();
            // meant to be hello student page that goes to log mood page but we did the files other way round by accident
        }


        private void logmoodPage_Load(object sender, EventArgs e)
        {

        }

        private void journalTextbox(object sender, EventArgs e)
        {
            // daily journal
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // submit journal
            string userInput = journalinputbox.Text;

            string[] lines = File.ReadAllLines(filename);


            foreach (string lines in line)
            {
                // Split the line by commas to get the individual values
                string[] values = lines.Split(',');
                userInput = values[4];
            }
            string line = string.Join(",", userInput);

            using (StreamWriter file = new StreamWriter(filename, true))
            {
                file.WriteLine(lines);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void journalinputbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
