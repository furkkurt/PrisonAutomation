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

        private void createBut_Click(object sender, EventArgs e)
        {
            String id = visitorPage.instance.id;
            
            setConnection();
            sql_con.Open();
            SQLiteCommand sql_cmd = new SQLiteCommand("select * from Prisoners where ID='" + id + "'", sql_con);
            DA = sql_cmd.ExecuteReader();
            DA.Read();

            String visits = DA.GetValue(7).ToString().Trim();
            if(Int32.Parse(visits) < 1)
            {
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
    }
}
