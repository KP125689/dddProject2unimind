using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dddProject2
{
    public partial class ExtrasPage : Form
    {
        public ExtrasPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //daily journal, so home page
            logmoodPage log = new logmoodPage();
            log.Show();
            this.Hide();


        }

        private void getSocialButton_Click(object sender, EventArgs e)
        {
            var speaktome = new InsightsPage();
            speaktome.Show();
            this.Hide();
        }

        private void SpeakToSomeoneButton_Click(object sender, EventArgs e)
        {
            var speaktosomeone = new SpeaktoSomeone();
            speaktosomeone.Show();
            this.Hide();
        }

        private void MnMButton_Click(object sender, EventArgs e)
        {
            var mmp = new mediationandMindfullness();
            mmp.Show();
            this.Hide();

        }

        private void EmergencyContactButton_Click(object sender, EventArgs e)
        {
            //log out 
            Homepage2 home = new Homepage2();
            home.Show();
            this.Hide();
        }

        private void ExtrasPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //home page
            logmoodPage log = new logmoodPage();
            log.Show();
            this.Hide();
        }
    }
}
