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
    public partial class FsTableControl : UserControl
    {
        public FsTableControl()
        {
            InitializeComponent();
        }

        public event EventHandler SelectedNoteEvent;

        private void FsTableControl_MouseClick(object sender, MouseEventArgs e)
        {
            SelectedNoteEvent?.Invoke(this, e);
            Common.Console.Log("invoke MOuseclick table");
        }

        public event EventHandler DoubleClickNodeEvent;
        private void tableNameLabel1_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickNodeEvent?.Invoke(this, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
                Color.AliceBlue,1,ButtonBorderStyle.Solid,
                Color.AliceBlue, 1, ButtonBorderStyle.Solid,
                Color.AliceBlue, 1, ButtonBorderStyle.Solid,
                Color.AliceBlue, 1, ButtonBorderStyle.Solid
                );
        }

        private void tableNameLabel1_Enter(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.RoyalBlue;
        }

        private void tableNameLabel1_Leave(object sender, EventArgs e)
        {
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
        }
    }
}
