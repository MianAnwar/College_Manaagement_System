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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form25 f25 = new Form25();
            f25.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form27 f27 = new Form27();
            f27.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form28 f28 = new Form28();
            f28.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form44 f44 = new Form44();
            f44.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
