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

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private SQLiteDataReader DA;

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zoneBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void personalPage_Load(object sender, EventArgs e)
        {

        }

        private void gridBut_Click(object sender, EventArgs e)
        {
            gridView toGridView = new gridView();
            toGridView.Show();
            this.Hide();
        }

        private void createBut_Click(object sender, EventArgs e)
        {
            string query = "insert into Prisoners (ID,FullName,Crime,EntryDate,Penalty,Zone)values('"+idText.Text+ "','" + nameBox.Text + "','" + crimeBox.Text + "','" + dateBox.Text + "','" + penaltyBox.Text + "','"+zoneBox.Text+"')";
            executeQuery(query);
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            string query = "delete from Prisoners where ID='"+idText.Text+"'";
            executeQuery(query);
        }

        private void selectBut_Click(object sender, EventArgs e)
        {
            setConnection();
            sql_con.Open();
            SQLiteCommand sql_cmd2 = new SQLiteCommand("select * from Prisoners where ID='"+idText.Text+"'", sql_con);
            DA = sql_cmd2.ExecuteReader();
            DA.Read();
            nameBox.Text = DA.GetValue(1).ToString();
            crimeBox.Text = DA.GetValue(2).ToString();
            dateBox.Text = DA.GetValue(3).ToString();
            penaltyBox.Text = DA.GetValue(4).ToString();
            zoneBox.Text = DA.GetValue(5).ToString();

        }
    }
}
