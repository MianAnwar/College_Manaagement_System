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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form39 f39 = new Form39();
            f39.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form40 f40 = new Form40();
            f40.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form41 f41 = new Form41();
            f41.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form42 f42 = new Form42();
            f42.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form43 f43 = new Form43();
            f43.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
