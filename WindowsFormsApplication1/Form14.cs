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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form29 f29 = new Form29();
            f29.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form30 f30 = new Form30();
            f30.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form31 f31 = new Form31();
            f31.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form32 f32 = new Form32();
            f32.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form33 f33 = new Form33();
            f33.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
