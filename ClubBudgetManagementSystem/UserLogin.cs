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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            try
            {
                var data = this.clubTableAdapter.FillByLogin(this.infosys202107DataSet.Club, int.Parse(tbClubID.Text), tbPassWord.Text);
                var datas = this.clubTableAdapter.Fill(this.infosys202107DataSet.Club);
                int clubId = -1;
                int index = 0;
                if (data == 1)
                {
                    //部活の主キー番号を記憶させて別フォームに持っていきたい
                    foreach (var club in infosys202107DataSet.Club)
                    {
                        if (club.Club_No == int.Parse(tbClubID.Text))
                        {
                            clubId = club.Id;
                            break;
                        }
                        index++;
                    }
                    if (clubId != -1)
                    {
                        ClubBudgetRegistration registration = new ClubBudgetRegistration(clubId, index);
                        registration.ShowDialog();
                        this.Close();
                    }

                }
                else
                {
                    tbClubID.Text = null;
                    tbPassWord.Text = null;
                    MessageBox.Show("部活IDとパスワードが一致しませんでした。");
                }
            }
            catch (FormatException fx)
            {
                MessageBox.Show(fx.Message);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clubBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clubBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202107DataSet.Club' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubTableAdapter.Fill(this.infosys202107DataSet.Club);

        }
    }
}
