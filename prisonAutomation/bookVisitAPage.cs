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
    public partial class bookVisitAPage : Form
    {
        public bookVisitAPage()
        {
            InitializeComponent();
        }

        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private SQLiteDataReader DA;

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

        private void createBut_Click(object sender, EventArgs e)
        {
            String id = visitorPage.instance.id;
            String visits;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            using (var con = new SQLiteConnection("Data Source=|DataDirectory|/db.db"))
            {
                con.Open();
                using (var cmd = new SQLiteCommand("select * from Prisoners where ID='" + id + "'", con))
                {
                    DA = cmd.ExecuteReader();
                    DA.Read();
                    visits = DA.GetValue(7).ToString().Trim();
                    DA.Dispose();
                }
            }


            if (Int32.Parse(visits) < 1)
            {
                int newVisits = Int32.Parse(visits) + 1;
                string query = "update Prisoners set Visits='" + newVisits + "' where ID='" + id + "'";
                executeQuery(query);
                MessageBox.Show("Visit Booked");
            }
            else
            {
                MessageBox.Show("Reached maximum number of visits for this week.");
            }

        }

        private void crimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backBut_Click(object sender, EventArgs e)
        {
            visitorPage toVisitorPage = new visitorPage();
            this.Hide();
            toVisitorPage.Show();
        }
    }
}
