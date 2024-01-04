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
    public partial class FsAddDbPictureBox : UserControl
    {
        public FsAddDbPictureBox()
        {
            InitializeComponent();

        }

        private void AddDBPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("MOuseup");
            this.AddDBPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        private void AddDBPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mousemove");
            this.AddDBPictureBox.BackColor = Color.White;
        }
        /// <summary>
        /// 点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDBPictureBox_Click(object sender, EventArgs e)
        {
            FsClick?.Invoke(this, e);
        }
        /// <summary>
        /// MouseEnter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDBPictureBox_MouseHover(object sender, EventArgs e)
        {
            AddDBPictureBox.BackColor = FsHoverBackColor;
            this.BackColor = FsHoverBackColor;
        }
        /// <summary>
        /// MouseLeave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDBPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddDBPictureBox.BackColor = FsLeaveBackColor;
            this.BackColor = FsLeaveBackColor;
        }
    }
}
