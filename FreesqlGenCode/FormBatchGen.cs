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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                return Task.FromResult(1);
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
        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectFileButton1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "选择导出文件夹";
            DialogResult rs =  folderBrowserDialog1.ShowDialog();
            if (rs == DialogResult.OK)
            {
                exportFileTextBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        /// <summary>
        /// 导出数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void exportButton2_Click(object sender, EventArgs e)
        {
            if(rightTablesListBox1.Items.Count == 0)
            {
                MessageBox.Show("请选择表");
                return;
            }
            if (string.IsNullOrWhiteSpace(namespaceTextBox1.Text))
            {
                MessageBox.Show("请输入命名空间");
                return;
            }
            if (string.IsNullOrWhiteSpace(saveFileNameTextBox1.Text))
            {
                MessageBox.Show("请输入保存文件名");
                return;
            }
            if (string.IsNullOrWhiteSpace(exportFileTextBox1.Text))
            {
                MessageBox.Show("请选择导出文件夹");
                return;
            }
            List<Template> listTemplate = new List<Template>();
            for (int i = 0; i < templateFlowLayoutPanel1.Controls.Count; i++)
            {
                FsRowCheckBox fsRowCheckBox =  templateFlowLayoutPanel1.Controls[i] as FsRowCheckBox;
                if (fsRowCheckBox.Checked)
                {
                    Template template = new Template();
                    template.TemplateName = fsRowCheckBox.Text;
                    template.TemplatePath = fsRowCheckBox.Tag.ToString();
                    listTemplate.Add(template);
                }
            }
            if(listTemplate.Count == 0)
            {
                MessageBox.Show("请选择模板");
                return;
            }

            List<string> listTableName = new List<string>();
            for (int i = 0; i < rightTablesListBox1.Items.Count; i++)
            {
                listTableName.Add(rightTablesListBox1.Items[i].ToString());
            }

            TreeNode node = this.Tag as TreeNode;
            FsDatabase fsDatabase = node.Tag as FsDatabase;
            string dbName = dbNameLabel3.Text;
            TaskBuild task = ContextUtils.CreateTaskBuild(fsDatabase.DBKey,dbName);
            task.GeneratePath = exportFileTextBox1.Text;
            task.FileName = saveFileNameTextBox1.Text;
            task.tableInfos = task.tableInfos.Where(a => listTableName.Contains(a.Name)).ToList();
            task.FilterTableChar = filterCharTextBox1.Text;
            task.NamespaceName = namespaceTextBox1.Text;
            task.FirstUpper = firstCharCheckBox1.Checked;
            task.AllLower = lowerAllCheckBox1.Checked;
            task.UnderLineTranser = underLineCheckBox1.Checked;
            task.CoverExistFile = coverFileCheckBox1.Checked;
            task.skipSameNameFile = skipSameNameFileCheckBox1.Checked;
            task.Templates = listTemplate;
            //生成代码文件
            try
            {
                await this.ShowLoadingAsync("正在生成代码，请稍后...", (control) =>
                {
                    return new CodeGenerate().Setup(task);
                });
                MessageBox.Show("代码生成成功!");
            }
            catch (Exception)
            {
                MessageBox.Show("生成失败!" + e.ToString());
            }
        }
    }
}
