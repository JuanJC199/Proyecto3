using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Sqlite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
           
            
        }

        private void cmdExecuteQuery_Click(object sender, EventArgs e)
        {
            SQLiteConnection myConnection = new SQLiteConnection("Data Source=C:\\sqlite3\\test.db;Version=3");
            myConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myConnection;
            cmd.CommandText = querytxt.Text;
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(sdr);
                sdr.Close();
                myConnection.Close();
                grid1.DataSource = dt;
            }

        }

        private void LlenarRepeat(string n, int val)
        {
            List<string> lista = new List<string>();
            DataTable tabla = new DataTable();
            for(int i = 0; i<val; i++)
            {
                tabla.Rows.Add(n);
            }
            grid1.DataSource = tabla;

        }
    }
}
