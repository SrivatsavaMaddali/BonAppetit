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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            textBox2.Text = "Mallamma";
            textBox3.Text = "9876654321";
            textBox10.Text = (Form1.c_id).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SRIVATSAVA-PC\\SQLEXPRESS;Initial Catalog=DBS_MINI_PROJECT;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            String query = "insert into DELIVERY values(" + Int32.Parse(textBox1.Text) + ",'" + textBox2.Text + "','"+textBox3.Text+"',"+Int32.Parse(textBox10.Text)+"," + Int32.Parse(textBox4.Text) + ",'" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "'," + Int32.Parse(textBox9.Text) + "," + Int32.Parse(textBox12.Text) + ")";

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            con.Open();
            cmd1.CommandText = query;
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added successfully!!!");
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
    }
}
