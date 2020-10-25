using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; ////////

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ALL DRIVE DATA\University\3rd semester\OOP\project\WindowsFormsApplication1\WindowsFormsApplication1\DBMS.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;

        private void rectangleShape5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void s_Click(object sender, EventArgs e)
        {
            //savwe
          // textBox8.Text = dateTimePicker1.Text.ToString();
            if (MessageBox.Show("Are you Sure! You want to Save a new Record.", "Save Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string qur = "INSERT INTO Teacher (Name,CNIC,Qualification,Address,Nationality,Religion,Experience,Specialization,JoinDate,Email,PhoneNo,Gender) VALUES ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','" + dateTimePicker1.Text.ToString() + "','" + textBox12.Text + "','" + textBox14.Text + "','" + comboBox1.Text + "')";
                    string qur2 = "INSERT INTO TeacherAttendence (CNIC,T_Name) VALUES ('" + textBox3.Text + "','" + textBox1.Text + "')";
                    sda = new SqlDataAdapter(qur, con);
                    sda.SelectCommand.ExecuteNonQuery();

                    sda = new SqlDataAdapter(qur2, con);
                    sda.SelectCommand.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("New Record Added Successfully");
                }
                catch
                {
                    MessageBox.Show("Unsuccessful while saving new Record. Some filleds must be filled.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
