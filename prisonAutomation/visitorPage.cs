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

        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private SQLiteDataReader DA;

        private void button1_Click(object sender, EventArgs e)
        {
            String name;
            String birth;
            using (var con = new SQLiteConnection("Data Source=|DataDirectory|/db.db"))
            {
                con.Open();
                using (var cmd = new SQLiteCommand("select * from Prisoners where ID='" + idText.Text + "'", con))
                {
                    DA = cmd.ExecuteReader();
                    DA.Read();
                    name = DA.GetValue(1).ToString().Trim();
                    birth = DA.GetValue(2).ToString().Trim();

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

                    DA.Dispose();
                }
            }

            id = idText.Text; 
        }

        private void penaltyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void visitorPage_Load(object sender, EventArgs e)
        {
           
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            startPage toPersonalPage = new startPage();
            this.Hide();
            toPersonalPage.Show();
        }
    }
}
