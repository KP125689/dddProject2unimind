using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dddProject2
{
    public partial class Homepage2 : Form
    {
        public Homepage2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // log in button 
            LoginPage log = new LoginPage();
            log.Show();
            this.Hide();
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            // register button
            RegisterPage register = new RegisterPage(); 
            register.Show();
            this.Hide();
        }
    }
}
