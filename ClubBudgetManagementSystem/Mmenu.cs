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
    public partial class Mmenu : Form
    {
        public Mmenu()
        {
            InitializeComponent();
        }

        //部活動登録画面に移動
        private void btClubRegister_Click(object sender, EventArgs e)
        {
            ClubRegister cregister = new ClubRegister();
            cregister.ShowDialog();
        }

        //提出者名登録画面に移動
        private void btPresenterRegister_Click(object sender, EventArgs e)
        {
            PresenterRegister pregister = new PresenterRegister();
            pregister.ShowDialog();
        }

        //費用名登録画面に移動
        private void btCostNameRegister_Click(object sender, EventArgs e)
        {
            CostNameRegister cnregister = new CostNameRegister();
            cnregister.ShowDialog();
        }

        //部費決算報告書画面に移動
        private void btManage_Click(object sender, EventArgs e)
        {
            YearOrMonth yom = new YearOrMonth();
            yom.ShowDialog();
        }
    }
}
