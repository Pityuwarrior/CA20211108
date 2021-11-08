using System;
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
    public partial class Form1 : Form
    {
        public string ConnectionString {private set; get;}
        
        public Form1()
        {
            ConnectionString =
                @"Server = (lockalsv)\MSSQLLocalDB;" +
                "Datadase = UniMenes";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var r = new SqlCommand(
                    "Select Unikornis.Id, Fajta.Nev, Tenyeszto.Nev, Varos, Suly, Nem" +
                    "From Fajta" +
                    "Inner JOIN Unikornis on Fajta.Id = FajtaId" +
                    "Inner Join Tenyeszto on TulajdonosId = Tenyeszto.Id", connection).ExecuteReader();

                while (r.Read()) 
                {
                    dgvMain.Rows.Add(r[0], r[1], r[2], r[3], r[4] + "kg", r.GetBoolean(5) ? "Csödör" : "Kanca");
                }
                connection.Close();
            }
        }

        private void bejelentkezesToolStrinpMenuItem_Click(object sender, EventArgs e) 
        {
            new FrmMain(ConnectionString).ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
