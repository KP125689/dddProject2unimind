using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Policy;

namespace dddProject2
{
    public partial class SpeaktoSomeone : Form
    {
        public SpeaktoSomeone()
        {
            InitializeComponent();
        }

        private void SPeakTitle_Click(object sender, EventArgs e)
        {

        }

        private void samaritanButton_Click(object sender, EventArgs e)
        {
            string samaritanurl = "https://www.samaritans.org/";
            Process.Start(new ProcessStartInfo(samaritanurl) { UseShellExecute = true });
        }

        private void HullSSButton_Click(object sender, EventArgs e)
        {
            string studenturl = "https://hulluniunion.com/places/student-services";
            Process.Start(new ProcessStartInfo(studenturl) { UseShellExecute = true });
        }

        private void uniwellbeingButton_Click(object sender, EventArgs e)
        {
            string studenturl = "https://www.uniwellbeing.com/";
            Process.Start(new ProcessStartInfo(studenturl) { UseShellExecute = true });
        }

        private void childlineButton_Click(object sender, EventArgs e)
        {
            string childlineurl = "https://www.childline.org.uk/";
            Process.Start(new ProcessStartInfo(childlineurl) { UseShellExecute = true });
        }

        

        private void HullSSButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
