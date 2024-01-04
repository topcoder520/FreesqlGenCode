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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreesqlGenCode
{
    public partial class FormCreateDataConnect : Form
    {
        public FormCreateDataConnect()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            this.mysqlRadioButton1.Checked= true;
            if(this.mysqlRadioButton1.Checked )
            {
                mysqlPortTextBox3.Text = "3306";
                mysqlHostTextBox2.Text = "localhost";
                mysqlUsernametextBox4.Text = "root";
            }
            nextAndHiddenConfigConnectGroupBox(false);

        }
        /// <summary>
        /// 按钮和组件是否显示
        /// </summary>
        /// <param name="isNext"></param>
        private void nextAndHiddenConfigConnectGroupBox(bool isNext)
        {
            
            #region 选择数据库类型
            this.nextButton1.Visible = !isNext;
            this.preButton2.Visible = isNext;
            this.testConButton3.Visible = isNext;
            this.saveButton1.Visible = isNext;


            if (isNext)
            {
                this.selectTypeGroupBox.Visible = false;
            }
            else
            {
                this.selectTypeGroupBox.Visible = true;
            }
            #endregion

            #region 配置数据库连接 GroupBox
            //mysql
            if (mysqlRadioButton1.Checked && isNext)
            {

                mysqlConfigConnectGroupBox1.Visible = true;
                Common.Console.Log("show mysql config");
            }
            else
            {
                Common.Console.Log("hidden mysql config");
                mysqlConfigConnectGroupBox1.Visible = false;
            }
            //sqlserver

            #endregion


        }

        private void nextButton1_Click(object sender, EventArgs e)
        {
            nextAndHiddenConfigConnectGroupBox(true);
        }

        private void preButton2_Click(object sender, EventArgs e)
        {
            nextAndHiddenConfigConnectGroupBox(false);
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton1_Click(object sender, EventArgs e)
        {
            ValidateForm("save");
        }

        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testConButton3_Click(object sender, EventArgs e)
        {
            ValidateForm("test");
        }


        private bool ValidateForm(string typ)
        {
            if(mysqlRadioButton1.Checked)
            {
                #region mysql验证
                if (this.mysqlConnectNameTextBox1.Text.Length == 0)
                {
                    MessageBox.Show("输入连接名称");
                    return false;
                }
                if (this.mysqlHostTextBox2.Text.Length == 0)
                {
                    MessageBox.Show("输入主机");
                    return false;
                }
                if (this.mysqlPortTextBox3.Text.Length == 0)
                {
                    MessageBox.Show("输入端口");
                    return false;
                }
                if (this.mysqlPortTextBox3.Text.Length == 0)
                {
                    MessageBox.Show("输入端口");
                    return false;
                }
                if (this.mysqlUsernametextBox4.Text.Length == 0)
                {
                    MessageBox.Show("输入用户名");
                    return false;
                }
                if (this.mysqlPasswordTextBox5.Text.Length == 0)
                {
                    MessageBox.Show("输入密码");
                    return false;
                }
                #endregion
                string connectString = ContextUtils.GetMysqlConnectString(mysqlHostTextBox2.Text, mysqlPortTextBox3.Text, mysqlUsernametextBox4.Text, mysqlPasswordTextBox5.Text);
                if (typ == "save")
                {
                    //保存
                    BllFsDatabase bllFsDatabase = new BllFsDatabase();
                    Model.FsDatabase fsDatabase = new Model.FsDatabase() { 
                        DatabaseName = mysqlConnectNameTextBox1.Text,
                        ConnectString = connectString,
                        DBType = EnumDatabase.Mysql.GetDescription(),
                        State = (int)EnumState.Normal
                    };
                    bllFsDatabase.Add(fsDatabase);
                    this.Close();
                }
                else
                {
                    //测试
                    string errMsg = "";
                    bool successDB =  ContextUtils.TestConnectDB(DataDefine.EnumDatabase.Mysql, connectString,out errMsg);
                    if (successDB) {
                        MessageBox.Show("Success!");
                    }
                    else
                    {
                        MessageBox.Show("Error! "+errMsg);
                    }
                }
            }

            return true;
        }
    }
}
