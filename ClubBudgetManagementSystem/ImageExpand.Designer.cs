
namespace ClubBudgetManagementSystem
{
    partial class ImageExpand
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
            this.pbRecipt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipt)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRecipt
            // 
            this.pbRecipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRecipt.Location = new System.Drawing.Point(0, 0);
            this.pbRecipt.Name = "pbRecipt";
            this.pbRecipt.Size = new System.Drawing.Size(417, 464);
            this.pbRecipt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRecipt.TabIndex = 0;
            this.pbRecipt.TabStop = false;
            // 
            // ImageExpand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 464);
            this.Controls.Add(this.pbRecipt);
            this.Name = "ImageExpand";
            this.Text = "ImageExpand";
            this.Load += new System.EventHandler(this.ImageExpand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRecipt;
    }
}