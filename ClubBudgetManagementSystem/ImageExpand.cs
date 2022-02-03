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
    public partial class ImageExpand : Form
    {
        private Image _Recipt;
        public ImageExpand(Image recipt)
        {
            InitializeComponent();
            _Recipt = recipt;
        }

        private void ImageExpand_Load(object sender, EventArgs e)
        {
            this.Size = new Size(_Recipt.Width+20, _Recipt.Height+40);
            pbRecipt.Image = _Recipt;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
