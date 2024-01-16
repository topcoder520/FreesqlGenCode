using Context;
using FreesqlGenCode.controls;
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
    public partial class FormSelectTableColumns : Form
    {
        public FormSelectTableColumns()
        {
            InitializeComponent();
        }
        private string DBKey;
        private string DataBase;
        private string SelectedFieldName;
        private string TableName;
        private string TableAliasName;

        public FormSelectTableColumns(string DBKey, string DataBase, string SelectedFieldName,string TableAliasName)
        {
            this.DBKey = DBKey;
            this.DataBase = DataBase;
            InitializeComponent();
            this.SelectedFieldName = SelectedFieldName;
            this.TableAliasName = TableAliasName;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            FsTableControl fsTable = this.Tag as FsTableControl;    
            if (fsTable != null)
            {
                FsLine fsLine = fsTable.Tag as FsLine;
                if (fsLine != null)
                {
                    TableName = fsLine.GetEndTableName();
                }
                this.flowLayoutPanel1.Controls.Clear();
                if (fsTable.NextNodeList.Count > 0)
                {
                    foreach(FsTableControl node in fsTable.NextNodeList)
                    {
                        FsLine line = node.Tag as FsLine;
                        if(line.Flag == 1)
                        {
                            JoinTableColumnRow row = GetColumnRow(line);
                            this.flowLayoutPanel1.Controls.Add(row);
                        }
                    }
                    foreach (FsTableControl node in fsTable.PreNextNodeList)
                    {
                        FsLine line = node.Tag as FsLine;
                        if (line.Flag == 1)
                        {
                            JoinTableColumnRow row = GetColumnRow(line);
                            this.flowLayoutPanel1.Controls.Add(row);
                        }
                    }
                }
            }
            if (!string.IsNullOrEmpty(DBKey) && !string.IsNullOrEmpty(DataBase) )
            {
                DBConnect dBConnect = ContextUtils.GetDBConnect(DBKey);
                if (dBConnect.TestConnect())
                {
                    await this.ShowLoadingAsync("正在加载数据...", (control) =>
                    {
                        List<string> listDatabase = dBConnect.GetTableNamesBy(DataBase);
                        control.Invoke(() =>
                        {
                            tableListBox1.Items.AddRange(listDatabase.ToArray());
                        });
                        return Task.CompletedTask;
                    });
                }
            }

        }
        /// <summary>
        /// 选择表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void tableListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = tableListBox1.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(tableName))
            {
                tableNameLabel2.Text = tableName;
                aliasTextBox1.Text = "";
                columnLabel4.Text = "";
                if (!string.IsNullOrEmpty(DBKey) && !string.IsNullOrEmpty(DataBase))
                {
                    DBConnect dBConnect = ContextUtils.GetDBConnect(DBKey);
                    await this.ShowLoadingAsync("加载数据中...", (control) =>
                    {
                        List<string> listCol =  dBConnect.GetColNameList(DataBase+"."+tableName);
                        control.Invoke(() =>
                        {
                            columnListBox1.Items.Clear();
                            columnListBox1.Items.AddRange(listCol.ToArray());
                        });
                        return Task.CompletedTask;
                    });
                }
            }
        }
        /// <summary>
        /// 选择字段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void columnListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columnName = columnListBox1.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(columnName))
            {
                columnLabel4.Text = columnName;
            }
        }
        /// <summary>
        /// 确定 增加关联外键记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tableNameLabel2.Text))
            {
                MessageBox.Show("请选择表");
                return;
            }
            if (string.IsNullOrWhiteSpace(columnLabel4.Text))
            {
                MessageBox.Show("请选择表字段");
                return;
            }

            FsLine fsLine = new FsLine();
            fsLine.StartTable = TableName;
            fsLine.StartTableAlias = TableAliasName;
            fsLine.StartColumn = SelectedFieldName;
            fsLine.EndTable = DataBase+"."+tableNameLabel2.Text;
            fsLine.EndTableAlias = aliasTextBox1.Text;
            fsLine.EndColumn = columnLabel4.Text;
            fsLine.JoinType = EnumJoinType.LeftJoin;
            JoinTableColumnRow row = GetColumnRow(fsLine);
            this.flowLayoutPanel1.Controls.Add(row);

            columnListBox1.Items.Clear();
            tableNameLabel2.Text = "";
            aliasTextBox1.Text = "";
            columnLabel4.Text = "";
        }

        private void DelColRow(object? sender,EventArgs e)
        {
            if(sender != null)
            {
                JoinTableColumnRow row = sender as JoinTableColumnRow;
                FsLine fsLine = (FsLine)row.Tag;
                if (fsLine != null)
                {
                    if (fsLine.Node != null)
                    {
                        fsLinesDel.Add(fsLine);
                    }
                }
                this.flowLayoutPanel1.Controls.Remove(row);
            }
        }

        private JoinTableColumnRow GetColumnRow(FsLine fsLine)
        {
            JoinTableColumnRow row = new JoinTableColumnRow();
            row.Tag = fsLine;
            row.BackColor = System.Drawing.SystemColors.Control;
            row.Name = "joinTableColumnRow_" + fsLine.EndTable + "." + fsLine.EndColumn;
            row.Size = new System.Drawing.Size(949, 90);
            row.TabIndex = 0;
            row.DelRowEvent += new EventHandler(DelColRow);
            return row;
        }

        private List<FsLine> fsLinesDel = new List<FsLine>();

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (fsLinesDel.Count > 0)
            {
                for (int i = 0; i < fsLinesDel.Count; i++)
                {
                    fsLinesDel[i].Flag = 0;
                }
            }
            int cnt =  this.flowLayoutPanel1.Controls.Count;
            if(cnt > 0)
            {
                for (int i = 0; i < cnt; i++)
                {
                    JoinTableColumnRow row = (JoinTableColumnRow)this.flowLayoutPanel1.Controls[i];
                    if(row !=null)
                    {
                        FsLine fsLine = row.Tag as FsLine;
                        if(fsLine.Node != null)
                        {
                            row.SyncInfo();
                        }
                        else
                        {
                            CreateTableComtrol(fsLine);
                        }
                    }
                }
            }
            this.Close();
        }
        /// <summary>
        /// 创建一个孤立的节点
        /// </summary>
        /// <param name="fsLine"></param>
        /// <returns></returns>
        public void CreateTableComtrol(FsLine fsLine)
        {
            FsTableControl fsTable = this.Tag as FsTableControl;

            FsTableControl nextNode = new FsTableControl();
            nextNode.Text = fsLine.EndTable;
            nextNode.Col = fsTable.Col+1;
            //nextNode.PrevNode = fsTable;
            nextNode.Tag = fsLine;
            fsLine.Node = nextNode;
            //fsTable.NextNodeList.Add(nextNode);
            fsTable.PreNextNodeList.Add(nextNode);
        }
    }
}
