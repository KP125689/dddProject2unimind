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
            var log = new logmoodPage();
            log.Show();

            
        }

        private void getSocialButton_Click(object sender, EventArgs e)
        {
            var speaktome = new InsightsPage();
            speaktome.Show();
        }

        private void SpeakToSomeoneButton_Click(object sender, EventArgs e)
        {
            var speaktosomeone = new SpeaktoSomeone();
            speaktosomeone.Show();
        }

        private void MnMButton_Click(object sender, EventArgs e)
        {
            var mmp = new mediationandMindfullness();
            mmp.Show();
           
        }

        private void EmergencyContactButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ExtrasPage_Load(object sender, EventArgs e)
        {

        }
    }
}
