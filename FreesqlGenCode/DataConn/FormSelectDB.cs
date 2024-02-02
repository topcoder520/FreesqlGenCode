using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreesqlGenCode.DataConn
{
    public partial class FormSelectDB : Form
    {
        public FormSelectDB()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> SelectDBChanged;

        /// <summary>
        /// 选择数据库 创建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (mysqlRadioButton1.Checked)
            {
                SelectDBChanged?.Invoke("mysql", EventArgs.Empty);
            }
            else if(sqlserverRadioButton1.Checked)
            {
                SelectDBChanged?.Invoke("sqlserver", EventArgs.Empty);
            }
            else if (sqliteRadioButton2.Checked)
            {
                SelectDBChanged?.Invoke("sqlite", EventArgs.Empty);
            }
            else if(owndefineRadioButton3.Checked)
            {
                SelectDBChanged?.Invoke("other", EventArgs.Empty);
            }
        }
    }
}
