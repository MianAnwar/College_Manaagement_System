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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            main m = new main();
            m.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already Here", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            Teacher th = new Teacher();
            th.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
            Form14 f14 = new Form14();
            f14.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            Form15 f15 = new Form15();
            f15.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Form19 f19 = new Form19();
            f19.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure! You want to exit.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        

    }
}
