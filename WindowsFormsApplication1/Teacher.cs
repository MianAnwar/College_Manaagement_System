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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            main m = new main();
            m.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already Here", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            Student st = new Student();
            st.Show();
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
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();
            f18.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();
            f18.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
        }
    }
}
