using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace prisonAutomation
{
    public partial class personalLogin : Form
    {
        public personalLogin()
        {
            InitializeComponent();
            setConnection();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private SQLiteDataReader DA;

        private void setConnection()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

            sql_con = new SQLiteConnection("Data Source=|DataDirectory|/db.db;Version=3;New=False;Compress=True;");
        }

        private void executeQuery(string query)
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = query;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        private void loginBut_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Personals WHERE ID='" + idBox.Text + "' AND Password='" + passwordBox.Text + "'";
            DB = new SQLiteDataAdapter(query, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            
            if(DT.Rows.Count > 0)
            {
                personalPage toPersonalPage = new personalPage();
                this.Hide();
                toPersonalPage.Show();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            startPage toPersonalPage = new startPage();
            this.Hide();
            toPersonalPage.Show();
        }
    }
}
