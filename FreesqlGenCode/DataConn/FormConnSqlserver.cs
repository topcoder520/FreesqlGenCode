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
    public partial class FormConnSqlserver : Form
    {
        public FormConnSqlserver()
        {
            InitializeComponent();
            this.comboBox1.SelectedItem = this.comboBox1.Items[0];
        }

        private void testConnbutton1_Click(object sender, EventArgs e)
        {
            ValidateForm("test");
        }

        private bool ValidateForm(string typ)
        {
            #region sqlserver验证
            if (this.nametextBox1.Text.Length == 0)
            {
                MessageBox.Show("输入连接名称");
                return false;
            }
            if (this.hosttextBox2.Text.Length == 0)
            {
                MessageBox.Show("输入主机");
                return false;
            }
            if (this.usernametextBox4.Text.Length == 0)
            {
                MessageBox.Show("输入用户名");
                return false;
            }
            if (this.passwordtextBox5.Text.Length == 0)
            {
                MessageBox.Show("输入密码");
                return false;
            }
            #endregion
            string connectString = ContextUtils.GetMysqlConnectString(hosttextBox2.Text, "", usernametextBox4.Text, passwordtextBox5.Text);
            if (typ == "save")
            {
                //保存
                BllFsDatabase bllFsDatabase = new BllFsDatabase();
                Model.FsDatabase fsDatabase = new Model.FsDatabase()
                {
                    DatabaseName = nametextBox1.Text,
                    ConnectString = connectString,
                    DBType = EnumDatabase.Mysql.GetDescription(),
                    State = (int)EnumState.Normal
                };
                bllFsDatabase.Add(fsDatabase);
                return true;
            }
            else
            {
                //测试
                string errMsg = "";
                bool successDB = ContextUtils.TestConnectDB(DataDefine.EnumDatabase.Mysql, connectString, out errMsg);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox1.SelectedIndex == 0)
            {
                usernamelabel4.Visible = true;
                usernametextBox4.Visible = true;
                passwordlabel5.Visible = true;
                passwordtextBox5.Visible = true;
            }
            else
            {
                usernamelabel4.Visible = false;
                usernametextBox4.Visible = false;
                passwordlabel5.Visible = false;
                passwordtextBox5.Visible = false;
            }
        }
    }
}
