using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisonAutomation
{
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();
        }

        private void personalBut_Click(object sender, EventArgs e)
        {
            personalPage toPersonalPage = new personalPage();
            toPersonalPage.Show();
            this.Hide();
        }
    }
}
