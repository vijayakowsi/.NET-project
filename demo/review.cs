using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace demo
{
    public partial class review : Form
    {
        public review()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void review_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated security=true;Initial Catalog=demo;Data source=ICTSYS-206");
            SqlCommand cmd;
            con.Open();
            string s = "insert into review values(@p5,@p4,@p3,@p2)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p5", textBox5.Text);
            cmd.Parameters.AddWithValue("@p4", textBox4.Text);
            cmd.Parameters.AddWithValue("@p3", textBox3.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);

            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + " Record Inserted "); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ICTSYS-206;Initial Catalog=demo;Integrated Security=True";
            string sql = "SELECT * FROM review";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Table_1");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Table_1";
        }
    }
}
