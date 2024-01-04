using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreesqlGenCode
{
    public partial class FormLoading : Form
    {
        public FormLoading(string text)
        {
            InitializeComponent();
            if(!string.IsNullOrWhiteSpace(text) )
            {
                this.label1.Text = text;
            }
        }
    }
}
