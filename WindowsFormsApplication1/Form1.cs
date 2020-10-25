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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ALL DRIVE DATA\University\3rd semester\OOP\project\WindowsFormsApplication1\WindowsFormsApplication1\DBMS.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure! You want to exit.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // for login
            con.Open();
            string sqe = "SELECT count(*) FROM login where username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
            sda = new SqlDataAdapter(sqe, con);
            dt = new DataTable();
            sda.Fill(dt);

            textBox2.Text = "";

            if (dt.Rows[0][0].ToString() == "1")
            {
                main m = new main();
                m.Show();
            }
            else
            {
                MessageBox.Show("Please Correct the username and password\n\tor\nChoose another account.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // for Sign Up
            if (textBox3.Text == "mianmuhammadanwar")
            {
                textBox3.Text = "";
                signup s = new signup();
                s.Show();
                con.Close();
            }
            else
            {
                MessageBox.Show("You entered WRONG Permission Code", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
       
    }
}
