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

    public partial class gridView : Form
    {
        public gridView()
        {
            InitializeComponent();
            loadData();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void setConnection()
        {
            sql_con = new SQLiteConnection("Data Source=db.db;Version=3;New=False;Compress=True;");
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
        private void loadData()
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "SELECT * FROM Prisoners";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            table.DataSource = DT;
            sql_con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void personalBut_Click(object sender, EventArgs e)
        {
            personalPage toPersonalPage = new personalPage();
            toPersonalPage.Show();
            this.Hide();
        }
    }
}
