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
    
    public partial class visitorPage : Form
    {

        public static visitorPage instance;
        public string id;
        public visitorPage()
        {
            InitializeComponent();
            instance = this;
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            setConnection();
            sql_con.Open();
            SQLiteCommand sql_cmd = new SQLiteCommand("select * from Prisoners where ID='" + idText.Text + "'", sql_con);
            DA = sql_cmd.ExecuteReader();
            DA.Read();
            id = idText.Text;

            String name = DA.GetValue(1).ToString().Trim();
            String birth = DA.GetValue(2).ToString().Trim();
            
            if (birth == birthBox.Text.Trim() && name == nameBox.Text.Trim())
            {
                if (DA.GetValue(6).ToString().Equals("A"))
                {
                    bookVisitAPage toBookVisitA = new bookVisitAPage();
                    toBookVisitA.Show();
                    this.Hide();
                }
                else
                {
                    bookVisitPage toBookVisit = new bookVisitPage();
                    toBookVisit.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Information you entered was incorrect.");
            }
        }

        private void penaltyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void visitorPage_Load(object sender, EventArgs e)
        {
           
        }
    }
}
