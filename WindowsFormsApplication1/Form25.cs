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
                             ///
namespace WindowsFormsApplication1
{
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ALL DRIVE DATA\University\3rd semester\OOP\project\WindowsFormsApplication1\WindowsFormsApplication1\DBMS.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;

        private void Form25_Load(object sender, EventArgs e)
        {
            ///// to shoewe data in d_grrd
            con.Open();
            string sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Phone,DOB,CNIC,Nationality,Religion,Address From Student9";
            sda = new SqlDataAdapter(sqe, con);
            dt = new DataTable();
            
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///// to shoewe data in d_grrd
            con.Open();
            string sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Phone,DOB,CNIC,Nationality,Religion,Address From Student9 where Batch = '" + textBox1.Text + "'";
            sda = new SqlDataAdapter(sqe, con);
            dt = new DataTable();

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///// to shoewe data in d_grrd
            con.Open();
            string sqe = "SELECT Roll_No,Name,Father_Name,Class,Gender,Phone,DOB,CNIC,Nationality,Religion,Address From Student9";
            sda = new SqlDataAdapter(sqe, con);
            dt = new DataTable();

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure! You want to print the brief detail of this class student", "Print Class Detail", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string rtReceipt;
            rtReceipt = "\n                            College College    \n";
            rtReceipt = rtReceipt+"---------------------------------------------------------------------------------\n";
            rtReceipt = rtReceipt+"            CLASS: 9 \n";
            rtReceipt = rtReceipt + " Roll No                         Name\n\n";
            rtReceipt = rtReceipt + "  3021                      Mian Muhammad Anwar   \n";
            rtReceipt = rtReceipt + "  3022                      Ali Abbas  \n";
            rtReceipt = rtReceipt + "  3023                      Zainba \n";
            rtReceipt = rtReceipt + "  3024                      Laiba   \n";
            rtReceipt = rtReceipt + "---------------------------------------------------------------------------------\n";
            e.Graphics.DrawString(rtReceipt.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(0, 0));
        }
    }
}
