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
    public partial class personalPage : Form
    {
        public personalPage()
        {
            InitializeComponent();
        }

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

        private void gridBut_Click(object sender, EventArgs e)
        {
            gridView toGridView = new gridView();
            toGridView.Show();
            this.Hide();
        }

        private void createBut_Click(object sender, EventArgs e)
        {
            string query = "insert into Prisoners (ID,FullName,DateOfBirth,Crime,EntryDate,Penalty,Zone,Visits)values('"+idText.Text+ "','" + nameBox.Text + "','" + birthBox.Text + "','" + crimeBox.Text + "','" + dateBox.Text + "','" + penaltyBox.Text + "','"+zoneBox.Text+"','"+visitsText.Text+"')";
            executeQuery(query);
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            string query = "delete from Prisoners where ID='"+idText.Text+"'";
            executeQuery(query);
        }

        private void selectBut_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            using (var con = new SQLiteConnection("Data Source=|DataDirectory|/db.db"))
            {
                con.Open();
                using (var cmd = new SQLiteCommand("select * from Prisoners where ID='"+idText.Text+"'", con))
                {
                    DA = cmd.ExecuteReader();
                    DA.Read();
                    nameBox.Text = DA.GetValue(1).ToString();
                    birthBox.Text = DA.GetValue(2).ToString();
                    crimeBox.Text = DA.GetValue(3).ToString();
                    dateBox.Text = DA.GetValue(4).ToString();
                    penaltyBox.Text = DA.GetValue(5).ToString();
                    zoneBox.Text = DA.GetValue(6).ToString();
                    visitsText.Text = DA.GetValue(7).ToString();
                    DA.Dispose();
                }
            }
        }

        private void updateBut_Click(object sender, EventArgs e)
        {

            string query = "update Prisoners set FullName='"+nameBox.Text+ "',Crime='" + crimeBox.Text +"',DateOfBirth='" + birthBox.Text + "',EntryDate='" + dateBox.Text + "',Penalty='" + penaltyBox.Text + "',Zone='" + zoneBox.Text + "',Visits='" + visitsText.Text + "' where ID='" + idText.Text+"'";
            executeQuery(query);
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            startPage toStartPage = new startPage();
            this.Hide();
            toStartPage.Show();
        }
    }
}
