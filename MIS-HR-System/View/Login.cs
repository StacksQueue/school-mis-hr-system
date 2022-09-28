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

namespace MIS_HR_System.View
{
    public partial class Login : Form
    {
        string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USJR CPE\Documents\DBHRMIS.accdb;
Persist Security Info=False;";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM tblStaff WHERE intIDNumber = @idNum AND strPassword = @password";

            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idNum", Convert.ToInt32(txtLoginIDNum.Text.ToString()));
            cmd.Parameters.AddWithValue("@password", txtLoginPass.Text.ToString());
            OleDbDataReader rdr = cmd.ExecuteReader();

            if(rdr.HasRows)
            {
                this.Hide();
                Form1 main = new Form1();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login Credentials");
            }

            
        }

        private void btnLoginSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration regForm = new Registration();
            regForm.Show();
        }
    }
}
