using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubBudgetManagementSystem
{
    public partial class Umenu : Form
    {
        public Umenu()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            UserLogin ulogin = new UserLogin();
            ulogin.ShowDialog();
        }
    }
}
