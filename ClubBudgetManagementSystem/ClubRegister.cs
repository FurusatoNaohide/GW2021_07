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
    public partial class ClubRegister : Form
    {
        public ClubRegister()
        {
            InitializeComponent();
        }

        private void clubBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clubBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

        }

        private void ClubRegister_Load(object sender, EventArgs e)
        {
            

            clubDataGridView.Columns[0].Visible = false;
            clubDataGridView.Columns[1].HeaderText = "部活ID";
            clubDataGridView.Columns[2].HeaderText = "部活動名";
            clubDataGridView.Columns[3].Visible = false;

            clubDataGridView.Columns[1].Width = 70;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202107DataSet.Club' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clubTableAdapter.Fill(this.infosys202107DataSet.Club);
            this.btAdd_Click(sender, e);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.clubBindingSource.AddNew();
            this.clubDataGridView.DataSource = this.clubBindingSource;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            clubDataGridView.CurrentRow.Cells[1].Value = tbClubID.Text;
            clubDataGridView.CurrentRow.Cells[2].Value = tbClubName.Text;
            clubDataGridView.CurrentRow.Cells[3].Value = tbPassWord.Text;

            this.Validate();
            this.clubBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

            tbClubID.Text = null;
            tbClubName.Text = null;
            tbPassWord.Text = null;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clubDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
