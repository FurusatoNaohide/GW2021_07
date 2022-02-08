
namespace ClubBudgetManagementSystem
{
    partial class Mmenu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btPresenterRegister = new System.Windows.Forms.Button();
            this.btCostNameRegister = new System.Windows.Forms.Button();
            this.btClubRegister = new System.Windows.Forms.Button();
            this.btManage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPresenterRegister
            // 
            this.btPresenterRegister.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPresenterRegister.Location = new System.Drawing.Point(229, 61);
            this.btPresenterRegister.Name = "btPresenterRegister";
            this.btPresenterRegister.Size = new System.Drawing.Size(162, 67);
            this.btPresenterRegister.TabIndex = 10;
            this.btPresenterRegister.Text = "提出者登録";
            this.btPresenterRegister.UseVisualStyleBackColor = true;
            this.btPresenterRegister.Click += new System.EventHandler(this.btPresenterRegister_Click);
            // 
            // btCostNameRegister
            // 
            this.btCostNameRegister.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCostNameRegister.Location = new System.Drawing.Point(38, 144);
            this.btCostNameRegister.Name = "btCostNameRegister";
            this.btCostNameRegister.Size = new System.Drawing.Size(162, 67);
            this.btCostNameRegister.TabIndex = 9;
            this.btCostNameRegister.Text = "費用名登録";
            this.btCostNameRegister.UseVisualStyleBackColor = true;
            this.btCostNameRegister.Click += new System.EventHandler(this.btCostNameRegister_Click);
            // 
            // btClubRegister
            // 
            this.btClubRegister.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClubRegister.Location = new System.Drawing.Point(38, 61);
            this.btClubRegister.Name = "btClubRegister";
            this.btClubRegister.Size = new System.Drawing.Size(162, 67);
            this.btClubRegister.TabIndex = 8;
            this.btClubRegister.Text = "部活動登録";
            this.btClubRegister.UseVisualStyleBackColor = true;
            this.btClubRegister.Click += new System.EventHandler(this.btClubRegister_Click);
            // 
            // btManage
            // 
            this.btManage.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btManage.Location = new System.Drawing.Point(229, 144);
            this.btManage.Name = "btManage";
            this.btManage.Size = new System.Drawing.Size(162, 67);
            this.btManage.TabIndex = 7;
            this.btManage.Text = "決算管理";
            this.btManage.UseVisualStyleBackColor = true;
            this.btManage.Click += new System.EventHandler(this.btManage_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "部費管理システム　管理用";
            // 
            // Mmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 233);
            this.Controls.Add(this.btPresenterRegister);
            this.Controls.Add(this.btCostNameRegister);
            this.Controls.Add(this.btClubRegister);
            this.Controls.Add(this.btManage);
            this.Controls.Add(this.label1);
            this.Name = "Mmenu";
            this.Text = "管理者用画面";
            this.Load += new System.EventHandler(this.Mmenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPresenterRegister;
        private System.Windows.Forms.Button btCostNameRegister;
        private System.Windows.Forms.Button btClubRegister;
        private System.Windows.Forms.Button btManage;
        private System.Windows.Forms.Label label1;
    }
}

