using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; ////////
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ALL DRIVE DATA\University\3rd semester\OOP\project\WindowsFormsApplication1\WindowsFormsApplication1\DBMS.mdf;Integrated Security=True;Connect Timeout=30");
         
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure! You want to Save a new Student Record.", "Save Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                textBox6.Text = dateTimePicker1.Text.ToString();
                //try
                //{
                    con.Open();
                    string qur;
                    string qur2;
                    qur2 = "INSERT INTO AttendenceE (St_Name,Batch,Class) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')";
                    qur = "INSERT INTO Studentother (Name,Father_Name,DOB,CNIC,Gender,Nationality,Address,Religion,Class,Phone,Batch) VALUES ('" + textBox2.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','" + textBox5.Text + "','" + textBox14.Text + "','" + textBox3.Text + "')";

                    if (textBox5.Text.ToString() == "9")
                    {
                        qur = "INSERT INTO Student9 (Name,Father_Name,DOB,CNIC,Gender,Nationality,Address,Religion,Class,Phone,Batch) VALUES ('" + textBox2.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','" + textBox5.Text + "','" + textBox14.Text + "','" + textBox3.Text + "')";
                        qur2 = "INSERT INTO Attendence9 (St_Name,Batch,Class) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')";
                    }
                    if (textBox5.Text.ToString() == "10")
                    {
                        qur = "INSERT INTO Student10 (Name,Father_Name,DOB,CNIC,Gender,Nationality,Address,Religion,Class,Phone,Batch) VALUES ('" + textBox2.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','" + textBox5.Text + "','" + textBox14.Text + "','" + textBox3.Text + "')";
                        qur2 = "INSERT INTO Attendence10 (St_Name,Batch,Class) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')";
                    }
                    if (textBox5.Text.ToString() == "11")
                    {
                        qur = "INSERT INTO Student11 (Name,Father_Name,DOB,CNIC,Gender,Nationality,Address,Religion,Class,Phone,Batch) VALUES ('"+ textBox2.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','" + textBox5.Text + "','" + textBox14.Text + "','" + textBox3.Text + "')";
                        qur2 = "INSERT INTO Attendence11 (St_Name,Batch,Class) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')";
                    }
                    if (textBox5.Text.ToString() == "12")
                    {
                        qur = "INSERT INTO Student12 (Name,Father_Name,DOB,CNIC,Gender,Nationality,Address,Religion,Class,Phone,Batch) VALUES ('" + textBox2.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','" + textBox5.Text + "','" + textBox14.Text + "','" + textBox3.Text + "')";
                        qur2 = "INSERT INTO Attendence12 (St_Name,Batch,Class) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')";
                    }
                    
                    sda = new SqlDataAdapter(qur, con);
                    sda.SelectCommand.ExecuteNonQuery();

                    sda = new SqlDataAdapter(qur2, con);
                    sda.SelectCommand.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("New Record Added Successfully");
               // }
               // catch(Exception ex)
               //{
               //    MessageBox.Show("Error\n" + ex.ToString() + "\n", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
               //    this.Close();
               // }
            }
            
            
        }

        

       
    }
}
