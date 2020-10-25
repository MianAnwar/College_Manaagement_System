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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ALL DRIVE DATA\University\3rd semester\OOP\project\WindowsFormsApplication1\WindowsFormsApplication1\DBMS.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox14.Text == "") // CNIC
            {
                if (textBox1.Text == "") // name
                {
                    MessageBox.Show("Atleast one field must be filled to update.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ///// to shoewe data in d_grrd
                    con.Open();
                    string sqe = "SELECT CNIC,Name,JoinDate,PhoneNo,Qualification,Experience,Gender,Email,Specialization,Address,Nationality,Religion From Teacher where Name = '" + textBox1.Text + "'";
                    sda = new SqlDataAdapter(sqe, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }///////
            }
            else
            {
                if (textBox1.Text == "") // name
                {
                    ///// to shoewe data in d_grrd
                    con.Open();
                    string sqe = "SELECT CNIC,Name,JoinDate,PhoneNo,Qualification,Experience,Gender,Email,Specialization,Address,Nationality,Religion From Teacher where CNIC = '" + textBox14.Text + "'";
                    sda = new SqlDataAdapter(sqe, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else
                {
                    ///// to shoewe data in d_grrd
                    con.Open();
                    string sqe = "SELECT CNIC,Name,JoinDate,PhoneNo,Qualification,Experience,Gender,Email,Specialization,Address,Nationality,Religion From Teacher where CNIC = '" + textBox14.Text + "' OR Name = '" + textBox1.Text + "'";
                    sda = new SqlDataAdapter(sqe, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
