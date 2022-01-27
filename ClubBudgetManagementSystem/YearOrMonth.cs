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
    public partial class YearOrMonth : Form
    {
        private string _year;
        private int _month;
        public DateTime nendo;
        System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ja-JP");

        public YearOrMonth()
        {
            InitializeComponent();
        }

        private void managesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.managesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

        }

        private void YearOrMonth_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202107DataSet.Manages' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.managesTableAdapter.Fill(this.infosys202107DataSet.Manages);
            selectedRange();

            var now = DateTime.Now;
            ci.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();
            nendo = now.AddMonths(-3);
            _year = nendo.ToString("gg y年", ci);

            foreach (var item in infosys202107DataSet.Manages)
            {
                setCbYear(item.PresentedDate);
            }

            cbYear.Text = _year;
        }

        //Managesにある提出日から年度を検出
        private void setCbYear(DateTime presentedDate)
        {
            nendo = presentedDate.AddMonths(-3);
            if (!cbYear.Items.Contains(nendo.ToString("gg y年",ci)))
            {
                cbYear.Items.Add(nendo.ToString("gg y年", ci));
            }
        }

        //月別か年度別かを指定
        private void selectedRange()
        {
            if (rbYear.Checked)
            {
                cbYear.Enabled = true;
                gbMonth.Enabled = false;
            }
            else
            {
                cbYear.Enabled = false;
                gbMonth.Enabled = true;
            }
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            selectedRange();
        }

        private void btOk_Click(object sender, EventArgs e)
        {

            try
            {
                //年度別　月は関係ない
                if (rbYear.Checked)
                {
                    _year = cbYear.Text;
                    _month = 0;
                }
                else
                {
                    //月別　年度は今年度（起動時に今年度が初期値になっている）
                    //指定したグループ内のラジオボタンでチェックされているものを取り出す
                    var rb_select = gbMonth.Controls.OfType<RadioButton>().SingleOrDefault(x => x.Checked);
                    _month = int.Parse(rb_select.Text.Replace("月", ""));
                }
                ClubBudgetManage cbmanage = new ClubBudgetManage(_year, _month);
                cbmanage.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
