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
    public partial class TopMenu : Form
    {
        public TopMenu()
        {
            InitializeComponent();
        }

        private void btRegist_Click(object sender, EventArgs e)
        {
            Umenu u = new Umenu();
            u.ShowDialog();
        }

        private void btManage_Click(object sender, EventArgs e)
        {
            Mmenu m = new Mmenu();
            m.ShowDialog();
        }

        private void TopMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
