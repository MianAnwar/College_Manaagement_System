using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form47 : Form
    {
        public Form47()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ALL DRIVE DATA\University\3rd semester\OOP\project\WindowsFormsApplication1\WindowsFormsApplication1\DBMS.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;

        private void Form47_Load(object sender, EventArgs e)
        {
            // at load <start> time
            string sqe = "SELECT Class_Name,Lecture_1_Start,Lecture_1_End, Lecture_2_Start,Lecture_2_End, Lecture_3_Start,Lecture_3_End, Lecture_4_Start,Lecture_4_End, Lecture_5_Start,Lecture_5_End, Lecture_6_Start,Lecture_6_End, Lecture_7_Start,Lecture_7_End, Lecture_8_Start,Lecture_8_End, Lecture_9_Start,Lecture_9_End, Lecture_10_Start,Lecture_10_End FROM Timming";
            sda = new SqlDataAdapter(sqe, con);
            dt = new DataTable();

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this will showe the time table of lectures
            string sqe = "SELECT Class_Name,Lecture_1_Start,Lecture_1_End, Lecture_2_Start,Lecture_2_End, Lecture_3_Start,Lecture_3_End, Lecture_4_Start,Lecture_4_End, Lecture_5_Start,Lecture_5_End, Lecture_6_Start,Lecture_6_End, Lecture_7_Start,Lecture_7_End, Lecture_8_Start,Lecture_8_End, Lecture_9_Start,Lecture_9_End, Lecture_10_Start,Lecture_10_End FROM Timming where Class_Name = '" + textBox1.Text + "'";
            sda = new SqlDataAdapter(sqe, con);
            dt = new DataTable();

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
