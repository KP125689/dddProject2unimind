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
    public partial class mediationandMindfullness : Form
    {
        public mediationandMindfullness()
        {
            InitializeComponent();
        }

        private void mediationandMindfullness_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExtrasPage extrasPage = new ExtrasPage();
            extrasPage.Show();
            this.Hide();
        }
    }
}
