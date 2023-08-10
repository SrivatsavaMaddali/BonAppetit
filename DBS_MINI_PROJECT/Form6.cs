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
    public partial class Form6 : Form
    {
        DataTable dt;
        DataSet ds;
        DataRow dr; 
        public Form6()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            con.Open();
            com.CommandText = "select * from History where customer_id="+Form1.c_id+"";
            com.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new SqlDataAdapter(com.CommandText, con);
            da.Fill(ds, "hist");
            dataGridView1.DataSource = ds.Tables["hist"].DefaultView;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3= new Form3();
            this.Hide();
            f3.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            con.Open();
            com.CommandText = "select * from History where customer_id=" + Form1.c_id + "";
            com.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new SqlDataAdapter(com.CommandText, con);
            da.Fill(ds, "hist");
            dataGridView1.DataSource = ds.Tables["hist"].DefaultView;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
