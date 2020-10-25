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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form47 f47 = new Form47();
            f47.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form48 f48 = new Form48();
            f48.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            main m = new main();
            m.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            Student st = new Student();
            st.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            Teacher th = new Teacher();
            th.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already Here", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure! You want to exit.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
