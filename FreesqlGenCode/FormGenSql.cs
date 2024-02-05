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
    public partial class FormGenSql : Form
    {
        public FormGenSql()
        {
            InitializeComponent();
            //解决中英文输入字体不一样问题
            this.richTextBox1.LanguageOption = RichTextBoxLanguageOptions.UIFonts; 
        }

        public List<string> lstQueryField { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetKeyWorlds();
        }

       private static  string[] keyWorlds = new string[] {
                " SELECT "," select "," FROM "," from "," ON "," on "," LEFT JOIN "," left join ",
                " WHERE "," where "," AS "," as "," AND "," and "," ANY "," any "," ASC "," asc ",
                " BETWEEN "," between "," CASE "," case "," CHECK "," check "," DEFAULT "," default ",
                " DESC "," desc "," DISTINCT "," distinct "," EXISTS "," exists "," FULL OUTER JOIN ",
                " full outer join "," LEFT "," left "," JOIN "," join "," FULL "," full "," OUTER ",
                " outer "," GROUP "," group "," BY "," by "," HAVING "," having "," IN "," in ",
                " inner "," INNER "," IS "," is "," NULL "," null "," NOT "," not "," LIKE "," like ",
                " limit "," LIMIT "," OR "," or "," order "," ORDER "," right "," RIGHT "," ROWNUM ",
                " rownum "," TOP "," top "," UNION "," union "," ALL "," all "," VIEW "," view ",
                };

        public async void SetKeyWorlds()
        {
            await Task.Run(() =>
            {
                //查询关键字
                for (int i = 0; i < keyWorlds.Length; i++)
                {
                    SetColor(keyWorlds[i], Color.Blue);
                }
            });
        }

        public void SetColor(string Keyworld,Color c)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(() =>
                {
                    List<int> indexes = GetKeyworldIndex(Keyworld);
                    for (int i = 0; i < indexes.Count; i++)
                    {
                        richTextBox1.Select(indexes[i], Keyworld.Length);
                        richTextBox1.SelectionColor = c;
                    }
                });
            }
            else
            {
                List<int> indexes = GetKeyworldIndex(Keyworld);
                for (int i = 0; i < indexes.Count; i++)
                {
                    richTextBox1.Select(indexes[i], Keyworld.Length);
                    richTextBox1.SelectionColor = c;
                }
            }
        }

        public List<int> GetKeyworldIndex(string Keyworld)
        {
            List<int> indexes = new List<int>();
            int startIndex = 0;
            int textLen = richTextBox1.Text.Length;
            while (startIndex<textLen)
            {
                int position = richTextBox1.Text.IndexOf(Keyworld, startIndex);
                if (position < 0)
                {
                    break;
                }
                indexes.Add(position);
                startIndex = position + Keyworld.Length;
            }
            return indexes;
        }

        private string SelectedText;

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            SelectedText = richTextBox1.SelectedText;
            //SetBackColor(selectedText,Color.Gray);
            //Common.Console.Log("selection changed:"+ selectedText);
        }

        private void copysqlbutton4_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectAll();
            this.richTextBox1.Copy();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.saveSqlFileDialog1.Filter = "SQL files (*.sql)|*.sql";
            DialogResult rs =  this.saveSqlFileDialog1.ShowDialog();
            if(rs == DialogResult.OK)
            {
                File.WriteAllText(this.saveSqlFileDialog1.FileName, this.richTextBox1.Text);
                MessageBox.Show("保存成功!");
            }
        }
        /// <summary>
        /// 执行SQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < lstQueryField.Count; i++)
            {
                this.dataGridView1.Columns.Add(lstQueryField[i], lstQueryField[i]);
            }
            FsDatabase fsDatabase = (FsDatabase)this.Tag;
            if(fsDatabase != null)
            {
                DBConnect dBConnect =  ContextUtils.GetDBConnect(fsDatabase.DBKey);
                if(dBConnect.TestConnect())
                {
                    string sql = richTextBox1.Text;
                    await this.ShowLoadingAsync("正在执行SQL...", (control) =>
                    {
                        try
                        {
                            DataTable dt = dBConnect.ExeQueryBySQL(sql);
                            control.Invoke(() =>
                            {
                                if (dt != null)
                                {
                                    if (lstQueryField.Count == 0)
                                    {
                                        for (int i = 0; i < dt.Columns.Count; i++)
                                        {
                                            dataGridView1.Columns.Add(dt.Columns[i].ColumnName, dt.Columns[i].ColumnName);
                                        }
                                    }
                                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                    {
                                        dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                                    }
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {
                                        object[] arr = dt.Rows[i].ItemArray.Select(a => a is int ? a + "" : a).ToArray();
                                        dataGridView1.Rows.Add(dt.Rows[i].ItemArray);
                                    }
                                }
                            });
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString());
                        }
                        return Task.CompletedTask;
                    });
                    tabControl1.SelectedTab = tabPage2;
                }
                else
                {
                    MessageBox.Show(dBConnect.GetException());
                }
            }
        }

        private void richTextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyData == Keys.Tab)
            {
                //MessageBox.Show("tab");
                // e.IsInputKey = true;

            }
            if (e.KeyData ==( Keys.Tab | Keys.Shift ))
            {
                //MessageBox.Show("tab");
                // e.IsInputKey = true;

            }
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
           // Common.Console.Log("SelectionStart " + richTextBox1.SelectionStart);
        }
        /// <summary>
        /// 检查输入的单词是否是sql关键字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = richTextBox1.SelectionStart;
            StringBuilder strRightBuild = new StringBuilder();
            int max = 20;
            //右边
            int rightPosition = selectionStart;
            if (selectionStart <= richTextBox1.TextLength)
            {
                int i = 0;
                while (max > i)
                {
                    if(selectionStart + i >= richTextBox1.TextLength)
                    {
                        break;
                    }
                    char str = richTextBox1.Text[selectionStart+i];
                    if (char.IsWhiteSpace(str))
                    {
                        break;
                    }
                    strRightBuild.Append(str);
                    i++;
                    rightPosition++;
                }
            }
            //左边
            int leftPosition = selectionStart;
            StringBuilder strLeftBuild = new StringBuilder();
            if (selectionStart >= 0)
            {
                int i = 0;
                while(max > i)
                {
                    if(selectionStart - i <= 0)
                    {
                        break;
                    }
                    char str = richTextBox1.Text[selectionStart-i-1];
                    if (char.IsWhiteSpace(str))
                    {
                        break;
                    }
                    strLeftBuild.Append(str);
                    i++;
                    leftPosition--;
                }
            }
            string strLeft = string.Empty;
            if(strLeftBuild.Length > 0)
            {
                char[] arrChar = strLeftBuild.ToString().ToCharArray();
                Array.Reverse(arrChar);
                strLeft = new string(arrChar);
            }
            if(strRightBuild.Length > 0)
            {
                strLeft += strRightBuild.ToString();
            }
            Common.Console.Log(strLeft);
            if(keyWorlds.Contains(" " + strLeft + " "))
            {
                richTextBox1.Select(leftPosition, strLeft.Length);
                richTextBox1.SelectionColor = Color.Blue;
            }
            else
            {
                richTextBox1.Select(leftPosition, strLeft.Length);
                richTextBox1.SelectionColor = richTextBox1.ForeColor;
            }
            richTextBox1.Select(selectionStart, 0);
        }
    }
}
