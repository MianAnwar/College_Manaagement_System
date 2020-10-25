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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ALL DRIVE DATA\University\3rd semester\OOP\project\WindowsFormsApplication1\WindowsFormsApplication1\DBMS.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;

        private void Form11_Load(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.ShowDialog();
                //make xhanges to the class of 9,10,11,12,E
                string sqe;
                // update set fee attribute table of related class ==>==> student9,student10,student11,student12,studentE   
                if (textBox2.Text != "")
                {
                    sqe = "UPDATE Studentother SET Fee = 'paid' where Roll_No = '" + textBox3.Text + "'";
                    if (textBox2.Text == "9")
                    {
                        sqe = "UPDATE Student9 SET Fee = 'paid' where Roll_No = '" + textBox3.Text + "'";
                    }
                    if (textBox2.Text == "10")
                    {
                        sqe = "UPDATE Student10 SET Fee = 'paid' where Roll_No = '" + textBox3.Text + "'";
                    }
                    if (textBox2.Text == "11")
                    {
                        sqe = "UPDATE Student11 SET Fee = 'paid' where Roll_No = '" + textBox3.Text + "'";
                    }
                    if (textBox2.Text == "12")
                    {
                        sqe = "UPDATE Student12 SET Fee = 'paid' where Roll_No = '" + textBox3.Text + "'";
                    }
                    con.Open();
                    sda = new SqlDataAdapter(sqe, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                }

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex.ToString() + "\n", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string rtReceipt;
            rtReceipt = "                      College    College                  \n";
            rtReceipt = rtReceipt+"                          Fee Voucher                     \n";
            rtReceipt = rtReceipt+" Class: " + textBox2.Text + "                                  Date: " + dateTimePicker1.Text.ToString() + "     \n";
            rtReceipt = rtReceipt+"------------------------------------------------------------------------\n";
            rtReceipt = rtReceipt + "     Roll_No          : "+ textBox3.Text +"                  \n";
            rtReceipt = rtReceipt + "     Name             : "+ textBox4.Text +"                  \n";
            rtReceipt = rtReceipt + "     Father Name   : "+ textBox5.Text +"                  \n";
            rtReceipt = rtReceipt + "-------------------------------------------------------------------------\n";
            rtReceipt = rtReceipt + "      Description                       Amount                  \n\n";
            rtReceipt = rtReceipt + "     Admission Fee                  "+ textBox7.Text +"                  \n";
            rtReceipt = rtReceipt + "     Tution Fee                         "+ textBox8.Text +"                  \n";
            rtReceipt = rtReceipt + "     Pre. Charges                     "+ textBox6.Text +"                  \n";
            rtReceipt = rtReceipt + "-------------------------------------------------------------------------\n";
            rtReceipt = rtReceipt + "     Total Balance                    "+ textBox9.Text +"                  \n";
            rtReceipt = rtReceipt + "--------------------------------------------------------------------------\n";
            rtReceipt = rtReceipt + "\n   Sig: _____________\n";
            e.Graphics.DrawString(rtReceipt.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(0, 0));
        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = 0, t = 0, p = 0;
                if (textBox7.Text != "")
                {
                    a = Convert.ToInt32(textBox7.Text);
                }
                if (textBox8.Text != "")
                {
                    t = Convert.ToInt32(textBox8.Text);
                }
                if (textBox6.Text != "")
                {
                    p = Convert.ToInt32(textBox6.Text);
                }

                int total = a + t + p;
                textBox9.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR \n" + ex.ToString() + "Contact Devloper", "Alert", MessageBoxButtons.OKCancel);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = 0, t = 0, p = 0;
                if (textBox7.Text != "")
                {
                    a = Convert.ToInt32(textBox7.Text);
                }
                if (textBox8.Text != "")
                {
                    t = Convert.ToInt32(textBox8.Text);
                }
                if (textBox6.Text != "")
                {
                    p = Convert.ToInt32(textBox6.Text);
                }

                int total = a + t + p;
                textBox9.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR \n" + ex.ToString() + "Contact Devloper", "Alert", MessageBoxButtons.OKCancel);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = 0, t = 0, p = 0;
                if (textBox7.Text != "")
                {
                    a = Convert.ToInt32(textBox7.Text);
                }
                if (textBox8.Text != "")
                {
                    t = Convert.ToInt32(textBox8.Text);
                }
                if (textBox6.Text != "")
                {
                    p = Convert.ToInt32(textBox6.Text);
                }

                int total = a + t + p;
                textBox9.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR \n" + ex.ToString() + "Contact Devloper", "Alert", MessageBoxButtons.OKCancel);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
