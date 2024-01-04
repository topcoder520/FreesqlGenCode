using Context;
using DataDefine;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreesqlGenCode.controls
{
    public partial class MySingleControl: UserControl
    {
        public MySingleControl() {
            InitializeComponent();
            InitTemplateComboBox();
        }

        private void InitTemplateComboBox()
        {
            string[] listname = listFileInfo.Select(a => a.Name).ToArray();
            if (listname.Length > 0)
            {
                selectTempleteComboBox1.Items.AddRange(listname.ToArray());
                this.selectTempleteComboBox1.SelectedItem = this.selectTempleteComboBox1.Items[0];
                string htmlTemplate = File.ReadAllText(listFileInfo[0].FullName);
                this.genCodeRichTextBox1.Text = htmlTemplate;
            }
        }

        public static List<FileInfo> listFileInfo;

        /// <summary>
        /// 选择模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectTempleteComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = selectTempleteComboBox1.SelectedItem as string;
            FileInfo fileInfo = listFileInfo.Where(a => a.Name == fileName).FirstOrDefault();
            if (fileInfo != null)
            {
                string htmlTemplate = File.ReadAllText(fileInfo.FullName);
                this.genCodeRichTextBox1.Text = htmlTemplate;
            }
        }

        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genCodeButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namespaceText.Text))
            {
                MessageBox.Show("请输入命名空间");
                return;
            }
            if (listFileInfo.Count == 0)
            {
                MessageBox.Show("请选择模板");
                return;
            }
            if(this.Parent is not TabPage tabPage)
            {
                MessageBox.Show("系统错误!");
                return;
            }
            TabPageTag tag = tabPage.Tag as TabPageTag;
            FsDatabase database = tag.fsDatabase;
            TaskBuild task = ContextUtils.CreateTaskBuild(database.DBKey, tag.treeNodeTableNode.Parent.Text);
            task.tableName = tag.treeNodeTableNode.Text;
            task.FileName = selectTempleteComboBox1.SelectedText;
            task.NamespaceName = namespaceText.Text;
            task.FilterTableChar = filterTablenameText.Text;
            task.FirstUpper = firstCharUpperCheckBox1.Checked;
            task.AllLower = allLowerCheckBox1.Checked;
            task.UnderLineTranser = underLineToCheckBox2.Checked;
            task.Templates = new Template[] { new Template() {
                TemplatePath = selectTempleteComboBox1.SelectedItem as string,
                TemplateText = genCodeRichTextBox1.Text,
                IsChangeText = false,
            } };
            FormShowGenCode formShowGenCode = new FormShowGenCode(listFileInfo, task);
            DialogResult rs = formShowGenCode.ShowDialog();
            if (rs == DialogResult.OK)
            {

            }
        }

    }
}
