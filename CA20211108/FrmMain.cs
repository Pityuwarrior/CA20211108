﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CA20211108
{
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; private set; }
        public FrmMain(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void FrmAdatlap_Load(object sender, EventArgs e) 
        {
            using (var conn = new SqlConnection(ConnectionString)) 
            {
                var r = new SqlCommand("Select Nev from Tenyesztok", conn).ExecuteReader();
                while (r.Read()) comboBox1.Items.Add(r[0]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
