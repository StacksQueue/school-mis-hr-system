using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_HR_System
{
    public partial class Form1 : Form
    {
        string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USJR CPE\Documents\DBHRMIS.accdb;
Persist Security Info=False;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMainHome_Click(object sender, EventArgs e)
        {

        }

        private void btnMainLeave_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM tblDepartment";
            DataTable dt = new DataTable();

            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(dt);
            dgvLeave.DataSource = dt;
            conn.Close();
        }

        
    }
}
