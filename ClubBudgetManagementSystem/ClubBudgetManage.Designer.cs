
namespace ClubBudgetManagementSystem
{
    partial class ClubBudgetManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.infosys202107DataSet = new ClubBudgetManagementSystem.infosys202107DataSet();
            this.managesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managesTableAdapter = new ClubBudgetManagementSystem.infosys202107DataSetTableAdapters.ManagesTableAdapter();
            this.tableAdapterManager = new ClubBudgetManagementSystem.infosys202107DataSetTableAdapters.TableAdapterManager();
            this.clubTableAdapter = new ClubBudgetManagementSystem.infosys202107DataSetTableAdapters.ClubTableAdapter();
            this.costTableAdapter = new ClubBudgetManagementSystem.infosys202107DataSetTableAdapters.CostTableAdapter();
            this.presentersTableAdapter = new ClubBudgetManagementSystem.infosys202107DataSetTableAdapters.PresentersTableAdapter();
            this.managesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbYearOrMonth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClub = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCostTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.presentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // infosys202107DataSet
            // 
            this.infosys202107DataSet.DataSetName = "infosys202107DataSet";
            this.infosys202107DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managesBindingSource
            // 
            this.managesBindingSource.DataMember = "Manages";
            this.managesBindingSource.DataSource = this.infosys202107DataSet;
            // 
            // managesTableAdapter
            // 
            this.managesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClubTableAdapter = this.clubTableAdapter;
            this.tableAdapterManager.CostTableAdapter = this.costTableAdapter;
            this.tableAdapterManager.ManagesTableAdapter = this.managesTableAdapter;
            this.tableAdapterManager.PresentersTableAdapter = this.presentersTableAdapter;
            this.tableAdapterManager.UpdateOrder = ClubBudgetManagementSystem.infosys202107DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clubTableAdapter
            // 
            this.clubTableAdapter.ClearBeforeFill = true;
            // 
            // costTableAdapter
            // 
            this.costTableAdapter.ClearBeforeFill = true;
            // 
            // presentersTableAdapter
            // 
            this.presentersTableAdapter.ClearBeforeFill = true;
            // 
            // managesDataGridView
            // 
            this.managesDataGridView.AllowUserToAddRows = false;
            this.managesDataGridView.AutoGenerateColumns = false;
            this.managesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.managesDataGridView.DataSource = this.managesBindingSource;
            this.managesDataGridView.Location = new System.Drawing.Point(12, 112);
            this.managesDataGridView.MultiSelect = false;
            this.managesDataGridView.Name = "managesDataGridView";
            this.managesDataGridView.ReadOnly = true;
            this.managesDataGridView.RowTemplate.Height = 21;
            this.managesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.managesDataGridView.Size = new System.Drawing.Size(444, 483);
            this.managesDataGridView.TabIndex = 1;
            this.managesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.managesDataGridView_DataError);
            this.managesDataGridView.DoubleClick += new System.EventHandler(this.managesDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PresentedDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "PresentedDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UsedDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "UsedDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Presenter_Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Presenter_Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cost_Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cost_Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Money";
            this.dataGridViewTextBoxColumn6.HeaderText = "Money";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Summary";
            this.dataGridViewTextBoxColumn7.HeaderText = "Summary";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Receipt";
            this.dataGridViewImageColumn1.HeaderText = "Receipt";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Confirmation";
            this.dataGridViewTextBoxColumn8.HeaderText = "Confirmation";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn9.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Club_Id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Club_Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Pyear";
            this.dataGridViewTextBoxColumn11.HeaderText = "Pyear";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Pmonth";
            this.dataGridViewTextBoxColumn12.HeaderText = "Pmonth";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // lbYearOrMonth
            // 
            this.lbYearOrMonth.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbYearOrMonth.Location = new System.Drawing.Point(64, 23);
            this.lbYearOrMonth.Name = "lbYearOrMonth";
            this.lbYearOrMonth.Size = new System.Drawing.Size(175, 26);
            this.lbYearOrMonth.TabIndex = 12;
            this.lbYearOrMonth.Text = "＿＿年度";
            this.lbYearOrMonth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "部活動名：";
            // 
            // cbClub
            // 
            this.cbClub.FormattingEnabled = true;
            this.cbClub.Location = new System.Drawing.Point(121, 70);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(121, 20);
            this.cbClub.TabIndex = 10;
            this.cbClub.SelectedIndexChanged += new System.EventHandler(this.cbClub_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(245, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "部費報告書";
            // 
            // lbCostTotal
            // 
            this.lbCostTotal.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbCostTotal.Location = new System.Drawing.Point(293, 612);
            this.lbCostTotal.Name = "lbCostTotal";
            this.lbCostTotal.Size = new System.Drawing.Size(163, 23);
            this.lbCostTotal.TabIndex = 14;
            this.lbCostTotal.Text = "\\";
            this.lbCostTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(222, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "合計金額";
            // 
            // presentersBindingSource
            // 
            this.presentersBindingSource.DataMember = "Presenters";
            this.presentersBindingSource.DataSource = this.infosys202107DataSet;
            // 
            // costBindingSource
            // 
            this.costBindingSource.DataMember = "Cost";
            this.costBindingSource.DataSource = this.infosys202107DataSet;
            // 
            // clubBindingSource
            // 
            this.clubBindingSource.DataMember = "Club";
            this.clubBindingSource.DataSource = this.infosys202107DataSet;
            // 
            // ClubBudgetManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 655);
            this.Controls.Add(this.lbCostTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbYearOrMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbClub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.managesDataGridView);
            this.Name = "ClubBudgetManage";
            this.Text = "ClubBudgetManage";
            this.Load += new System.EventHandler(this.ClubBudgetManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private infosys202107DataSet infosys202107DataSet;
        private System.Windows.Forms.BindingSource managesBindingSource;
        private infosys202107DataSetTableAdapters.ManagesTableAdapter managesTableAdapter;
        private infosys202107DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView managesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label lbYearOrMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbClub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCostTotal;
        private System.Windows.Forms.Label label2;
        private infosys202107DataSetTableAdapters.PresentersTableAdapter presentersTableAdapter;
        private System.Windows.Forms.BindingSource presentersBindingSource;
        private infosys202107DataSetTableAdapters.CostTableAdapter costTableAdapter;
        private System.Windows.Forms.BindingSource costBindingSource;
        private infosys202107DataSetTableAdapters.ClubTableAdapter clubTableAdapter;
        private System.Windows.Forms.BindingSource clubBindingSource;
    }
}