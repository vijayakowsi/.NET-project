﻿using System;
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
    public partial class reviewerlogin : Form
    {
        public reviewerlogin()
        {
            InitializeComponent();
        }

        private void reviewerlogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated security=true;Initial Catalog=demo;Data source=ICTSYS-206");
            SqlCommand cmd;
            con.Open();
            string s = "insert into reviewer values(@p1,@p2)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
          
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + " Record Inserted "); 
            review f4 = new review();
            f4.Show();
        }
    }
}
