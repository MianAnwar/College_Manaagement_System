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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Student st = new Student();
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure! You want to exit.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Teacher th = new Teacher();
            th.Show();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form19 f19 = new Form19();
            f19.Show();
        }
        
        private void button15_Click_1(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form14 f14 = new Form14();
            f14.Show();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form15 f15 = new Form15();
            f15.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Student st = new Student();
            st.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Teacher th = new Teacher();
            th.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure! You want to exit.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure! You want to exit.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
