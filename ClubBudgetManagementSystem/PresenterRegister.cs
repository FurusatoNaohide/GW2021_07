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
    public partial class PresenterRegister : Form
    {
        public PresenterRegister()
        {
            InitializeComponent();
        }

        private void presentersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.presentersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

        }

        private void PresenterRegister_Load(object sender, EventArgs e)
        {
            #region
            // TODO: このコード行はデータを 'infosys202107DataSet.Presenters' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.presentersTableAdapter.Fill(this.infosys202107DataSet.Presenters);

            presentersDataGridView.Columns[0].Visible = false;
            presentersDataGridView.Columns[1].HeaderText = "提出者名";

            presentersDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            #endregion

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.presentersBindingSource.AddNew();
            this.presentersDataGridView.DataSource = this.presentersBindingSource;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (tbPresenterName.Text != "")
            {
                btAdd_Click(sender, e);
                presentersDataGridView.CurrentRow.Cells[1].Value = tbPresenterName.Text;

                this.Validate();
                this.presentersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

                tbPresenterName.Text = null;
            }
            else
            {
                MessageBox.Show("提出者名を入力してください。");
            }
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void presentersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
