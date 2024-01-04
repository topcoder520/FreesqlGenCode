using Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Model;
using FreeSql.Internal.Model;

namespace FreesqlGenCode
{
    public partial class FormShowGenCode : Form
    {
        public FormShowGenCode()
        {
            InitializeComponent();
        }

        private List<FileInfo> listFileInfo = new List<FileInfo>();


        private TaskBuild task;

        public FormShowGenCode(List<FileInfo> fileInfos, TaskBuild taskBuild)
        {
            listFileInfo = fileInfos;
            task= taskBuild;
            InitializeComponent();
            this.tabPageModel1.Text = taskBuild.tableName;
            InitGencode();
        }

        private async void InitGencode()
        {
            FormLoading frmLoading = null;
            ThreadPool.QueueUserWorkItem(new WaitCallback(a =>
            {
                if (this.modelRichTextBox1.InvokeRequired)
                {
                    this.modelRichTextBox1.Invoke((Action)delegate ()
                    {
                        frmLoading = new FormLoading("正在生成中，请稍后.....");
                        frmLoading.ShowDialog();
                    });
                }
                else
                {
                    frmLoading = new FormLoading("正在生成中，请稍后.....");
                    frmLoading.ShowDialog();
                }
                
            }));
            try
            {
                List<string> listCodeText = await new CodeGenerate().Setup(task, task.tableName);
                if (listCodeText.Count > 0)
                {
                    if (this.modelRichTextBox1.InvokeRequired)
                    {
                        this.modelRichTextBox1.Invoke(new Action(() =>
                        {
                            this.modelRichTextBox1.Text = listCodeText[0];
                        }));
                    }
                    else
                    {
                        this.modelRichTextBox1.Text = listCodeText[0];
                    }
                }

            }
            catch (Exception e)
            {
                this.Invoke(() => {
                    MessageBox.Show("代码生成失败!" + e.ToString());
                });
            }
            this.Invoke((Action)delegate () { frmLoading?.Close(); });
        }

    }
}
