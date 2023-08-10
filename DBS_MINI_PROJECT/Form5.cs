using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBS_MINI_PROJECT
{
    public partial class Form5 : Form
    {
        DataTable dt;
        DataSet ds;
        DataRow dr;
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            con.Open();
            com.CommandText = "select order_id, item_id, quantity, total_price from ORDER_ where customer_id="+Form1.c_id+" and order_id="+Form3.lalal+"";
            com.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new SqlDataAdapter(com.CommandText, con);
            da.Fill(ds, "order_");
            dataGridView1.DataSource = ds.Tables["order_"].DefaultView;
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int p = 0;
            String query5 = "delete from ORDER_ where order_id="+Int32.Parse(textBox1.Text)+" and  item_id="+Int32.Parse(textBox2.Text)+"";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query5;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int k = 0;
            String query2 = "select price from ITEMS where item_id=" + Int32.Parse(textBox2.Text) + "";
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con1;
            cmd.CommandText = query2;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tb3_instructor");
            dt = ds.Tables["Tb3_instructor"];
            int t = dt.Rows.Count;
            dr = dt.Rows[k];
            int price = (Int32.Parse(dr["price"].ToString()));





            int q = 0;
            String query7 = "update ORDER_ set quantity="+Int32.Parse(textBox3.Text)+" where order_id=" + Int32.Parse(textBox1.Text) + " and  item_id=" + Int32.Parse(textBox2.Text) + "";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            con.Open();
            cmd1.CommandText = query7;
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated!!!");

            int upprice = Int32.Parse(textBox3.Text)*price;

            String query8 = "update ORDER_ set total_price=" +upprice + " where order_id=" + Int32.Parse(textBox1.Text) + " and  item_id=" + Int32.Parse(textBox2.Text) + "";
            SqlConnection con3= new SqlConnection();
            con3.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd2= new SqlCommand();
            cmd2.Connection = con3;
            con3.Open();
            cmd2.CommandText = query8;
            cmd2.ExecuteNonQuery();
            con3.Close();
            MessageBox.Show("Updated!!!");
        }
    }
}
