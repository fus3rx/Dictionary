﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class MainForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=localhost;Database=Dictionary;Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public MainForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
//            con.Open();
//            DataTable dt = new DataTable();
//            adapt = new SqlDataAdapter("select * from WordBank", con);
//            adapt.Fill(dt);
//            dataGridView1.DataSource = dt;
//            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
            this.Hide();
        }
    }
}
