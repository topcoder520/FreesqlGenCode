using BLL;
using DataDefine;
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
    public partial class FormQueryView : Form
    {
        private readonly BllFsQueryView bllFsQueryView = new BllFsQueryView();

        private string DBKey;

        private string DBName;

        private int QueryViewId;

        public FormQueryView(string DBKey,string DBName,int QueryViewId)
        {
            this.DBKey = DBKey;
            this.DBName = DBName;
            this.QueryViewId = QueryViewId;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            FsQueryView fsQuery = bllFsQueryView.GetModel(QueryViewId);
            if (fsQuery != null)
            {
                this.queryViewNameTextBox1.Text = fsQuery.QueryName;
                this.commentTextBox1.Text = fsQuery.Comment;
            }
        }

        public event EventHandler SaveDataAfterEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(queryViewNameTextBox1.Text.Trim()))
            {
                MessageBox.Show("请填写名称");
                return;
            }
            FsQueryView fsQuery = bllFsQueryView.GetModel(a => a.Id != QueryViewId && a.DBKey == DBKey && a.DBName == DBName && a.QueryName == queryViewNameTextBox1.Text.Trim() && a.State == (int)EnumState.Normal);
            if (fsQuery != null)
            {
                MessageBox.Show("该名称已存在!");
                return;
            }
            if(QueryViewId>0)
            {
                //编辑
                bllFsQueryView.Update((a) => new FsQueryView()
                {
                    QueryName = queryViewNameTextBox1.Text.Trim(),
                    Comment = commentTextBox1.Text.Trim(),
                }, (a)=>a.Id == QueryViewId);
            }
            else
            {
                //添加
                QueryViewId = bllFsQueryView.Add(new FsQueryView() { 
                    QueryName = queryViewNameTextBox1.Text.Trim(),
                    Comment = commentTextBox1.Text.Trim(),
                    DBKey = DBKey,
                    DBName= DBName,
                    State = (int)EnumState.Normal
                });
            }
            
            SaveDataAfterEvent?.Invoke(QueryViewId, EventArgs.Empty);
            this.Close();
        }
    }
}
