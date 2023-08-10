using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DBS_MINI_PROJECT
{


    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataTable dt;
        DataRow dr;
        int i=0;
        public static int c_id;
        public static String passw;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2=new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c_id = Int32.Parse(textBox1.Text);
            query="select password_ from CUSTOMER where customer_id="+Int32.Parse(textBox1.Text)+"";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tbl_instructor");
            dt = ds.Tables["Tbl_instructor"];
            int t = dt.Rows.Count;
            if (t == 0)
            {
                MessageBox.Show("User doesn't exist");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                dr = dt.Rows[i];
                passw = dr["password_"].ToString();
                if (textBox2.Text == passw)
                {
                    Form3 f3 = new Form3();
                    this.Hide();
                    f3.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}