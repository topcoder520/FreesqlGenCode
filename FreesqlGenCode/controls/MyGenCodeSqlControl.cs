using Context;
using Model;
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
            this.fsShowTables1.ShowTablesChanged += new EventHandler((sender,e) =>
            {
                this.button1.BackColor= System.Drawing.Color.CornflowerBlue;
                this.button1.Enabled = true;
            });
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshDataOfQueryViewListBoxEvent?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// 选择的视图
        /// </summary>
        public int SelectedQueryViewId;

        /// <summary>
        /// 保存节点树事件
        /// </summary>
        public event EventHandler SaveViewNodeTreeEvent;

        public event EventHandler RefreshDataOfQueryViewListBoxEvent;

        /// <summary>
        /// 保存 节点树
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(SelectedQueryViewId == 0)
            {
                FsShowTables fsShowTables = this.fsShowTables1;
                TreeNode node = fsShowTables.Tag as TreeNode;
                FsDatabase fsDatabase = (FsDatabase)node.Tag;
                TreeNode parentNode = node.Parent;
                FormQueryView formQuery = new FormQueryView(fsDatabase.DBKey, parentNode.Text, SelectedQueryViewId);
                formQuery.SaveDataAfterEvent += (object? sender, EventArgs e) => {
                    //SelectedQueryViewId = (int)sender;
                    SaveViewNodeTreeEvent?.Invoke(sender,e);
                    fsShowTables.ClearNodes();
                };
                formQuery.Text = "我的查询";
                formQuery.ShowDialog();
                RefreshDataOfQueryViewListBoxEvent?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                SaveViewNodeTreeEvent?.Invoke(SelectedQueryViewId, e);
            }
            this.button1.BackColor = Color.Gray;
            this.button1.Enabled= false;
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
                MessageBox.Show("请添加节点");
                return;
            }
            
            //找出所有查询的字段
            List<string> lstQueryField = new List<string>();
            fsShowTables.GetQueryFieldOfChildNodes(lstQueryField,firstTableNode);

            TreeNode node = fsShowTables.Tag as TreeNode;
            FsDatabase fsDatabase = (FsDatabase)node.Tag;
            DBConnect dBConnect = ContextUtils.GetDBConnect(fsDatabase.DBKey);
            if (!dBConnect.TestConnect())
            {
                MessageBox.Show("数据库连接无效!");
                return;
            }
            string sql = fsShowTables.GetSql(firstTableNode,dBConnect.DataType);

            FormGenSql genSql = new FormGenSql();
            genSql.Text = "生成SQL";
            genSql.richTextBox1.Text = sql;
            genSql.lstQueryField = lstQueryField;
            genSql.Tag = fsDatabase;
            genSql.Show();

        }

        public event Func<string, int> SelectedQueryItemEvent;

        /// <summary>
        /// 选择查询view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void queryViewListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.queryViewListBox1.SelectedItem != null)
            {
                string selectedItemText = this.queryViewListBox1.SelectedItem.ToString();
                int? value = SelectedQueryItemEvent?.Invoke(selectedItemText);
                if (value.HasValue)
                {
                    SelectedQueryViewId = value.Value;
                }
            }
        }

        public event EventHandler DelQueryViewEvent;
        /// <summary>
        /// 删除QueryView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            if(SelectedQueryViewId== 0)
            {
                MessageBox.Show("请选择查询");
                return;
            }
            DialogResult rs = MessageBox.Show("确定删除该查询?","提示",MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                DelQueryViewEvent?.Invoke(SelectedQueryViewId,EventArgs.Empty);
                SelectedQueryViewId = 0;
            }
        }
        /// <summary>
        /// 编辑QueryView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditQueryViewLabel1_Click(object sender, EventArgs e)
        {
            if(SelectedQueryViewId == 0)
            {
                MessageBox.Show("请选择查询");
                return;
            }
            FsShowTables fsShowTables = this.fsShowTables1;
            TreeNode node = fsShowTables.Tag as TreeNode;
            FsDatabase fsDatabase = (FsDatabase)node.Tag;
            TreeNode parentNode = node.Parent;
            FormQueryView formQuery = new FormQueryView(fsDatabase.DBKey, parentNode.Text, SelectedQueryViewId);
            formQuery.Text = "我的查询";
            formQuery.ShowDialog();
            RefreshDataOfQueryViewListBoxEvent?.Invoke(this,e);
            this.fsShowTables1.ClearNodes();
            SelectedQueryViewId = 0;
        }
    }
}
