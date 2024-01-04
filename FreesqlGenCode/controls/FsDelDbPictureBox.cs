using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreesqlGenCode.controls
{
    public partial class FsDelDbPictureBox : UserControl
    {
        public FsDelDbPictureBox()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FsClick?.Invoke(this, e); 
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = FsHoverBackColor;
            this.BackColor= FsHoverBackColor;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = FsLeaveBackColor;
            this.BackColor = FsLeaveBackColor;
        }
    }
}
