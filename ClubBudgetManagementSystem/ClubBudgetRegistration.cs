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
        System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ja-JP");

        public ClubBudgetRegistration(int clubId,int index)
        {
            InitializeComponent();
            _clubId = clubId;
            _index = index;
        }

        private void managesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.managesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

        }

        private void ClubBudgetRegistration_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202107DataSet.Club' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubTableAdapter.Fill(this.infosys202107DataSet.Club);
            // TODO: このコード行はデータを 'infosys202107DataSet.Cost' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.costTableAdapter.Fill(this.infosys202107DataSet.Cost);
            // TODO: このコード行はデータを 'infosys202107DataSet.Presenters' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.presentersTableAdapter.Fill(this.infosys202107DataSet.Presenters);
            // TODO: このコード行はデータを 'infosys202107DataSet.Manages' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.managesTableAdapter.FillByClub(this.infosys202107DataSet.Manages,_clubId);

            lbClubName.Text = this.infosys202107DataSet.Club[_index].Name;

            #region
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            #region
            try
            {
                this.managesBindingSource.AddNew();
                this.managesDataGridView.DataSource = this.managesBindingSource;
            }
            catch (ArgumentException ax)
            {
                MessageBox.Show(ax.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            //初期化
            dtpPresenDate.Value = DateTime.Today;
            dtpUsedDate.Value = DateTime.Today;
            cbPresenter.Text = "";
            cbCostName.Text = "";
            tbMoney.Text = "";
            tbSummary.Text = "";
            pbReceipt.Image = null;
            #endregion
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            ci.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();
            try
            {
                managesDataGridView.CurrentRow.Cells[1].Value = (DateTime)dtpPresenDate.Value;
                managesDataGridView.CurrentRow.Cells[2].Value = (DateTime)dtpUsedDate.Value;
                //提出者、費用名は外部キーを登録
                managesDataGridView.CurrentRow.Cells[3].Value = Presenter_Refer(cbPresenter.Text);
                managesDataGridView.CurrentRow.Cells[4].Value = Cost_Refer(cbCostName.Text);
                managesDataGridView.CurrentRow.Cells[5].Value = tbMoney.Text;
                managesDataGridView.CurrentRow.Cells[6].Value = tbSummary.Text;
                managesDataGridView.CurrentRow.Cells[7].Value = pbReceipt.Image;
                managesDataGridView.CurrentRow.Cells[10].Value = _clubId;
                nendo = dtpPresenDate.Value.AddMonths(-3);
                managesDataGridView.CurrentRow.Cells[11].Value = nendo.ToString("gg y年", ci);
                managesDataGridView.CurrentRow.Cells[12].Value = dtpPresenDate.Value.ToString("MMM", ci);

                managesBindingNavigatorSaveItem_Click(sender, e);
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("領収書の画像を入れてください。");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("提出者名か費用名が空白になっています。");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private object Cost_Refer(string costname)
        {
            #region
            int C_Id = 0;
            //try
            //{
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
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            return C_Id;
            #endregion
        }

        //提出者IDを取り出す、ない場合登録できない
        private object Presenter_Refer(string name)
        {
            #region
            int P_Id = 0;
            //try
            //{   
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

            //}
            //catch(InvalidOperationException ioe)
            //{
            //    MessageBox.Show(ioe.Message);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            return P_Id;
            #endregion
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (managesDataGridView.CurrentRow.Cells == null) return;

            btRegister_Click(sender, e);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        //確認ボタンは必要？
        private void btCheck_Click(object sender, EventArgs e)
        {

        }

        private void btReceiptOpen_Click(object sender, EventArgs e)
        {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK)
            {
                pbReceipt.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        private void btReceiptDelete_Click(object sender, EventArgs e)
        {
            pbReceipt.Image = null;
        }

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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
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
    }
}
