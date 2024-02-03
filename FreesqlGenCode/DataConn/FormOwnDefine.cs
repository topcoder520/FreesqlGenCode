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
    public partial class FormOwnDefine : Form
    {
        public FormOwnDefine()
        {
            InitializeComponent();
        }

        private bool ValidateForm(string typ)
        {
            #region sqlite验证
            if (this.nametextBox1.Text.Length == 0)
            {
                MessageBox.Show("输入连接名称");
                return false;
            }
            if (this.connectstringtextBox1.Text.Length == 0)
            {
                MessageBox.Show("输入数据库连接串");
                return false;
            }
            #endregion
            EnumDatabase dbType = EnumDatabase.Mysql;
            if (this.mysqlradioButton1.Checked)
            {
                dbType = EnumDatabase.Mysql;
            }else if(this.sqlserverradioButton2.Checked)
            {
                dbType = EnumDatabase.Sqlserver;
            }else if (this.sqliteradioButton3.Checked)
            {
                dbType = EnumDatabase.SqlLite;
            }
            string connectString = this.connectstringtextBox1.Text.Trim();
            if (typ == "save")
            {
                //保存
                BllFsDatabase bllFsDatabase = new BllFsDatabase();
                Model.FsDatabase fsDatabase = new Model.FsDatabase()
                {
                    DatabaseName = nametextBox1.Text,
                    ConnectString = connectString,
                    DBType = dbType.GetDescription(),
                    State = (int)EnumState.Normal
                };
                bllFsDatabase.Add(fsDatabase);
                return true;
            }
            else
            {
                //测试
                string errMsg = "";
                bool successDB = ContextUtils.TestConnectDB(dbType, connectString, out errMsg);
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

        private void testbutton1_Click(object sender, EventArgs e)
        {
            ValidateForm("test");
        }

        private void savebutton2_Click(object sender, EventArgs e)
        {
            if (ValidateForm("save"))
            {
                SaveDataHandler?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }
    }
}
