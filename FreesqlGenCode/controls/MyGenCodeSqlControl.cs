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
    public partial class MyGenCodeSqlControl : UserControl
    {
        public MyGenCodeSqlControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 保存节点树事件
        /// </summary>
        public event EventHandler SaveViewNodeTreeEvent;

        /// <summary>
        /// 保存 节点树
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FsShowTables fsShowTables = this.fsShowTables1;
            SaveViewNodeTreeEvent?.Invoke(fsShowTables, EventArgs.Empty);
        }
        /// <summary>
        /// 生成sql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FsShowTables fsShowTables = this.fsShowTables1;
            FsTableControl firstTableNode = fsShowTables.GetFirstNode();
            if (firstTableNode == null)
            {
                MessageBox.Show("请添加第一个节点");
                return;
            }
            string sql = fsShowTables.GetSql(firstTableNode);
            FormGenSql genSql = new FormGenSql();
            genSql.Text = "生成SQL";
            genSql.richTextBox1.Text = sql;
            genSql.Show();

        }
    }
}
