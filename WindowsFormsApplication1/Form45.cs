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
    public partial class Form45 : Form
    {
        public Form45()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ALL DRIVE DATA\University\3rd semester\OOP\project\WindowsFormsApplication1\WindowsFormsApplication1\DBMS.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox14.Text == "") // roll no
            {
                if (textBox1.Text == "") // name
                {
                    MessageBox.Show("Atleast one field must be filled to update.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sqe;
                    sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Studentother where Name = '" + textBox1.Text + "'";
                    if (textBox7.Text.ToString() == "9")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Student9 where Name = '" + textBox1.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "10")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Student10 where Name = '" + textBox1.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "11")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Student11 where Name = '" + textBox1.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "12")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Student12 where Name = '" + textBox1.Text + "'";
                    }

                    ///// to shoewe data in d_grrd
                    con.Open();

                    sda = new SqlDataAdapter(sqe, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
            else
            {
                if (textBox1.Text == "") // name
                {
                    string sqe;
                    sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Studentother where Roll_No = '" + textBox14.Text + "'";
                    if (textBox7.Text.ToString() == "9")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Student9 where Roll_No = '" + textBox14.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "10")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Student10 where Roll_No = '" + textBox14.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "11")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Student11 where Roll_No = '" + textBox14.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "12")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Student12 where Roll_No = '" + textBox14.Text + "'";
                    }
                    ///// to shoewe data in d_grrd
                    con.Open();
                    sda = new SqlDataAdapter(sqe, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else
                {
                    string sqe;
                    sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Studentother where Roll_No = '" + textBox14.Text + "' OR Name = '" + textBox1.Text + "'";

                    if (textBox7.Text.ToString() == "9")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Student9 where Roll_No = '" + textBox14.Text + "' OR Name = '" + textBox1.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "10")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Student10 where Roll_No = '" + textBox14.Text + "' OR Name = '" + textBox1.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "11")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Student11 where Roll_No = '" + textBox14.Text + "' OR Name = '" + textBox1.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "12")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Address,Phone From Student12 where Roll_No = '" + textBox14.Text + "' OR Name = '" + textBox1.Text + "'";
                    }

                    ///// to shoewe data in d_grrd
                    con.Open();
                    sda = new SqlDataAdapter(sqe, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure! You want to Delete.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Must specify the ROll NO.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("PERMANENTLY DELETING if exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                  //  textBox3.Text ==> class
                    string sqe;
                    sqe = "DELETE FROM Studentother where Roll_No = '" + textBox2.Text + "'";
                    if (textBox3.Text.ToString() == "9")
                    {
                        sqe = "DELETE FROM Student9 where Roll_No = '" + textBox2.Text + "'";
                    }
                    if (textBox3.Text.ToString() == "10")
                    {
                        sqe = "DELETE FROM Student10 where Roll_No = '" + textBox2.Text + "'";
                    }
                    if (textBox3.Text.ToString() == "11")
                    {
                        sqe = "DELETE FROM Student11 where Roll_No = '" + textBox2.Text + "'";
                    }
                    if (textBox3.Text.ToString() == "12")
                    {
                        sqe = "DELETE FROM Student12 where Roll_No = '" + textBox2.Text + "'";
                    }

                    // delete
                    con.Open();
                    sda = new SqlDataAdapter(sqe, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("DELETED successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form45_Load(object sender, EventArgs e)
        {

        }
    }
}
