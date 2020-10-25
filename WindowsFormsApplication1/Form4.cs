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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ALL DRIVE DATA\University\3rd semester\OOP\project\WindowsFormsApplication1\WindowsFormsApplication1\DBMS.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure! You want to Update.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (textBox2.Text == "") // name
                {
                    if (textBox3.Text == "") // class
                    {
                        if (textBox4.Text == "") // phone
                        {
                            if (textBox5.Text == "") // address
                            {
                                MessageBox.Show("Atleast one field must be filled to update.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string sqe;
                                sqe = "UPDATE Studentother SET Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                if (textBox6.Text.ToString() == "9")
                                {
                                    sqe = "UPDATE Student9 SET Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "10")
                                {
                                    sqe = "UPDATE Student10 SET Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "11")
                                {
                                    sqe = "UPDATE Student11 SET Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "12")
                                {
                                    sqe = "UPDATE Student12 SET Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }

                                // update address right nowe
                                con.Open();
                                sda = new SqlDataAdapter(sqe, con);
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
                                string sqe;
                                sqe = "UPDATE Studentother SET Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                if (textBox6.Text.ToString() == "9")
                                {
                                    sqe = "UPDATE Student9 SET Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "10")
                                {
                                    sqe = "UPDATE Student10 SET Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "11")
                                {
                                    sqe = "UPDATE Student11 SET Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "12")
                                {
                                    sqe = "UPDATE Student12 SET Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }

                                // update phone right nowe
                                con.Open();
                                sda = new SqlDataAdapter(sqe, con);
                                sda.SelectCommand.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Phone No. 'UPDATED' successfully");
                            }
                            else
                            {
                                string qur;
                                qur = "UPDATE Studentother SET Phone = '" + textBox4.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                if (textBox6.Text.ToString() == "9")
                                {
                                    qur = "UPDATE Student9 SET Phone = '" + textBox4.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "10")
                                {
                                    qur = "UPDATE Student10 SET Phone = '" + textBox4.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "11")
                                {
                                    qur = "UPDATE Student11 SET Phone = '" + textBox4.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "12")
                                {
                                    qur = "UPDATE Student12 SET Phone = '" + textBox4.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }

                                // update phone + address right nowe
                                con.Open();
                                sda = new SqlDataAdapter(qur, con);
                                sda.SelectCommand.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Phone No. and Address 'UPDATED' successfully");
                            }
                        }
                    }
                    else
                    {
                        //update class now check other's situation
                        if (textBox4.Text == "") // phone
                        {
                            if (textBox5.Text == "") // address
                            {
                            //    string qur, qur2;
                            // first delete record from existing class <table>
                            //   and very next step is to create the same record in targetted class <table>
                                
                                

                                // updaet class right now
                                
                                con.Open();
                                //sda = new SqlDataAdapter(qur, con);
                                //sda.SelectCommand.ExecuteNonQuery();

                                //sda = new SqlDataAdapter(qur2, con);
                                //sda.SelectCommand.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Class 'UPDATED' successfully");
                            }
                            else
                            {
       ///////////////////////////////////////futher need to update{///////////////////////////////////////
                                string qur, qur2;
                                //qur = "UPDATE Studentother SET Class = '" + textBox3.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //qur2 = "UPDATE AttendenceE SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                //if (textBox6.Text.ToString() == "9")
                                //{
                                //    qur = "UPDATE Student9 SET Class = '" + textBox3.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence9 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                //}
                                //if (textBox6.Text.ToString() == "10")
                                //{
                                //    qur = "UPDATE Student10 SET Class = '" + textBox3.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence10 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "11")
                                //{
                                //    qur = "UPDATE Student11 SET Class = '" + textBox3.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence11 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "12")
                                //{
                                //    qur = "UPDATE Student12 SET Class = '" + textBox3.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence12 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                // update class + address right nowe
                                //con.Open();
                               
                                //sda = new SqlDataAdapter(qur, con);
                                //sda.SelectCommand.ExecuteNonQuery();

                                //sda = new SqlDataAdapter(qur2, con);
                                //sda.SelectCommand.ExecuteNonQuery();
                                //con.Close();
                                MessageBox.Show("Class and Address 'UPDATED' successfully");
                            }
                        }
                        else
                        {
                            // update class + phone now check for address
                            if (textBox5.Text == "") // address
                            {
                                //string qur, qur2;
                                //qur = "UPDATE Studentother SET Class = '" + textBox3.Text + "', Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //qur2 = "UPDATE AttendenceE SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                //if (textBox6.Text.ToString() == "9")
                                //{
                                //    qur = "UPDATE Student9 SET Class = '" + textBox3.Text + "', Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence9 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                //}
                                //if (textBox6.Text.ToString() == "10")
                                //{
                                //    qur = "UPDATE Student10 SET Class = '" + textBox3.Text + "', Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence10 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "11")
                                //{
                                //    qur = "UPDATE Student11 SET Class = '" + textBox3.Text + "', Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence11 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "12")
                                //{
                                //    qur = "UPDATE Student12 SET Class = '" + textBox3.Text + "', Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence12 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                
                                // updaet class + phone right now
                                //con.Open();
                                

                                //sda = new SqlDataAdapter(qur, con);
                                //sda.SelectCommand.ExecuteNonQuery();

                                //sda = new SqlDataAdapter(qur2, con);
                                //sda.SelectCommand.ExecuteNonQuery();
                                //con.Close();
                                MessageBox.Show("Class and Phone No. 'UPDATED' successfully");
                            }
                            else
                            {
                                //string qur, qur2;
                                //qur = "UPDATE Studentother SET Class = '" + textBox3.Text + "' , Address = '" + textBox5.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //qur2 = "UPDATE AttendenceE SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                //if (textBox6.Text.ToString() == "9")
                                //{
                                //    qur = "UPDATE Student9 SET Class = '" + textBox3.Text + "' , Address = '" + textBox5.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence9 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                //}
                                //if (textBox6.Text.ToString() == "10")
                                //{
                                //    qur = "UPDATE Student10 SET Class = '" + textBox3.Text + "' , Address = '" + textBox5.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence10 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "11")
                                //{
                                //    qur = "UPDATE Student11 SET Class = '" + textBox3.Text + "' , Address = '" + textBox5.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence11 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "12")
                                //{
                                //    qur = "UPDATE Student12 SET Class = '" + textBox3.Text + "' , Address = '" + textBox5.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence12 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //// updaet class + phone + address right now 
                                //con.Open();
                                
                                //sda = new SqlDataAdapter(qur, con);
                                //sda.SelectCommand.ExecuteNonQuery();

                                //sda = new SqlDataAdapter(qur2, con);
                                //sda.SelectCommand.ExecuteNonQuery();
                                //con.Close();
                                MessageBox.Show("Class, Phone No. and Address 'UPDATED' successfully");
                            }
                        }
                    }
                }
                else
                {
                    // name are to be update now check other's situation
                    if (textBox3.Text == "") // class
                    {
                        if (textBox4.Text == "") // phone
                        {
                            if (textBox5.Text == "") // address
                            {
                                string qur, qur2;
                                qur = "UPDATE Studentother SET Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                qur2 = "UPDATE AttendenceE SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                if (textBox6.Text.ToString() == "9")
                                {
                                    qur = "UPDATE Student9 SET Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence9 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                }
                                if (textBox6.Text.ToString() == "10")
                                {
                                    qur = "UPDATE Student10 SET Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence10 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "11")
                                {
                                    qur = "UPDATE Student11 SET Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence11 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "12")
                                {
                                    qur = "UPDATE Student12 SET Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence12 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }

                                // update name right nowe
                                con.Open();
                                
                                sda = new SqlDataAdapter(qur, con);
                                sda.SelectCommand.ExecuteNonQuery();

                                sda = new SqlDataAdapter(qur2, con);
                                sda.SelectCommand.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Name 'UPDATED' successfully");
                            }
                            else
                            {
                                string qur, qur2;
                                qur = "UPDATE Studentother SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                qur2 = "UPDATE AttendenceE SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                if (textBox6.Text.ToString() == "9")
                                {
                                    qur = "UPDATE Student9 SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence9 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "10")
                                {
                                    qur = "UPDATE Student10 SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence10 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "11")
                                {
                                    qur = "UPDATE Student11 SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence11 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "12")
                                {
                                    qur = "UPDATE Student12 SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence12 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }

                                // update name + address right nowe
                                con.Open();

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
                                string qur, qur2;
                                qur = "UPDATE Studentother SET Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                qur2 = "UPDATE AttendenceE SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                if (textBox6.Text.ToString() == "9")
                                {
                                    qur = "UPDATE Student9 SET Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence9 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "10")
                                {
                                    qur = "UPDATE Student10 SET Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence10 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "11")
                                {
                                    qur = "UPDATE Student11 SET Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence11 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "12")
                                {
                                    qur = "UPDATE Student12 SET Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence12 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }


                                // update name           //do it correctly now...
                                con.Open();

                                sda = new SqlDataAdapter(qur, con);
                                sda.SelectCommand.ExecuteNonQuery();

                                sda = new SqlDataAdapter(qur2, con);
                                sda.SelectCommand.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Name and Phone No 'UPDATED' successfully");
                            }
                            else
                            {
                                string qur, qur2;
                                qur = "UPDATE Studentother SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                qur2 = "UPDATE AttendenceE SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                if (textBox6.Text.ToString() == "9")
                                {
                                    qur = "UPDATE Student9 SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence9 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "10")
                                {
                                    qur = "UPDATE Student10 SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence10 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "11")
                                {
                                    qur = "UPDATE Student11 SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence11 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                if (textBox6.Text.ToString() == "12")
                                {
                                    qur = "UPDATE Student12 SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                    qur2 = "UPDATE Attendence12 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                }
                                
                                // update name + phone + address right nowe
                                con.Open();

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
                                //string qur, qur2, qur3;
                                //qur = "UPDATE Studentother SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //qur2 = "UPDATE AttendenceE SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //qur3 = "UPDATE AttendenceE SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                //if (textBox6.Text.ToString() == "9")
                                //{
                                //    qur = "UPDATE Student9 SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence9 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence9 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "10")
                                //{
                                //    qur = "UPDATE Student10 SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence10 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence10 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "11")
                                //{
                                //    qur = "UPDATE Student11 SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence11 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence11 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "12")
                                //{
                                //    qur = "UPDATE Student12 SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence12 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence12 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                
                                //// updaet name + class right now
                                //con.Open();

                                //sda = new SqlDataAdapter(qur, con);
                                //sda.SelectCommand.ExecuteNonQuery();

                                //sda = new SqlDataAdapter(qur2, con);
                                //sda.SelectCommand.ExecuteNonQuery();

                                //sda = new SqlDataAdapter(qur3, con);
                                //sda.SelectCommand.ExecuteNonQuery();
                                //con.Close();
                                MessageBox.Show("Name and Class 'UPDATED' successfully");
                            }
                            else
                            {
                                //string qur, qur2, qur3;
                                //qur = "UPDATE Studentother SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' , Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //qur2 = "UPDATE AttendenceE SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //qur3 = "UPDATE AttendenceE SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                //if (textBox6.Text.ToString() == "9")
                                //{
                                //    qur = "UPDATE Student9 SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' , Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence9 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence9 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "10")
                                //{
                                //    qur = "UPDATE Student10 SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' , Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence10 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence10 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "11")
                                //{
                                //    qur = "UPDATE Student11 SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' , Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence11 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence11 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "12")
                                //{
                                //    qur = "UPDATE Student12 SET Name = '" + textBox2.Text + "' , Address = '" + textBox5.Text + "' , Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence12 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence12 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}

                                //// updaet name + Class + Address right now
                                //con.Open();

                                //sda = new SqlDataAdapter(qur, con);
                                //sda.SelectCommand.ExecuteNonQuery();

                                //sda = new SqlDataAdapter(qur2, con);
                                //sda.SelectCommand.ExecuteNonQuery();

                                //sda = new SqlDataAdapter(qur3, con);
                                //sda.SelectCommand.ExecuteNonQuery();
                                //con.Close();
                                MessageBox.Show("Name, Class and Address 'UPDATED' successfully");
                            }
                        }
                        else
                        {
                            // update name + class + phone now check for address
                            if (textBox5.Text == "") // address
                            {
                                //string qur, qur2, qur3;
                                //qur = "UPDATE Studentother SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //qur2 = "UPDATE AttendenceE SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //qur3 = "UPDATE AttendenceE SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                //if (textBox6.Text.ToString() == "9")
                                //{
                                //    qur = "UPDATE Student9 SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence9 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence9 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "10")
                                //{
                                //    qur = "UPDATE Student10 SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence10 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence10 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "11")
                                //{
                                //    qur = "UPDATE Student11 SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence11 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence11 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "12")
                                //{
                                //    qur = "UPDATE Student12 SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' , Phone = '" + textBox4.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence12 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence12 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //// updaet name + class + phone right now
                                //con.Open();

                                //sda = new SqlDataAdapter(qur, con);
                                //sda.SelectCommand.ExecuteNonQuery();

                                //sda = new SqlDataAdapter(qur2, con);
                                //sda.SelectCommand.ExecuteNonQuery();

                                //sda = new SqlDataAdapter(qur3, con);
                                //sda.SelectCommand.ExecuteNonQuery();
                                //con.Close();
                                MessageBox.Show("Name, Class and Phone No. 'UPDATED' successfully");
                            }
                            else
                            {
                                //string qur, qur2, qur3;
                                //qur = "UPDATE Studentother SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' , Phone = '" + textBox4.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //qur2 = "UPDATE AttendenceE SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //qur3 = "UPDATE AttendenceE SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";

                                //if (textBox6.Text.ToString() == "9")
                                //{
                                //    qur = "UPDATE Student9 SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' , Phone = '" + textBox4.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence9 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence9 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "10")
                                //{
                                //    qur = "UPDATE Student10 SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' , Phone = '" + textBox4.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence10 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence10 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "11")
                                //{
                                //    qur = "UPDATE Student11 SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' , Phone = '" + textBox4.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence11 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence11 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //if (textBox6.Text.ToString() == "12")
                                //{
                                //    qur = "UPDATE Student12 SET Name = '" + textBox2.Text + "' , Class = '" + textBox3.Text + "' , Phone = '" + textBox4.Text + "' , Address = '" + textBox5.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur2 = "UPDATE Attendence12 SET St_Name = '" + textBox2.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //    qur3 = "UPDATE Attendence12 SET Class = '" + textBox3.Text + "' where Roll_No = '" + textBox8.Text + "'";
                                //}
                                //// updaet name + class + phone + address right now
                                //con.Open();

                                //sda = new SqlDataAdapter(qur, con);
                                //sda.SelectCommand.ExecuteNonQuery();

                                //sda = new SqlDataAdapter(qur2, con);
                                //sda.SelectCommand.ExecuteNonQuery();

                                //sda = new SqlDataAdapter(qur3, con);
                                //sda.SelectCommand.ExecuteNonQuery();
                                //con.Close();
                                MessageBox.Show("Name, Class, Phone No. and Address 'UPDATED' successfully");
                            }
                        }
                    }
                }
            }
            
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            main m = new main();
            m.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            Student th = new Student();
            th.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            Teacher th = new Teacher();
            th.Show();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure! You want to exit.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
