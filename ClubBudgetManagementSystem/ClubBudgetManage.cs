﻿using System;
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
    public partial class ClubBudgetManage : Form
    {
        private string _year;
        private int _month;

        private DateTime _PresentedDate;
        private DateTime _UsedDate;
        private string _Presenter;
        private string _CostName;
        private double _Money;
        private string _Summary;
        private Image _Recipt;
        private string _Confimation;
        private string _Remarks;

        //まずは範囲情報で全部活該当データを抽出
        public ClubBudgetManage(string year,int month)
        {
            InitializeComponent();
            _year = year;
            if (month != 0)
            {
                _month = month;
            }
            else
            {
                _month = -1;
            }
        }

        private void managesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.managesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

        }

        private void ClubBudgetManage_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202107DataSet.Club' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubTableAdapter.Fill(this.infosys202107DataSet.Club);
            // TODO: このコード行はデータを 'infosys202107DataSet.Cost' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.costTableAdapter.Fill(this.infosys202107DataSet.Cost);
            // TODO: このコード行はデータを 'infosys202107DataSet.Presenters' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.presentersTableAdapter.Fill(this.infosys202107DataSet.Presenters);

            //Clubにある部活動名をComboBoxに登録
            foreach (var item in infosys202107DataSet.Club)
            {
                setCbClub(item.Name);
            }

            //年度表示
            #region
            if (_month != -1)
            {
                //月別
                lbYearOrMonth.Text = _year+"度" + _month + "月";
            }
            else
            {
                //年度別
                lbYearOrMonth.Text = _year+"度";
            }
            #endregion

            //範囲抽出
            #region
            managesDataGridView.Columns[0].Visible = false;
            managesDataGridView.Columns[1].HeaderText = "提出日";
            managesDataGridView.Columns[2].Visible = false;
            managesDataGridView.Columns[3].Visible = false;
            managesDataGridView.Columns[4].Visible = false;
            managesDataGridView.Columns[5].HeaderText = "使用金額";
            managesDataGridView.Columns[6].Visible = false;
            managesDataGridView.Columns[7].Visible = false;
            managesDataGridView.Columns[8].HeaderText = "確認欄";
            managesDataGridView.Columns[9].HeaderText = "備考欄";
            managesDataGridView.Columns[10].Visible = false;
            managesDataGridView.Columns[11].Visible = false;
            managesDataGridView.Columns[12].Visible = false;

            managesDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            #endregion

            cbClub.KeyPress += new KeyPressEventHandler(CbClub_KeyPress);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void CbClub_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void setCbClub(string name)
        {
            if (!cbClub.Items.Contains(name))
            {
                cbClub.Items.Add(name);
            }
        }

        //データ選択後別フォームに情報を持っていく
        private void managesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (managesDataGridView.CurrentRow == null) return;
            try
            {
                _PresentedDate = (DateTime)managesDataGridView.CurrentRow.Cells[1].Value;
                _UsedDate = (DateTime)managesDataGridView.CurrentRow.Cells[2].Value;
                //提出者名と費用名は外部キーで持ってくる
                _Presenter = Presenter_getName(managesDataGridView.CurrentRow.Cells[3].Value.ToString());
                _CostName = Cost_getName(managesDataGridView.CurrentRow.Cells[4].Value.ToString());
                _Money = double.Parse(managesDataGridView.CurrentRow.Cells[5].Value.ToString());
                _Summary = managesDataGridView.CurrentRow.Cells[6].Value.ToString();
                _Recipt = ByteArrayToImage((byte[])managesDataGridView.CurrentRow.Cells[7].Value);
                _Confimation = managesDataGridView.CurrentRow.Cells[8].Value.ToString();
                _Remarks = managesDataGridView.CurrentRow.Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            using (ClubBudgetConfirm cbconfirm = new ClubBudgetConfirm())
            {
                //プロパティに値を設定し、詳細画面を開く
                cbconfirm.PresentedDate = this._PresentedDate;
                cbconfirm.UsedDate = this._UsedDate;
                cbconfirm.Presenter = this._Presenter;
                cbconfirm.CostName = this._CostName;
                cbconfirm.Money = this._Money;
                cbconfirm.Summary = this._Summary;
                cbconfirm.Recipt = this._Recipt;
                cbconfirm.Confimation = this._Confimation;
                cbconfirm.Remarks = this._Remarks;

                cbconfirm.ShowDialog(this);
                //詳細画面で設定されたプロパティから値を反映する
                this.managesDataGridView.CurrentRow.Cells[8].Value = cbconfirm.Confimation; //確認欄
                this.managesDataGridView.CurrentRow.Cells[9].Value = cbconfirm.Remarks;

                managesBindingNavigatorSaveItem_Click(sender,e);
            }
        }

        //バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {
            Image img = null;
            if (b.Length > 0)
            {
                ImageConverter imgconv = new ImageConverter();
                img = (Image)imgconv.ConvertFrom(b);
            }
            return img;
        }

        private string Cost_getName(string cId)
        {
            #region
            var cdata = infosys202107DataSet.Cost.Where(x => x.Id == int.Parse(cId)).First();
            string c_Name = null;
            if (cdata != null)
            {
                c_Name = cdata.Name;
            }
            return c_Name;
            #endregion
        }

        private string Presenter_getName(string pId)
        {
            #region
            var pdata = infosys202107DataSet.Presenters.Where(x => x.Id == int.Parse(pId)).First();
            string p_Name = null;
            if (pdata != null)
            {
                p_Name = pdata.Name;
            }
            return p_Name;
            #endregion
        }

        private void managesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            double CostTotal = 0;
            //コンボボックスに登録した部活動を用いて部活IDを持ってくる
            //部活IDを基に、部活ごとのデータを持ってくる
            this.clubTableAdapter.FillByNameForId(this.infosys202107DataSet.Club, cbClub.Text);
            var club_id = infosys202107DataSet.Club.FirstOrDefault().Id;
            //部活IDと一緒に年度又は年度と月を条件に抽出する
            if (_month != -1)
            {
                //月別
                this.managesTableAdapter.FillByDataMonth(this.infosys202107DataSet.Manages, club_id, _year, _month.ToString());
            }
            else
            {
                //年度別
                this.managesTableAdapter.FillByDataYear(this.infosys202107DataSet.Manages, club_id, _year);
            }

            foreach (DataGridViewRow dr in managesDataGridView.Rows)
            {
                if(dr.Cells[5].Value != null)
                {
                    CostTotal += double.Parse(Convert.ToString(dr.Cells[5].Value));
                }
            }
            lbCostTotal.Text = "\\" + CostTotal.ToString("#,##0");
            RaiseCorrectCheck();
        }

        private void RaiseCorrectCheck()
        {
            foreach (var item in this.infosys202107DataSet.Manages)
            {
                if (item.Confirmation.Contains("訂"))
                {
                    MessageBox.Show("訂正された部費情報があります。\r\n確認してください。");
                    break;
                }

            }

        }
    }
}
