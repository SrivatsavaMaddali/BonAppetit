using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBS_MINI_PROJECT
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String oldpass = textBox1.Text;
            String newpass = textBox2.Text;
            String cid=textBox3.Text;
            if(oldpass==Form1.passw && Int32.Parse(cid)==Form1.c_id)
            {
             

                int q = 0;
                String query8 = "update CUSTOMER set password_='" +newpass+ "' where customer_id=" +Int32.Parse(cid)+ "";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con;
                con.Open();
                cmd1.CommandText = query8;
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password changed!!!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String oldpass = textBox1.Text;
            String newpass = textBox2.Text;
            String cid = textBox3.Text;
            if (oldpass == Form1.passw && Int32.Parse(cid) == Form1.c_id)
            {


                int q = 0;
                String query8 = "update CUSTOMER set password_='" + newpass + "' where customer_id=" + Int32.Parse(cid) + "";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con;
                con.Open();
                cmd1.CommandText = query8;
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password changed!!!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        { 
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
