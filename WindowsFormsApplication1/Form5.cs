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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ALL DRIVE DATA\University\3rd semester\OOP\project\WindowsFormsApplication1\WindowsFormsApplication1\DBMS.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

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

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure! You want to Update.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (textBox6.Text != "")
                {
                    if (textBox2.Text == "") // name
                    {
                        if (textBox3.Text == "") // eexperience
                        {
                            if (textBox4.Text == "") // phone
                            {
                                if (textBox5.Text == "") // address
                                {
                                    MessageBox.Show("Atleast one field must be filled to update.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    // update address right nowe
                                    con.Open();
                                    string qur = "UPDATE Teacher SET Address = '" + textBox5.Text + "' where CNIC = '" + textBox6.Text + "'";
                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("Address 'UPDATED' successfully");
                                }
                            }
                            else
                            {
                                // update phone nowe check others situation
                                if (textBox5.Text == "") // address
                                {
                                    // update phone right nowe
                                    con.Open();
                                    string qur = "UPDATE Teacher SET PhoneNo = '" + textBox4.Text + "' where CNIC = '" + textBox6.Text + "'";
                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("Phone No. 'UPDATED' successfully");
                                }
                                else
                                {
                                    // update phone + address right nowe
                                    con.Open();
                                    string qur = "UPDATE Teacher SET PhoneNo = '" + textBox4.Text + "' , Address = '" + textBox5.Text + "' where CNIC = '" + textBox6.Text + "'";
                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("Phone No. and Address 'UPDATED' successfully");
                                }
                            }
                        }
                        else
                        {
                            //update Experience now check other's situation
                            if (textBox4.Text == "") // phone
                            {
                                if (textBox5.Text == "") // address
                                {
                                    // updaet class right now
                                    con.Open();
                                    string qur = "UPDATE Teacher SET Experience = '" + textBox3.Text + "' where CNIC = '" + textBox6.Text + "'";

                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    con.Close();
                                    MessageBox.Show("Experience 'UPDATED' successfully");
                                }
                                else
                                {
                                    // update Experience + address right nowe
                                    con.Open();
                                    string qur = "UPDATE Teacher SET Experience = '" + textBox3.Text + "' , Address = '" + textBox5.Text + "' where CNIC = '" + textBox6.Text + "'";

                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    con.Close();
                                    MessageBox.Show("Experience and Address 'UPDATED' successfully");
                                }
                            }
                            else
                            {
                                // update class + phone now check for address
                                if (textBox5.Text == "") // address
                                {
                                    // updaet class + phone right now
                                    con.Open();
                                    string qur = "UPDATE Teacher SET Experience = '" + textBox3.Text + "', PhoneNo = '" + textBox4.Text + "' where CNIC = '" + textBox6.Text + "'";

                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    con.Close();
                                    MessageBox.Show("Experience and Phone No. 'UPDATED' successfully");
                                }
                                else
                                {
                                    // updaet class + phone + address right now 
                                    con.Open();
                                    string qur = "UPDATE Teacher SET Experience = '" + textBox3.Text + "' , Address = '" + textBox5.Text + "' , PhoneNo = '" + textBox4.Text + "' where CNIC = '" + textBox6.Text + "'";

                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    con.Close();
                                    MessageBox.Show("Experience, Phone No. and Address 'UPDATED' successfully");
                                }
                            }
                        }
                    }
                    else
                    {
                        // name are to be update now check other's situation
                        if (textBox3.Text == "") // Experience
                        {
                            if (textBox4.Text == "") // phone
                            {
                                if (textBox5.Text == "") // address
                                {
                                    // update name right nowe
                                    con.Open();
                                    string qur = "UPDATE Teacher SET Name = '" + textBox2.Text + "' where CNIC = '" + textBox6.Text + "'";
                                    string qur2 = "UPDATE TeacherAttendence SET T_Name = '" + textBox2.Text + "' where CNIC = '" + textBox6.Text + "'";

                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    sda = new SqlDataAdapter(qur2, con);
                                    sda.SelectCommand.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("Name 'UPDATED' successfully");
                                }
                                else
                                {
                                    // update name + address right nowe
                                    con.Open();
                                    string qur = "UPDATE Teacher SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' where CNIC = '" + textBox6.Text + "'";
                                    string qur2 = "UPDATE TeacherAttendence SET T_Name = '" + textBox2.Text + "' where CNIC = '" + textBox6.Text + "'";

                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    sda = new SqlDataAdapter(qur2, con);
                                    sda.SelectCommand.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("Name and Address 'UPDATED' successfully");
                                }
                            }
                            else
                            {
                                if (textBox5.Text == "") // address
                                {
                                    // update name           //do it correctly now...
                                    con.Open();
                                    string qur = "UPDATE Teacher SET Name = '" + textBox2.Text + "' , PhoneNo = '" + textBox4.Text + "' where CNIC = '" + textBox6.Text + "'";
                                    string qur2 = "UPDATE TeacherAttendence SET T_Name = '" + textBox2.Text + "' where CNIC = '" + textBox6.Text + "'";

                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    sda = new SqlDataAdapter(qur2, con);
                                    sda.SelectCommand.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("Name and PhoneNo 'UPDATED' successfully");
                                }
                                else
                                {
                                    // update name + phone + address right nowe
                                    con.Open();
                                    string qur = "UPDATE Teacher SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' , PhoneNo = '" + textBox4.Text + "' where CNIC = '" + textBox6.Text + "'";
                                    string qur2 = "UPDATE TeacherAttendence SET T_Name = '" + textBox2.Text + "' where CNIC = '" + textBox6.Text + "'";

                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    sda = new SqlDataAdapter(qur2, con);
                                    sda.SelectCommand.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("Name, Phone No. and Address 'UPDATED' successfully");
                                }
                            }
                        }
                        else
                        {
                            //update name + class now check other's situation
                            if (textBox4.Text == "") // phone
                            {
                                if (textBox5.Text == "") // address
                                {
                                    // updaet name + class right now
                                    con.Open();
                                    string qur = "UPDATE Teacher SET Name = '" + textBox2.Text + "' , Experience = '" + textBox3.Text + "' where CNIC = '" + textBox6.Text + "'";
                                    string qur2 = "UPDATE TeacherAttendence SET T_Name = '" + textBox2.Text + "' where CNIC = '" + textBox6.Text + "'";

                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    sda = new SqlDataAdapter(qur2, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    con.Close();
                                    MessageBox.Show("Name and Experience 'UPDATED' successfully");
                                }
                                else
                                {
                                    // updaet name + Experience + Address right now
                                    con.Open();
                                    string qur = "UPDATE Teacher SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' , Experience = '" + textBox3.Text + "' where CNIC = '" + textBox6.Text + "'";
                                    string qur2 = "UPDATE TeacherAttendence SET T_Name = '" + textBox2.Text + "' where CNIC = '" + textBox6.Text + "'";

                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    sda = new SqlDataAdapter(qur2, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    con.Close();
                                    MessageBox.Show("Name, Experience and Address 'UPDATED' successfully");
                                }
                            }
                            else
                            {
                                // update name + Experience + phone now check for address
                                if (textBox5.Text == "") // address
                                {
                                    // updaet name + class + phone right now
                                    con.Open();
                                    string qur = "UPDATE Teacher SET Name = '" + textBox2.Text + "' , Experience = '" + textBox3.Text + "' , PhoneNo = '" + textBox4.Text + "' where CNIC = '" + textBox6.Text + "'";
                                    string qur2 = "UPDATE TeacherAttendence SET T_Name = '" + textBox2.Text + "' where CNIC = '" + textBox6.Text + "'";

                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    sda = new SqlDataAdapter(qur2, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    con.Close();
                                    MessageBox.Show("Name, Experience and Phone No. 'UPDATED' successfully");
                                }
                                else
                                {
                                    // updaet name + class + phone + address right now
                                    con.Open();
                                    string qur = "UPDATE Teacher SET Name = '" + textBox2.Text + "' , Experience = '" + textBox3.Text + "' , PhoneNo = '" + textBox4.Text + "' , Address = '" + textBox5.Text + "' where CNIC = '" + textBox6.Text + "'";
                                    string qur2 = "UPDATE TeacherAttendence SET T_Name = '" + textBox2.Text + "' where CNIC = '" + textBox6.Text + "'";

                                    sda = new SqlDataAdapter(qur, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    sda = new SqlDataAdapter(qur2, con);
                                    sda.SelectCommand.ExecuteNonQuery();

                                    con.Close();
                                    MessageBox.Show("Name, Experience, Phone No. and Address 'UPDATED' successfully");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Must Specify CNIC Filled", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
