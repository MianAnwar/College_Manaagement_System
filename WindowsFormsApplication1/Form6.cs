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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ALL DRIVE DATA\University\3rd semester\OOP\project\WindowsFormsApplication1\WindowsFormsApplication1\DBMS.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;

        //SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Student where Name = '" + textBox1.Text + "'";

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
                    sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Studentother where Name = '" + textBox1.Text + "'";
                    if (textBox7.Text.ToString() == "9")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Student9 where Name = '" + textBox1.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "10")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Student10 where Name = '" + textBox1.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "11")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Student11 where Name = '" + textBox1.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "12")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Student12 where Name = '" + textBox1.Text + "'";
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
                    sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Studentother where Roll_No = '" + textBox14.Text + "'";
                    if (textBox7.Text.ToString() == "9")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Student9 where Roll_No = '" + textBox14.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "10")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Student10 where Roll_No = '" + textBox14.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "11")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Student11 where Roll_No = '" + textBox14.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "12")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Student12 where Roll_No = '" + textBox14.Text + "'";
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
                    sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Studentother where Roll_No = '" + textBox14.Text + "' OR Name = '" + textBox1.Text + "'";

                    if (textBox7.Text.ToString() == "9")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Student9 where Roll_No = '" + textBox14.Text + "' OR Name = '" + textBox1.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "10")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Student10 where Roll_No = '" + textBox14.Text + "' OR Name = '" + textBox1.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "11")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Student11 where Roll_No = '" + textBox14.Text + "' OR Name = '" + textBox1.Text + "'";
                    }
                    if (textBox7.Text.ToString() == "12")
                    {
                        sqe = "SELECT Roll_No,Name,Father_Name,Phone,Batch,Class,Gender,Address,Fee,DOB,CNIC,Nationality,Religion From Student12 where Roll_No = '" + textBox14.Text + "' OR Name = '" + textBox1.Text + "'";
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
            if (MessageBox.Show("Are you Sure! You want to print the brief detail of this class student", "Print Class Detail", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string rtReceipt;
            rtReceipt = "                      College    College                  \n";
            rtReceipt = rtReceipt + "------------------------------------------------------------------------\n";
            rtReceipt = rtReceipt + "                        Student Details                     \n";
            rtReceipt = rtReceipt + " Class: 10                                  Date: 10/10/2015 \n";
            rtReceipt = rtReceipt + "------------------------------------------------------------------------\n";
            rtReceipt = rtReceipt + "     Roll_No     :\t  222       \n";
            rtReceipt = rtReceipt + "     Name        :\t  Ali Abbas       \n";
            rtReceipt = rtReceipt + "     Father Name:\t  Muhammad Abbas     \n";
            rtReceipt = rtReceipt + "     Phone No.  :\t  03344021012     \n\n";
            rtReceipt = rtReceipt + "     Address    :\t  105 C1 high lahore pak    \n";
            rtReceipt = rtReceipt + "     Gender     :\t  Male    \n";
            rtReceipt = rtReceipt + "     DOB        :\t  11/11/2015    \n";
            rtReceipt = rtReceipt + "     Religion   :\t  Islam    \n\n";
            rtReceipt = rtReceipt + "     Email Add. :\t  None    \n";
            rtReceipt = rtReceipt + "     Fee        :\t  paid    \n";
            rtReceipt = rtReceipt + "     Batch      :\t  2015    \n";
            rtReceipt = rtReceipt + "-------------------------------------------------------------------------\n";
            rtReceipt = rtReceipt + "\n                                                Sig: _____________\n";
            e.Graphics.DrawString(rtReceipt.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(0, 0));
        }
    }
}
