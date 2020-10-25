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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\ALL DRIVE DATA\University\3rd semester\OOP\project\WindowsFormsApplication1\WindowsFormsApplication1\DBMS.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "mianmuhammadanwar")
            {
                // insert
                con.Open();
                string qur = "INSERT INTO Login (username,password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";
                sda = new SqlDataAdapter(qur, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SignUp successfully");
            }
            else
            {
                MessageBox.Show("You entered WRONG Permission Code", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure! You want to exit.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}
