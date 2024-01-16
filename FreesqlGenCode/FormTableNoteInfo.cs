using Context;
using FreesqlGenCode.controls;
using MySqlX.XDevAPI.Relational;
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
    public partial class FormTableNoteInfo : Form
    {
        public FormTableNoteInfo()
        {
            InitializeComponent();
        }

        private string DBKey;

        private string Database;

        private string TableName;

        public FormTableNoteInfo(string DBKey,string Database,string tableName)
        {
            InitializeComponent();
            this.DBKey= DBKey;
            this.Database= Database;
            this.TableName = tableName;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            FsTableControl fsTable = this.Tag as FsTableControl;
            fsTable.PreNextNodeList.Clear();
            FsLine fsLine = fsTable.Tag as FsLine;
            if (fsLine != null)
            {
                aliasTextBox1.Text = fsLine.EndTableAlias;
            }
            DBConnect dBConnect = ContextUtils.GetDBConnect(DBKey);
            if (dBConnect != null && dBConnect.TestConnect())
            {
                await this.ShowLoadingAsync("正在加载数据...", (control) =>
                {
                    List<List<string>> lstCol = dBConnect.GetColInfos(TableName);
                    List<string> queryFields = fsTable.QueryFields;
                    List<FsTableControl> childNotes = fsTable.NextNodeList;
                    control.Invoke(() =>
                    {
                        foreach (List<string> colInfo in lstCol)
                        {
                            string joinInfo = string.Empty;
                            if (childNotes.Count > 0)
                            {
                                foreach (FsTableControl node in childNotes)
                                {
                                    FsLine line = node.Tag as FsLine;
                                    line.Flag = 1;
                                    if (line.StartColumn == colInfo[0])
                                    {
                                        joinInfo += line.GetSimpleString();
                                    }
                                }
                            }
                            bool isChecked = queryFields.Contains(colInfo[0]);
                            dataGridView1.Rows.Add(new object[] { colInfo[0], colInfo[4], colInfo[9], isChecked, joinInfo});
                        }
                    });
                    return Task.CompletedTask;
                });
            }
            else
            {
                MessageBox.Show("连接失败!"+dBConnect.GetException());
            }
        }

        private void saveTableAlias()
        {
            string alias = aliasTextBox1.Text.Trim();
            FsTableControl fsTable = this.Tag as FsTableControl;
            if (fsTable != null)
            {
                FsLine fsLine = fsTable.Tag as FsLine;  
                if (fsLine != null)
                {
                    fsLine.EndTableAlias = alias;
                }
                List<FsTableControl> nextNodes = fsTable.NextNodeList;
                if(nextNodes.Count > 0)
                {
                    foreach(FsTableControl note in nextNodes)
                    {
                        FsLine line = note.Tag as FsLine;
                        if (line != null)
                        {
                            line.StartTableAlias= alias;
                        }
                    }
                }
                List<FsTableControl> preNextNodes = fsTable.PreNextNodeList;
                if (preNextNodes.Count > 0)
                {
                    foreach (FsTableControl note in preNextNodes)
                    {
                        FsLine line = note.Tag as FsLine;
                        if (line != null)
                        {
                            line.StartTableAlias = alias;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 点击单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "selectForeign")
            {//点击设置
                string fieldNameCell = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //MessageBox.Show(fieldNameCell.ToString());
                string TableNameAlias = aliasTextBox1.Text.Trim();
                FormSelectTableColumns formSelectTable = new FormSelectTableColumns(DBKey, Database, fieldNameCell, TableNameAlias);
                formSelectTable.Text = "选择外键字段";
                formSelectTable.Tag = this.Tag;
                formSelectTable.ShowDialog();
            }else if(dataGridView1.Columns[e.ColumnIndex].Name == "IsShowQuery")
            {//点击checkbox
                
            }
        }
        /// <summary>
        /// 全部查询 点击选择所有字段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void allCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            int cnt = dataGridView1.Rows.Count;
            for (int i = 0; i < cnt; i++)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[3];
                cell.Value = allCheckBox1.Checked;
            }
        }

        public event EventHandler AddNodeEvent;

        public event EventHandler RemoveNodeEvent;

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click(object sender, EventArgs e)
        {
            await this.ShowLoadingAsync("正在保存...", async (control) =>
            {
                control.Invoke(() =>
                {
                    List<string> queryFields = new List<string>();
                    int cnt = dataGridView1.Rows.Count;
                    for (int i = 0; i < cnt; i++)
                    {
                        DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[3];
                        if (cell.Value != null && cell.Value.ToString().ToLower() == "true")
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value != null)
                            {
                                queryFields.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                            }
                        }
                    }
                    FsTableControl fsTable = this.Tag as FsTableControl;
                    fsTable.QueryFields = queryFields;

                    saveTableAlias();

                    List<FsTableControl> nextNodes = fsTable.NextNodeList;
                    foreach (FsTableControl node in nextNodes)
                    {
                        FsLine fsLine = node.Tag as FsLine;
                        if (fsLine.Flag == 0)
                        {
                            RemoveNodeEvent?.Invoke(node, e);
                        }
                    }
                    List<FsTableControl> preNextNodes = fsTable.PreNextNodeList;
                    foreach (FsTableControl node in preNextNodes)
                    {
                        FsLine fsLine = (FsLine)node.Tag;
                        if (fsLine.Flag == 1)
                        {
                            node.PrevNode = fsTable;
                            node.PrevNode.NextNodeList.Add(node);
                            AddNodeEvent?.Invoke(node, e);
                        }
                    }
                });
            });
            this.Close();
        }
    }
}
