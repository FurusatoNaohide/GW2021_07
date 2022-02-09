
namespace ClubBudgetManagementSystem
{
    partial class YearOrMonth
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.gbRange = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.gbMonth = new System.Windows.Forms.GroupBox();
            this.rbApril = new System.Windows.Forms.RadioButton();
            this.rbFebruary = new System.Windows.Forms.RadioButton();
            this.rbMarch = new System.Windows.Forms.RadioButton();
            this.rbMay = new System.Windows.Forms.RadioButton();
            this.rbJanuary = new System.Windows.Forms.RadioButton();
            this.rbJune = new System.Windows.Forms.RadioButton();
            this.rbAugust = new System.Windows.Forms.RadioButton();
            this.rbJuly = new System.Windows.Forms.RadioButton();
            this.rbNovember = new System.Windows.Forms.RadioButton();
            this.rbOctober = new System.Windows.Forms.RadioButton();
            this.rbSeptember = new System.Windows.Forms.RadioButton();
            this.rbDecember = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managesBindingSource)).BeginInit();
            this.gbRange.SuspendLayout();
            this.gbMonth.SuspendLayout();
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
            this.tableAdapterManager.ClubTableAdapter = null;
            this.tableAdapterManager.CostTableAdapter = null;
            this.tableAdapterManager.ManagesTableAdapter = this.managesTableAdapter;
            this.tableAdapterManager.PresentersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ClubBudgetManagementSystem.infosys202107DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btCancel
            // 
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCancel.Location = new System.Drawing.Point(166, 322);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(95, 32);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "キャンセル";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btOk.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOk.Location = new System.Drawing.Point(106, 321);
            this.btOk.Margin = new System.Windows.Forms.Padding(2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(56, 32);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // gbRange
            // 
            this.gbRange.Controls.Add(this.label1);
            this.gbRange.Controls.Add(this.cbYear);
            this.gbRange.Controls.Add(this.rbYear);
            this.gbRange.Controls.Add(this.rbMonth);
            this.gbRange.Controls.Add(this.gbMonth);
            this.gbRange.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbRange.Location = new System.Drawing.Point(15, 13);
            this.gbRange.Margin = new System.Windows.Forms.Padding(2);
            this.gbRange.Name = "gbRange";
            this.gbRange.Padding = new System.Windows.Forms.Padding(2);
            this.gbRange.Size = new System.Drawing.Size(246, 293);
            this.gbRange.TabIndex = 5;
            this.gbRange.TabStop = false;
            this.gbRange.Text = "範囲選択";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "年度決算";
            // 
            // cbYear
            // 
            this.cbYear.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(59, 251);
            this.cbYear.Margin = new System.Windows.Forms.Padding(2);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(124, 28);
            this.cbYear.TabIndex = 0;
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Location = new System.Drawing.Point(82, 36);
            this.rbYear.Margin = new System.Windows.Forms.Padding(2);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(85, 28);
            this.rbYear.TabIndex = 1;
            this.rbYear.Tag = "1";
            this.rbYear.Text = "年度別";
            this.rbYear.UseVisualStyleBackColor = true;
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Checked = true;
            this.rbMonth.Location = new System.Drawing.Point(8, 36);
            this.rbMonth.Margin = new System.Windows.Forms.Padding(2);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(66, 28);
            this.rbMonth.TabIndex = 0;
            this.rbMonth.TabStop = true;
            this.rbMonth.Tag = "0";
            this.rbMonth.Text = "月別";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
            // 
            // gbMonth
            // 
            this.gbMonth.Controls.Add(this.rbApril);
            this.gbMonth.Controls.Add(this.rbFebruary);
            this.gbMonth.Controls.Add(this.rbMarch);
            this.gbMonth.Controls.Add(this.rbMay);
            this.gbMonth.Controls.Add(this.rbJanuary);
            this.gbMonth.Controls.Add(this.rbJune);
            this.gbMonth.Controls.Add(this.rbAugust);
            this.gbMonth.Controls.Add(this.rbJuly);
            this.gbMonth.Controls.Add(this.rbNovember);
            this.gbMonth.Controls.Add(this.rbOctober);
            this.gbMonth.Controls.Add(this.rbSeptember);
            this.gbMonth.Controls.Add(this.rbDecember);
            this.gbMonth.Location = new System.Drawing.Point(8, 66);
            this.gbMonth.Name = "gbMonth";
            this.gbMonth.Size = new System.Drawing.Size(229, 147);
            this.gbMonth.TabIndex = 0;
            this.gbMonth.TabStop = false;
            this.gbMonth.Text = "月決算";
            // 
            // rbApril
            // 
            this.rbApril.AutoSize = true;
            this.rbApril.Checked = true;
            this.rbApril.Location = new System.Drawing.Point(10, 24);
            this.rbApril.Margin = new System.Windows.Forms.Padding(2);
            this.rbApril.Name = "rbApril";
            this.rbApril.Size = new System.Drawing.Size(59, 28);
            this.rbApril.TabIndex = 3;
            this.rbApril.TabStop = true;
            this.rbApril.Tag = "3";
            this.rbApril.Text = "4月";
            this.rbApril.UseVisualStyleBackColor = true;
            // 
            // rbFebruary
            // 
            this.rbFebruary.AutoSize = true;
            this.rbFebruary.Location = new System.Drawing.Point(79, 111);
            this.rbFebruary.Margin = new System.Windows.Forms.Padding(2);
            this.rbFebruary.Name = "rbFebruary";
            this.rbFebruary.Size = new System.Drawing.Size(59, 28);
            this.rbFebruary.TabIndex = 1;
            this.rbFebruary.Tag = "1";
            this.rbFebruary.Text = "2月";
            this.rbFebruary.UseVisualStyleBackColor = true;
            // 
            // rbMarch
            // 
            this.rbMarch.AutoSize = true;
            this.rbMarch.Location = new System.Drawing.Point(154, 111);
            this.rbMarch.Margin = new System.Windows.Forms.Padding(2);
            this.rbMarch.Name = "rbMarch";
            this.rbMarch.Size = new System.Drawing.Size(59, 28);
            this.rbMarch.TabIndex = 2;
            this.rbMarch.Tag = "2";
            this.rbMarch.Text = "3月";
            this.rbMarch.UseVisualStyleBackColor = true;
            // 
            // rbMay
            // 
            this.rbMay.AutoSize = true;
            this.rbMay.Location = new System.Drawing.Point(80, 24);
            this.rbMay.Margin = new System.Windows.Forms.Padding(2);
            this.rbMay.Name = "rbMay";
            this.rbMay.Size = new System.Drawing.Size(59, 28);
            this.rbMay.TabIndex = 4;
            this.rbMay.Tag = "4";
            this.rbMay.Text = "5月";
            this.rbMay.UseVisualStyleBackColor = true;
            // 
            // rbJanuary
            // 
            this.rbJanuary.AutoSize = true;
            this.rbJanuary.Location = new System.Drawing.Point(10, 111);
            this.rbJanuary.Margin = new System.Windows.Forms.Padding(2);
            this.rbJanuary.Name = "rbJanuary";
            this.rbJanuary.Size = new System.Drawing.Size(59, 28);
            this.rbJanuary.TabIndex = 0;
            this.rbJanuary.Tag = "0";
            this.rbJanuary.Text = "1月";
            this.rbJanuary.UseVisualStyleBackColor = true;
            // 
            // rbJune
            // 
            this.rbJune.AutoSize = true;
            this.rbJune.Location = new System.Drawing.Point(154, 24);
            this.rbJune.Margin = new System.Windows.Forms.Padding(2);
            this.rbJune.Name = "rbJune";
            this.rbJune.Size = new System.Drawing.Size(59, 28);
            this.rbJune.TabIndex = 5;
            this.rbJune.Tag = "5";
            this.rbJune.Text = "6月";
            this.rbJune.UseVisualStyleBackColor = true;
            // 
            // rbAugust
            // 
            this.rbAugust.AutoSize = true;
            this.rbAugust.Location = new System.Drawing.Point(80, 53);
            this.rbAugust.Margin = new System.Windows.Forms.Padding(2);
            this.rbAugust.Name = "rbAugust";
            this.rbAugust.Size = new System.Drawing.Size(59, 28);
            this.rbAugust.TabIndex = 7;
            this.rbAugust.Tag = "7";
            this.rbAugust.Text = "8月";
            this.rbAugust.UseVisualStyleBackColor = true;
            // 
            // rbJuly
            // 
            this.rbJuly.AutoSize = true;
            this.rbJuly.Location = new System.Drawing.Point(10, 53);
            this.rbJuly.Margin = new System.Windows.Forms.Padding(2);
            this.rbJuly.Name = "rbJuly";
            this.rbJuly.Size = new System.Drawing.Size(59, 28);
            this.rbJuly.TabIndex = 6;
            this.rbJuly.Tag = "6";
            this.rbJuly.Text = "7月";
            this.rbJuly.UseVisualStyleBackColor = true;
            // 
            // rbNovember
            // 
            this.rbNovember.AutoSize = true;
            this.rbNovember.Location = new System.Drawing.Point(79, 82);
            this.rbNovember.Margin = new System.Windows.Forms.Padding(2);
            this.rbNovember.Name = "rbNovember";
            this.rbNovember.Size = new System.Drawing.Size(71, 28);
            this.rbNovember.TabIndex = 10;
            this.rbNovember.Tag = "10";
            this.rbNovember.Text = "11月";
            this.rbNovember.UseVisualStyleBackColor = true;
            // 
            // rbOctober
            // 
            this.rbOctober.AutoSize = true;
            this.rbOctober.Location = new System.Drawing.Point(10, 82);
            this.rbOctober.Margin = new System.Windows.Forms.Padding(2);
            this.rbOctober.Name = "rbOctober";
            this.rbOctober.Size = new System.Drawing.Size(71, 28);
            this.rbOctober.TabIndex = 9;
            this.rbOctober.Tag = "9";
            this.rbOctober.Text = "10月";
            this.rbOctober.UseVisualStyleBackColor = true;
            // 
            // rbSeptember
            // 
            this.rbSeptember.AutoSize = true;
            this.rbSeptember.Location = new System.Drawing.Point(154, 53);
            this.rbSeptember.Margin = new System.Windows.Forms.Padding(2);
            this.rbSeptember.Name = "rbSeptember";
            this.rbSeptember.Size = new System.Drawing.Size(59, 28);
            this.rbSeptember.TabIndex = 8;
            this.rbSeptember.Tag = "8";
            this.rbSeptember.Text = "9月";
            this.rbSeptember.UseVisualStyleBackColor = true;
            // 
            // rbDecember
            // 
            this.rbDecember.AutoSize = true;
            this.rbDecember.Location = new System.Drawing.Point(154, 82);
            this.rbDecember.Margin = new System.Windows.Forms.Padding(2);
            this.rbDecember.Name = "rbDecember";
            this.rbDecember.Size = new System.Drawing.Size(71, 28);
            this.rbDecember.TabIndex = 11;
            this.rbDecember.Tag = "11";
            this.rbDecember.Text = "12月";
            this.rbDecember.UseVisualStyleBackColor = true;
            // 
            // YearOrMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 363);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.gbRange);
            this.Name = "YearOrMonth";
            this.Text = "範囲選択画面";
            this.Load += new System.EventHandler(this.YearOrMonth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infosys202107DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managesBindingSource)).EndInit();
            this.gbRange.ResumeLayout(false);
            this.gbRange.PerformLayout();
            this.gbMonth.ResumeLayout(false);
            this.gbMonth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private infosys202107DataSet infosys202107DataSet;
        private System.Windows.Forms.BindingSource managesBindingSource;
        private infosys202107DataSetTableAdapters.ManagesTableAdapter managesTableAdapter;
        private infosys202107DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.GroupBox gbRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.RadioButton rbYear;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.GroupBox gbMonth;
        private System.Windows.Forms.RadioButton rbApril;
        private System.Windows.Forms.RadioButton rbFebruary;
        private System.Windows.Forms.RadioButton rbMarch;
        private System.Windows.Forms.RadioButton rbMay;
        private System.Windows.Forms.RadioButton rbJanuary;
        private System.Windows.Forms.RadioButton rbJune;
        private System.Windows.Forms.RadioButton rbAugust;
        private System.Windows.Forms.RadioButton rbJuly;
        private System.Windows.Forms.RadioButton rbNovember;
        private System.Windows.Forms.RadioButton rbOctober;
        private System.Windows.Forms.RadioButton rbSeptember;
        private System.Windows.Forms.RadioButton rbDecember;
    }
}