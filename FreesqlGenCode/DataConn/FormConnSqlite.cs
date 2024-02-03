using BLL;
using Common;
using Context;
using DataDefine;
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
    public partial class FormConnSqlite : Form
    {
        public FormConnSqlite()
        {
            InitializeComponent();
        }

        private void testConnbutton1_Click(object sender, EventArgs e)
        {
            ValidateForm("test");
        }

        private bool ValidateForm(string typ)
        {
            #region sqlite验证
            if (this.nametextBox1.Text.Length == 0)
            {
                MessageBox.Show("输入连接名称");
                return false;
            }
            if (this.dbfiletextBox2.Text.Length == 0)
            {
                MessageBox.Show("选择数据库文件");
                return false;
            }
            #endregion
            string connectString = ContextUtils.GetSqliteConnectString(this.dbfiletextBox2.Text,passwordtextBox5.Text);
            if (typ == "save")
            {
                //保存
                BllFsDatabase bllFsDatabase = new BllFsDatabase();
                Model.FsDatabase fsDatabase = new Model.FsDatabase()
                {
                    DatabaseName = nametextBox1.Text,
                    ConnectString = connectString,
                    DBType = EnumDatabase.SqlLite.GetDescription(),
                    State = (int)EnumState.Normal
                };
                bllFsDatabase.Add(fsDatabase);
                return true;
            }
            else
            {
                //测试
                string errMsg = "";
                bool successDB = ContextUtils.TestConnectDB(DataDefine.EnumDatabase.SqlLite, connectString, out errMsg);
                if (successDB)
                {
                    MessageBox.Show("Success!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Error! " + errMsg);
                    return false;
                }
            }
        }

        public event EventHandler SaveDataHandler;

        private void savebutton1_Click(object sender, EventArgs e)
        {
            if (ValidateForm("save"))
            {
                SaveDataHandler?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "DB files (*.db)|*.db";
            DialogResult rs =  this.openFileDialog1.ShowDialog();
            if(rs == DialogResult.OK)
            {
                this.dbfiletextBox2.Text =  this.openFileDialog1.FileName;
            }
        }
    }
}
