using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; ///jkdhgsdlkf

namespace WindowsFormsApplication1
{
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ALL DRIVE DATA\University\3rd semester\OOP\project\WindowsFormsApplication1\WindowsFormsApplication1\DBMS.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlDataAdapter sda;
   //     DataTable dt;
        DataSet ds;
        SqlCommandBuilder scb;

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Text.ToString();

            string s = "Day_1";
            if (textBox2.Text == "1/1/2020")
            {
                s = "Day_1";
            }
            if (textBox2.Text == "1/2/2020")
            {
                s = "Day_2"; 
            }
            if (textBox2.Text == "1/3/2020")
            {
                s = "Day_3";
            }
            if (textBox2.Text == "1/4/2020")
            {
                s = "Day_4";
            }
            if (textBox2.Text == "1/5/2020")
            {
                s = "Day_5";
            }
            if (textBox2.Text == "1/6/2020")
            {
                s = "Day_6";
            }
            if (textBox2.Text == "1/7/2020")
            {
                s = "Day_7";
            }
            if (textBox2.Text == "1/8/2020")
            {
                s = "Day_8";
            }
            if (textBox2.Text == "1/9/2020")
            {
                s = "Day_9";
            }
            if (textBox2.Text == "1/10/2020")
            {
                s = "Day_10";
            }
            if (textBox2.Text == "1/11/2020")
            {
                s = "Day_11";
            }
            if (textBox2.Text == "1/12/2020")
            {
                s = "Day_12";
            }
            if (textBox2.Text == "1/13/2020")
            {
                s = "Day_13";
            }
            if (textBox2.Text == "1/14/2020")
            {
                s = "Day_14";
            }
            if (textBox2.Text == "1/15/2020")
            {
                s = "Day_15";
            }
            if (textBox2.Text == "1/16/2020")
            {
                s = "Day_16";
            }
            if (textBox2.Text == "1/17/2020")
            {
                s = "Day_17";
            }
            if (textBox2.Text == "1/18/2020")
            {
                s = "Day_18";
            }
            if (textBox2.Text == "1/19/2020")
            {
                s = "Day_19";
            }
            if (textBox2.Text == "1/20/2020")
            {
                s = "Day_20";
            }
            if (textBox2.Text == "1/21/2020")
            {
                s = "Day_21";
            }
            if (textBox2.Text == "1/22/2020")
            {
                s = "Day_22";
            }
            if (textBox2.Text == "1/23/2020")
            {
                s = "Day_23";
            }
            if (textBox2.Text == "1/24/2020")
            {
                s = "Day_24";
            }
            if (textBox2.Text == "1/25/2020")
            {
                s = "Day_25";
            }
            if (textBox2.Text == "1/26/2020")
            {
                s = "Day_26";
            }
            if (textBox2.Text == "1/27/2020")
            {
                s = "Day_27";
            }
            if (textBox2.Text == "1/28/2020")
            {
                s = "Day_28";
            }
            if (textBox2.Text == "1/29/2020")
            {
                s = "Day_29";
            }
            if (textBox2.Text == "1/30/2020")
            {
                s = "Day_30";
            }
            if (textBox2.Text == "1/31/2020")
            {
                s = "Day_31";
            }
            //display
            ///// to shoewe data in d_grrd
            con.Open();
            if (textBox1.Text == "")
            {
                ///// to shoewe data in d_grrd
                string sqe = "SELECT Roll_No,St_Name,Class,"+s+" From Attendence12";
                sda = new SqlDataAdapter(sqe, con);
                ds = new DataSet();

                sda.Fill(ds, "Attendence12");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                ///// to shoewe data in d_grrd
                string sqe = "SELECT Roll_No,St_Name,Class," + s + " From Attendence12 where Batch = '" + textBox1.Text + "'";
                sda = new SqlDataAdapter(sqe, con);
                ds = new DataSet();

                sda.Fill(ds, "Attendence12");
                dataGridView1.DataSource = ds.Tables[0];
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // submit .............. do it correctly
            ///// to shoewe data in d_grrd
            con.Open();
            /////////////
            scb = new SqlCommandBuilder(sda);
            sda.Update(ds, "Attendence12");
            MessageBox.Show("Attendence Submitted Right Now", "Submitted", MessageBoxButtons.OK);
            /////////////
            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Text;

            // refresh
            ///// to shoewe data in d_grrd
            con.Open();
            string sqe = "SELECT Roll_No,St_Name,Class From Attendence12";
            sda = new SqlDataAdapter(sqe, con);
            ds = new DataSet();

            sda.Fill(ds, "Attendence12");
            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }

        private void Form24_Load(object sender, EventArgs e)
        {
            // refresh
            ///// to shoewe data in d_grrd
            con.Open();
            string sqe = "SELECT Roll_No,St_Name,Class From Attendence12";
            sda = new SqlDataAdapter(sqe, con);
            ds = new DataSet();

            sda.Fill(ds, "Attendence12");
            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }
    }
}
