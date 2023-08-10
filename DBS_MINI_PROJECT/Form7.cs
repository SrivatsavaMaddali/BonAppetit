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
    public partial class Form7 : Form
    {
        DataTable dt,dtt;
        DataSet ds,dss;
        DataRow dr,drr;
        public Form7()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            con.Open();
            com.CommandText = "select * from Payment where customer_id="+Form1.c_id+"";
            com.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new SqlDataAdapter(com.CommandText, con);
            da.Fill(ds, "pay");
            dataGridView1.DataSource = ds.Tables["pay"].DefaultView;


            int i = 0;
            String query1 = "select count(order_id) as cnt from PAYMENT";
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con1;
            cmd.CommandText = query1;
            SqlDataAdapter daa = new SqlDataAdapter(cmd);
            DataSet dss = new DataSet();
            daa.Fill(dss, "Tbl_instructor");
            dtt = dss.Tables["Tbl_instructor"];
            int t = dtt.Rows.Count;
            drr = dtt.Rows[i];
            textBox1.Text = (Int32.Parse(drr["cnt"].ToString()) + 1).ToString();
            textBox3.Text = (Form1.c_id).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String query6 = "insert into PAYMENT values(" + Int32.Parse(textBox1.Text) + ",'" +comboBox1.SelectedItem + "'," + Int32.Parse(textBox3.Text) + "," + Int32.Parse(textBox4.Text) + ")";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            con.Open();
            cmd1.CommandText = query6;
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Payment added!!!");

            String query7 = "insert into HISTORY values(" + Int32.Parse(textBox4.Text) + "," + Int32.Parse(textBox3.Text) + ","+ Int32.Parse(Form3.piknik)+",'"+Form3.datee+"',"+Int32.Parse(Form3.itttt)+")";
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con1;
            con1.Open();
            cmd.CommandText = query7;
            cmd.ExecuteNonQuery();
            con1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String query6 = "delete from PAYMENT where customer_id="+Form1.c_id+"";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            con.Open();
            cmd1.CommandText = query6;
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Payment detail deleted!!!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            con.Open();
            com.CommandText = "select * from Payment where customer_id=" + Form1.c_id + "";
            com.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new SqlDataAdapter(com.CommandText, con);
            da.Fill(ds, "pay");
            dataGridView1.DataSource = ds.Tables["pay"].DefaultView;


            int i = 0;
            String query1 = "select count(order_id) as cnt from PAYMENT";
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con1;
            cmd.CommandText = query1;
            SqlDataAdapter daa = new SqlDataAdapter(cmd);
            DataSet dss = new DataSet();
            daa.Fill(dss, "Tbl_instructor");
            dtt = dss.Tables["Tbl_instructor"];
            int t = dtt.Rows.Count;
            drr = dtt.Rows[i];
            textBox1.Text = (Int32.Parse(drr["cnt"].ToString()) + 1).ToString();
            textBox3.Text = (Form1.c_id).ToString();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
