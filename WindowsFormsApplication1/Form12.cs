using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form21 f21 = new Form21();
            f21.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form22 f22 = new Form22();
            f22.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form23 f23 = new Form23();
            f23.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form24 f24 = new Form24();
            f24.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form51 f51 = new Form51();
            f51.Show();
        }
    }
}
