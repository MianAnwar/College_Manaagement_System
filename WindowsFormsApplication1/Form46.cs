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
    public partial class Form46 : Form
    {
        public Form46()
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
                    MessageBox.Show("Atleast one field must be filled.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ///// to shoewe data in d_grrd
                    con.Open();
                    string sqe = "SELECT Name,CNIC,Experience,Address,PhoneNo,Email From Teacher where Name = '" + textBox1.Text + "'";
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
                    ///// to shoewe data in d_grrd
                    con.Open();
                    string sqe = "SELECT Name,CNIC,Experience,Address,PhoneNo,Email From Teacher where CNIC = '" + textBox14.Text + "'";
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
                    string sqe = "SELECT Name,CNIC,Experience,Address,PhoneNo,Email From Teacher where CNIC = '" + textBox14.Text + "' OR Name = '" + textBox1.Text + "'";
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure! You want to Delete.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Must specify the CNIC NO.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textBox2.Text != "")
                    {
                        // delete
                        con.Open();
                        string qur = "DELETE FROM Teacher where CNIC = '" + textBox2.Text + "'";
                        sda = new SqlDataAdapter(qur, con);
                        sda.SelectCommand.ExecuteNonQuery();

                        string qur2 = "DELETE FROM TeacherAttendence where CNIC = '" + textBox2.Text + "'";
                        sda = new SqlDataAdapter(qur2, con);
                        sda.SelectCommand.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("DELETED successfully 'if it exist'", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Must Specify the Filled", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }
    }
}
