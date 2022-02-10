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
    public partial class ClubBudgetRegistration : Form
    {
        private int _clubId;
        private int _index;
        public DateTime nendo;
        public string confirm;
        System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ja-JP");

        public ClubBudgetRegistration(int clubId,int index)
        {
            //前フォームから部活動のIDとインデックスをもらう
            InitializeComponent();
            _clubId = clubId;
            _index = index;
        }

        //保存
        private void managesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.managesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

        }

        private void ClubBudgetRegistration_Load(object sender, EventArgs e)
        {
            #region
            DateTime now = DateTime.Now;
            DateTime nNendo = now.AddMonths(-3);
            ci.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();
            string nyear = nNendo.ToString("gg y年", ci);
            string nmonth = now.ToString("MMM", ci);
            #endregion

            // TODO: このコード行はデータを 'infosys202107DataSet.Club' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubTableAdapter.Fill(this.infosys202107DataSet.Club);
            // TODO: このコード行はデータを 'infosys202107DataSet.Cost' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.costTableAdapter.Fill(this.infosys202107DataSet.Cost);
            // TODO: このコード行はデータを 'infosys202107DataSet.Presenters' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.presentersTableAdapter.Fill(this.infosys202107DataSet.Presenters);
            // TODO: このコード行はデータを 'infosys202107DataSet.Manages' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //全ての部活ごとの情報抽出
            //this.managesTableAdapter.FillByClub(this.infosys202107DataSet.Manages,_clubId);
            //今年度今月の部活ごとの情報抽出
            this.managesTableAdapter.FillByDataMonth(this.infosys202107DataSet.Manages, _clubId, nyear, nmonth);

            #region
            lbClubName.Text = this.infosys202107DataSet.Club[_index].Name;
            lbNowYear.Text = nyear + "度";
            lbNowMonth.Text = nmonth + "月";

            managesDataGridView.Columns[0].Visible = false;      //Id　主キー
            managesDataGridView.Columns[1].HeaderText = "提出日";
            managesDataGridView.Columns[2].Visible = false;      //部費使用日
            managesDataGridView.Columns[3].Visible = false;      //提出者Id　外部キー
            managesDataGridView.Columns[4].Visible = false;      //費用Id　外部キー
            managesDataGridView.Columns[5].HeaderText = "使用金額";
            managesDataGridView.Columns[6].Visible = false;
            managesDataGridView.Columns[7].Visible = false;      //領収書
            managesDataGridView.Columns[8].HeaderText = "確認欄";
            managesDataGridView.Columns[9].HeaderText = "備考欄";//備考
            managesDataGridView.Columns[10].Visible = false;     //部活Id　外部キー
            managesDataGridView.Columns[11].Visible = false;    //年度
            managesDataGridView.Columns[12].Visible = false;    //月

            managesDataGridView.Columns[9].Width = 347;
            managesDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            cbPresenter.KeyPress += new KeyPressEventHandler(Cb_KeyPress);
            cbCostName.KeyPress += new KeyPressEventHandler(Cb_KeyPress);
            #endregion

            //Presentersにある提出者リストをComboBoxに登録
            foreach (var item in infosys202107DataSet.Presenters)
            {
                setCbPresenter(item.Name);
            }
            //Costにある費用名リストをComboBoxに登録
            foreach (var item in infosys202107DataSet.Cost)
            {
                setCbCost(item.Name);
            }

            lbAttention.Text = "※選択した画像をクリックすると、実際のサイズで表示されます。\r\n※提出者名と費用名は直接入力することはできません。あらかじめ登録した情報をお使いください。\r\n";
            RaiseAgainCheck();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        //ComboBoxからの入力を無効
        private void Cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void setCbCost(string name)
        {
            if (!cbCostName.Items.Contains(name))
            {
                cbCostName.Items.Add(name);
            }
        }

        private void setCbPresenter(string name)
        {
            if (!cbPresenter.Items.Contains(name))
            {
                cbPresenter.Items.Add(name);
            }
        }

#if true//再提出対象の情報があるか調べる
        private void RaiseAgainCheck()
        {
            foreach (var item in this.infosys202107DataSet.Manages)
            {
                if (item.Confirmation.Contains("再"))
                    {
                        lbAttention.Text += "※再提出を求められた部費情報があります。訂正して更新しなおしてください。\r\n";
                        //MessageBox.Show("再提出を求められた部費情報があります。\r\n訂正して更新しなおしてください。");
                        break;
                    }
                
            }

        }
#endif

        //新規追加
        private void DataAddNew()
        {
#region
            try
            {
                this.managesBindingSource.AddNew();
                this.managesDataGridView.DataSource = this.managesBindingSource;
            }
            catch (NoNullAllowedException )
            {
                //二回目以降は追加されない
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

#endregion
        }

        //初期値
        private void Initialize()
        {
            dtpPresenDate.Value = DateTime.Today;
            dtpUsedDate.Value = DateTime.Today;
            cbPresenter.Text = "";
            cbCostName.Text = "";
            tbMoney.Text = "";
            tbSummary.Text = "";
            pbReceipt.Image = null;
        }

        //新規追加+登録ボタン
        private void btRegister_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("情報を登録します。よろしいですか？\r\n※必須事項をすべて入力されているか確認してください。","情報の登録",MessageBoxButtons.OKCancel);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                DataAddNew();
                DataRegister(sender, e);
            }
        }

        //登録・更新
        private void DataRegister(object sender,EventArgs e)
        {
            ci.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();
            try
            {
                managesDataGridView.CurrentRow.Cells[1].Value = (DateTime)dtpPresenDate.Value;
                managesDataGridView.CurrentRow.Cells[2].Value = (DateTime)dtpUsedDate.Value;
                //提出者、費用名は外部キーを登録
                managesDataGridView.CurrentRow.Cells[3].Value = Presenter_Refer(cbPresenter.Text);
                managesDataGridView.CurrentRow.Cells[4].Value = Cost_Refer(cbCostName.Text);
                managesDataGridView.CurrentRow.Cells[5].Value = int.Parse(tbMoney.Text);
                managesDataGridView.CurrentRow.Cells[6].Value = tbSummary.Text;
                managesDataGridView.CurrentRow.Cells[7].Value = pbReceipt.Image;
                if (managesDataGridView.CurrentRow.Cells[8].Value == DBNull.Value)
                {
                    managesDataGridView.CurrentRow.Cells[8].Value = "";
                }else if(confirm == "再")
                {
                    managesDataGridView.CurrentRow.Cells[8].Value = "訂";
                }
                managesDataGridView.CurrentRow.Cells[10].Value = _clubId;
                nendo = dtpPresenDate.Value.AddMonths(-3);
                managesDataGridView.CurrentRow.Cells[11].Value = nendo.ToString("gg y年", ci);
                managesDataGridView.CurrentRow.Cells[12].Value = dtpPresenDate.Value.ToString("MMM", ci);

                managesBindingNavigatorSaveItem_Click(sender, e);
                confirm = managesDataGridView.CurrentRow.Cells[8].Value.ToString();
                ConfirmCheck(confirm);
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("領収書の画像を入れてください。");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("提出者名か費用名が空白になっているか、登録されていません。\r\nもう一度確認するか、登録してください。");
            }
            catch (FormatException)
            {
                MessageBox.Show("必須事項をすべて入力してください。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //費用名から費用IDを持ってくる
        private object Cost_Refer(string costname)
        {
#region
            int C_Id = 0;
            var cData = infosys202107DataSet.Cost.Where(x => x.Name == costname).First();

            if (cData != null)
            {
                C_Id = cData.Id;
            }
            else
            {
                cbCostName.Text = null;
                MessageBox.Show("この費用名は登録されていません。\r\nもう一度確認するか、登録してください。");
            }
            
            return C_Id;
#endregion
        }

        //提出者名から提出者IDを持ってくる
        private object Presenter_Refer(string name)
        {
#region
            int P_Id = 0;
            var pData = infosys202107DataSet.Presenters.Where(x => x.Name == name).First();

            if (pData != null)
            {
                P_Id = pData.Id;
            }
            else
            {
                cbPresenter.Text = null;
                MessageBox.Show("この名前は登録されていません。\r\nもう一度確認するか、登録してください。");
            }
            

            return P_Id;
#endregion
        }

        //更新ボタン
        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (managesDataGridView.CurrentRow == null) return;
            if (managesDataGridView.CurrentRow.Cells == null) return;
            DialogResult dr = MessageBox.Show("選択された行データを更新します。よろしいですか？", "情報の更新", MessageBoxButtons.OKCancel);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                DataRegister(sender, e);
            }
            
        }

        //削除ボタン
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (managesDataGridView.CurrentRow == null) return;
            DialogResult dr = MessageBox.Show("選択された行データを削除します。よろしいですか？", "情報の削除", MessageBoxButtons.OKCancel);

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                managesBindingSource.RemoveAt(managesDataGridView.CurrentRow.Index);
                managesBindingNavigatorSaveItem_Click(sender, e);
                //データを消した後選択されたデータの承認の有無を調べる
                if (managesDataGridView.CurrentRow == null) return;
                string confirm = managesDataGridView.CurrentRow.Cells[8].Value.ToString();
                ConfirmCheck(confirm);
            }
            
#if false
            try
            {
                DialogResult dr = MessageBox.Show("選択された行データを削除します。よろしいですか？", "情報の削除", MessageBoxButtons.OKCancel);

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (DataGridViewRow item in managesDataGridView.SelectedRows)
                    {
                        if (!item.IsNewRow)
                        {
                            managesDataGridView.Rows.Remove(item);
                        }
                    }
                    managesBindingNavigatorSaveItem_Click(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
#endif
        }

        //初期値を設定する
        private void btDefault_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("入力情報を初期値に戻します。よろしいですか？\r\n※登録されているデータには影響はありません。","初期値設定",MessageBoxButtons.OKCancel);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Initialize();
            }
        }

        //領収書の画像追加
        private void btReceiptOpen_Click(object sender, EventArgs e)
        {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK)
            {
                pbReceipt.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        //画像消去
        private void btReceiptDelete_Click(object sender, EventArgs e)
        {
            pbReceipt.Image = null;
        }

        //選択した列の情報をフォームに表示
        private void managesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
#region
            if (managesDataGridView.CurrentRow == null) return;
            if ((int) managesDataGridView.CurrentRow.Cells[0].Value <= -1) return;
            try
            {
                dtpPresenDate.Value = (DateTime)managesDataGridView.CurrentRow.Cells[1].Value;
                dtpUsedDate.Value = (DateTime)managesDataGridView.CurrentRow.Cells[2].Value;
                //提出者名と費用名は外部キーで持ってくる
                cbPresenter.Text = Presenter_getName(managesDataGridView.CurrentRow.Cells[3].Value.ToString());
                cbCostName.Text = Cost_getName(managesDataGridView.CurrentRow.Cells[4].Value.ToString());
                tbMoney.Text = double.Parse(managesDataGridView.CurrentRow.Cells[5].Value.ToString()).ToString();
                tbSummary.Text = managesDataGridView.CurrentRow.Cells[6].Value.ToString();
                pbReceipt.Image = ByteArrayToImage((byte[])managesDataGridView.CurrentRow.Cells[7].Value);

                confirm = managesDataGridView.CurrentRow.Cells[8].Value.ToString();
                ConfirmCheck(confirm);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
#endregion
        }

        //情報が承認・再提出されたかチェック
        private void ConfirmCheck(string confirm)
        {
            switch (confirm)
            {
                case "承":
                    btUpdate.Enabled = false;
                    btDelete.Enabled = false;
                    break;
                case "再":
                    btUpdate.Enabled = true;
                    btDelete.Enabled = false;
                    break;
                case "訂":
                    btUpdate.Enabled = true;
                    btDelete.Enabled = false;
                    break;
                default:
                    btUpdate.Enabled = true;
                    btDelete.Enabled = true;
                    break;
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

        //Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        //費用IDから費用名
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

        //提出者IDから提出者名
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

        private void managesDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("実行しますか？", "行の削除", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true; //削除をキャンセル
            }
        }

        private void pbReceipt_Click(object sender, EventArgs e)
        {
            if (pbReceipt.Image == null) return;
            ImageExpand ie = new ImageExpand(pbReceipt.Image);
            ie.ShowDialog();
        }

    }
}
