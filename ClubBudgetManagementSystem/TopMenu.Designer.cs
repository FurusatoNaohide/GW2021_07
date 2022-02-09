
namespace ClubBudgetManagementSystem
{
    partial class TopMenu
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
            this.btManage = new System.Windows.Forms.Button();
            this.btRegist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btManage
            // 
            this.btManage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btManage.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btManage.Location = new System.Drawing.Point(101, 165);
            this.btManage.Name = "btManage";
            this.btManage.Size = new System.Drawing.Size(152, 67);
            this.btManage.TabIndex = 13;
            this.btManage.Text = "管理用";
            this.btManage.UseVisualStyleBackColor = true;
            this.btManage.Click += new System.EventHandler(this.btManage_Click);
            // 
            // btRegist
            // 
            this.btRegist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRegist.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRegist.Location = new System.Drawing.Point(101, 75);
            this.btRegist.Name = "btRegist";
            this.btRegist.Size = new System.Drawing.Size(152, 67);
            this.btRegist.TabIndex = 12;
            this.btRegist.Text = "提出用";
            this.btRegist.UseVisualStyleBackColor = true;
            this.btRegist.Click += new System.EventHandler(this.btRegist_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(86, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "部費管理システム";
            // 
            // TopMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 254);
            this.Controls.Add(this.btManage);
            this.Controls.Add(this.btRegist);
            this.Controls.Add(this.label1);
            this.Name = "TopMenu";
            this.Text = "トップメニュー";
            this.Load += new System.EventHandler(this.TopMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btManage;
        private System.Windows.Forms.Button btRegist;
        private System.Windows.Forms.Label label1;
    }
}