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
    }
}
