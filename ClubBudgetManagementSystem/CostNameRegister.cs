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
    public partial class CostNameRegister : Form
    {
        public CostNameRegister()
        {
            InitializeComponent();
        }

        private void costBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.costBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

        }

        private void CostNameRegister_Load(object sender, EventArgs e)
        {
            #region
            // TODO: このコード行はデータを 'infosys202107DataSet.Cost' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.costTableAdapter.Fill(this.infosys202107DataSet.Cost);

            costDataGridView.Columns[0].Visible = false;
            costDataGridView.Columns[1].HeaderText = "費用名";

            costDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            #endregion

            #region
            //foreach (var item in infosys202107DataSet.Cost)
            //{
            //    listBox1.Items.Add(item.Name);
            //}
            #endregion

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.costBindingSource.AddNew();
            this.costDataGridView.DataSource = this.costBindingSource;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (tbCostName.Text != "")
            {
                btAdd_Click(sender, e);
                costDataGridView.CurrentRow.Cells[1].Value = tbCostName.Text;
                this.Validate();
                this.costBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.infosys202107DataSet);

                tbCostName.Text = null;
            }
            else
            {
                MessageBox.Show("費用名を入力してください。");
            }
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void costDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
