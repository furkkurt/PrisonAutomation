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

        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();


        private void executeQuery(string query)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            using (var con = new SQLiteConnection("Data Source=|DataDirectory|/db.db"))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void loadData()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            using (var con = new SQLiteConnection("Data Source=db.db"))
            {
                con.Open();
                using (var cmd = new SQLiteCommand("SELECT * FROM Prisoners", con))
                {
                    DB = new SQLiteDataAdapter("SELECT * FROM Prisoners", con);
                    DS.Reset();
                    DB.Fill(DS);
                    DT = DS.Tables[0];
                    table.DataSource = DT;
                }
            }
        }

        private void personalBut_Click(object sender, EventArgs e)
        {
            personalPage toPersonalPage = new personalPage();
            toPersonalPage.Show();
            this.Hide();
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            DataView DV = DT.DefaultView;
            DV.RowFilter = string.Format("FullName like '%{0}%'", searchBox.Text);
            table.DataSource = DV.ToTable();
            Console.WriteLine(searchBox.Text);
        }
    }
}
