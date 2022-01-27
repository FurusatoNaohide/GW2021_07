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
    public partial class ClubBudgetConfirm : Form
    {
        public DateTime PresentedDate { get; set; }
        public DateTime UsedDate { get; set; }
        public string Presenter { get; set; }
        public string CostName { get; set; }
        public double Money { get; set; }
        public string Summary { get; set; }
        public Image Recipt { get; set; }
        public string Confimation { get; set; }
        public string Remarks { get; set; }

        System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ja-JP");

        string confirmation;

        public ClubBudgetConfirm()
        {
            InitializeComponent();
        }

        private void btApproval_Click(object sender, EventArgs e)
        {
            confirmation = "承";
            change_decision();
        }

        private void btAgain_Click(object sender, EventArgs e)
        {
            if (tbRemarks.Text != "")
            {
                confirmation = "再";
                change_decision();
            }
            else
            {
                MessageBox.Show("再提出する際は、\r\n備考欄に再提出の理由を記載してください。");
            }
            
        }

        //確認欄と備考欄を更新
        private void change_decision()
        {
            Confimation = this.confirmation;
            Remarks = this.tbRemarks.Text;

            this.Close();
        }

        private void ClubBudgetConfirm_Load(object sender, EventArgs e)
        {
            ci.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();
            this.lbPDate.Text = PresentedDate.ToString("gg y年 M月 d日", ci);
            this.lbUsedDate.Text = UsedDate.ToString("gg y年 M月 d日", ci);
            this.lbName.Text = Presenter;
            this.lbCost.Text = CostName;
            this.lbSummary.Text = Summary;
            this.lbMoney.Text = "\\"+Money.ToString("#,##0");
            this.pbReceipt.Image = Recipt;
            this.tbRemarks.Text = Remarks;
        }
    }
}
