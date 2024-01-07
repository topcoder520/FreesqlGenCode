using Common;
using Context;
using FreesqlGenCode.controls;
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

namespace FreesqlGenCode
{
    public partial class FormBatchGen : Form
    {
        public FormBatchGen()
        {
            InitializeComponent();
        }

        private void FormBatchGen_Load(object sender, EventArgs e)
        {
            string dbName = dbNameLabel3.Text;
            TreeNode node = this.Tag as TreeNode;
            FsDatabase fsDatabase = node.Tag as FsDatabase;
            this.ShowLoadingAsync("正在加载数据...", (control) =>
            {
                DBConnect dBConnect = Context.ContextUtils.GetDBConnect(fsDatabase.DBKey);
                List<string> listTable = dBConnect.GetTableNamesBy(dbName);
                control.Invoke(() =>
                {
                    this.leftTablesListBox1.BeginUpdate();
                    this.leftTablesListBox1.Items.Clear();
                    for (int i = 0; i < listTable.Count; i++)
                    {
                        this.leftTablesListBox1.Items.Add(listTable[i]);
                    }
                    this.leftTablesListBox1.EndUpdate();

                    FileInfo[] fileInfos = FileUtil.loadTemplates("");
                    templateFlowLayoutPanel1.Controls.Clear();
                    if (fileInfos.Length > 0)
                    {
                        for (int i = 0; i < fileInfos.Length; i++)
                        {
                            FsRowCheckBox fsRowCheckBox = new FsRowCheckBox();
                            fsRowCheckBox.Text = fileInfos[i].Name;
                            fsRowCheckBox.Tag = fileInfos[i].FullName;
                            fsRowCheckBox.Size = new Size(430,38);
                            templateFlowLayoutPanel1.Controls.Add(fsRowCheckBox);
                        }
                    }

                });
                return Task.CompletedTask;
            });
        }
        /// <summary>
        /// 双击左listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leftTablesListBox1_DoubleClick(object sender, EventArgs e)
        {
            string tableName =  (string)leftTablesListBox1.SelectedItem;
            if(!string.IsNullOrWhiteSpace(tableName))
            {
                if (!rightTablesListBox1.Items.Contains(tableName))
                {
                    rightTablesListBox1.Items.Add(tableName);
                }
                else
                {
                    MessageBox.Show("选择表重复！");
                }
            }
        }
        /// <summary>
        /// 选择表 全部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightAllButton1_Click(object sender, EventArgs e)
        {
            rightTablesListBox1.Items.Clear();
            rightTablesListBox1.Items.AddRange(leftTablesListBox1.Items);
        }
        /// <summary>
        /// 右边listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightTablesListBox1_DoubleClick(object sender, EventArgs e)
        {
            string tableName = (string)rightTablesListBox1.SelectedItem;
            if (!string.IsNullOrWhiteSpace(tableName))
            {
                rightTablesListBox1.Items.Remove(tableName);
            }
        }
        /// <summary>
        /// 右边listbox 全部移出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leftAllButton1_Click(object sender, EventArgs e)
        {
            rightTablesListBox1.Items.Clear();
        }
    }
}
