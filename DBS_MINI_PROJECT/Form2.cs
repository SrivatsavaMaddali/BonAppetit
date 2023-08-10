using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_MINI_PROJECT
{
    public partial class Form2 : Form
    {
        DataTable dt;
        DataRow dr;
        public Form2()
        {
            InitializeComponent();
            int i = 0;
            String query1 = "select count(customer_id) as cnt from CUSTOMER";
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con1;
            cmd.CommandText = query1;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tbl_instructor");
            dt = ds.Tables["Tbl_instructor"];
            int t = dt.Rows.Count;
            dr = dt.Rows[i];
            textBox1.Text = (Int32.Parse(dr["cnt"].ToString()) + 1).ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
          




            String query = "insert into CUSTOMER values(" + Int32.Parse(textBox1.Text) + ",'" + textBox2.Text + "'," + Int32.Parse(textBox3.Text) + "," + Int32.Parse(textBox4.Text) + ",'" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "'," + Int32.Parse(textBox9.Text) + ",'" + textBox10.Text + "','" + textBox11.Text + "'," + Int32.Parse(textBox12.Text) + ")";

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            con.Open();
            cmd1.CommandText = query;
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registered successfully!!!");
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
