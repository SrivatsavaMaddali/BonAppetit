using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace DBS_MINI_PROJECT
{
    public partial class Form3 : Form
    {
        DataSet ds,dss;
        DataTable dt,dtt;
        DataRow dr,drr;
        public static String datee;
        public static String piknik;
        public static String itttt;
        public static String lalal;
        int price;
        public Form3()
        {
            InitializeComponent();
            int i = 0;
            String query1 = "select count(order_id) as cnt from HISTORY";
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
            lalal = textBox1.Text;
            textBox2.Text = (Form1.c_id).ToString();


            int j = 0;
            String query2 = "SELECT CAST( GETDATE() AS Date ) as datee ;";
            SqlCommand cm= new SqlCommand();
            cm.Connection = con1;
            cm.CommandText = query2;
            SqlDataAdapter daa = new SqlDataAdapter(cm);
            DataSet dss = new DataSet();
            daa.Fill(dss, "Tb2_instructor");
            dtt = dss.Tables["Tb2_instructor"];
            int u = dtt.Rows.Count;
            drr = dtt.Rows[j];

            datee = (drr["datee"]).ToString();
            textBox5.Text= (drr["datee"]).ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5=new Form5();
            this.Hide();
            f5.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            itttt = textBox3.Text;
            String query6 = "insert into ORDER_ values(" + Int32.Parse(textBox1.Text) + ",'" + textBox2.Text + "'," + Int32.Parse(textBox6.Text) + "," + Int32.Parse(textBox4.Text) + ",'" +comboBox2.SelectedItem+"','" + textBox5.Text + "'," + Int32.Parse(textBox3.Text)+ ")";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            con.Open();
            cmd1.CommandText = query6;
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added to cart!!!");
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int k = 0;
            String query2 = "select price from ITEMS where item_id="+Int32.Parse(textBox3.Text)+"";
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
            price = (Int32.Parse(dr["price"].ToString()));


            textBox6.Text = (price * Int32.Parse(textBox4.Text)).ToString();
            piknik = textBox6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 f8= new Form8();
            this.Hide();
            f8.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Hide();
            f9.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            con.Open();
            com.CommandText = "select items.item_id,item_name,price from ITEMS, CATEGORY where ITEMS.item_id=CATEGORY.item_id and CATEGORY.category='"+comboBox1.SelectedItem+"'";
            com.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new SqlDataAdapter(com.CommandText, con);
            da.Fill(ds, "items");
            dataGridView1.DataSource = ds.Tables["Items"].DefaultView;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
