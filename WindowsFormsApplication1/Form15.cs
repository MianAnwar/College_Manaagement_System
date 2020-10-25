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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form34 f34 = new Form34();
            f34.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form35 f35 = new Form35();
            f35.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form36 f36 = new Form36();
            f36.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form37 f37 = new Form37();
            f37.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form38 f38 = new Form38();
            f38.Show();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
