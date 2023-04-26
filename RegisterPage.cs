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

           
            
        }

        private void gobackbutton2_Click(object sender, EventArgs e)
        {
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            

        }
    }
}
