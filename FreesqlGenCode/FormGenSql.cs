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
using System.Text.RegularExpressions;
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

        //public List<string> lstQueryField { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetKeyWorlds();
        }

       private static  string[] keyWords = new string[] {
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
        private static string[] keyWordsNotSpace = keyWords.Select(a=>a.Trim()).ToArray();

        public async void SetKeyWorlds()
        {
            await Task.Run(() =>
            {
                //查询关键字
                for (int i = 0; i < keyWords.Length; i++)
                {
                    SetColor(keyWords[i], Color.Blue);
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
            FsDatabase fsDatabase = (FsDatabase)this.Tag;
            if(fsDatabase != null)
            {
                DBConnect dBConnect =  ContextUtils.GetDBConnect(fsDatabase.DBKey);
                if(dBConnect.TestConnect())
                {
                    string sql = richTextBox1.Text;
                    //去掉注释
                    sql = HandlerSQL(sql);
                    await this.ShowLoadingAsync("正在执行SQL...", (control) =>
                    {
                        try
                        {
                            DataTable dt = dBConnect.ExeQueryBySQL(sql);
                            control.Invoke(() =>
                            {
                                if (dt != null)
                                {
                                    for (int i = 0; i < dt.Columns.Count; i++)
                                    {
                                        dataGridView1.Columns.Add(dt.Columns[i].ColumnName, dt.Columns[i].ColumnName);
                                        dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                                    }
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {
                                        object[] arr = dt.Rows[i].ItemArray.Select(a => a is int ? a + "" : a).ToArray();
                                        dataGridView1.Rows.Add(dt.Rows[i].ItemArray);
                                    }
                                    tabControl1.SelectedTab = tabPage2;
                                }
                            });
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString());
                        }
                        return Task.CompletedTask;
                    });
                }
                else
                {
                    MessageBox.Show(dBConnect.GetException());
                }
            }
        }

        private static string remarkPattern = "#((.+)(\n){0,}){0,1}"; //找出sql中的注释 # "

        private string HandlerSQL(string sql)
        {
            if(string.IsNullOrWhiteSpace(sql))
            {
                return "";
            }
            //去除注释
            sql =  Regex.Replace(sql, remarkPattern, "");
            return sql;
        }
        /// <summary>
        /// sql注释着色
        /// </summary>
        /// <param name="text"></param>
        public void SetTextColor()
        {
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                return;
            }
            //注释变色
            MatchCollection mes = Regex.Matches(richTextBox1.Text, remarkPattern);
            if (mes.Count > 0)
            {
                for (int i = 0; i < mes.Count; i++)
                {
                    int index = mes[i].Index;
                    richTextBox1.Select(index, mes[i].Value.Length);
                    richTextBox1.SelectionColor = Color.Gray;
                }
            }
        }
        /// <summary>
        /// 行文本注释着色
        /// </summary>
        /// <param name="lineText"></param>
        /// <param name="lineFirstCharIndex"></param>
        public void SetLineColor(string lineText,int lineFirstCharIndex)
        {
            if (string.IsNullOrWhiteSpace(lineText))
            {
                return;
            }
            
            if(lineText.IndexOf('#') != -1)
            {
                if (lineText.Trim().IndexOf('#') == 0)
                {
                    richTextBox1.Select(lineFirstCharIndex, lineText.Length);
                    richTextBox1.SelectionColor = Color.Gray;
                }
                else
                {
                    int index = lineText.IndexOf('#');
                    richTextBox1.Select(lineFirstCharIndex, index);
                    richTextBox1.SelectionColor = Color.Black;
                    int len = lineText.Substring(index).Length;
                    richTextBox1.Select(lineFirstCharIndex+ index, len);
                    richTextBox1.SelectionColor = Color.Gray;
                }   
            }
            else
            {
                richTextBox1.Select(lineFirstCharIndex,lineText.Length);
                richTextBox1.SelectionColor = Color.Black;
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
            
            int lineIndex = richTextBox1.GetLineFromCharIndex(selectionStart);
            int lineFirstCharIndex = richTextBox1.GetFirstCharIndexFromLine(lineIndex);
            int lineEndCharIndex = selectionStart;
            while(lineEndCharIndex<richTextBox1.TextLength)
            {
                if (richTextBox1.Text[lineEndCharIndex] == '\n')
                {
                    break;
                }
                lineEndCharIndex++;
            }
            string lineText = richTextBox1.Text.Substring(lineFirstCharIndex, lineEndCharIndex - lineFirstCharIndex);
            Common.Console.Log("行: "+ lineText);
            SetLineColor(lineText, lineFirstCharIndex);
            lineText = HandlerSQL(lineText);
            if (string.IsNullOrWhiteSpace(lineText))
            {
                richTextBox1.Select(selectionStart, 0);
                return;
            }
            string pattern = " {0,}[A-Za-z]* {1,}"; //关键字匹配
            MatchCollection keyWordsMatch = Regex.Matches(lineText,pattern);
            for (int i = 0; i < keyWordsMatch.Count; i++)
            {
                string keyWord = keyWordsMatch[i].Value;
                if (string.IsNullOrWhiteSpace(keyWord))
                {
                    continue;
                }
                int Index = keyWordsMatch[i].Index;
                int keyWordLeftIndex = lineFirstCharIndex + Index;
                if (keyWordsNotSpace.Contains(keyWord.Trim()))
                {
                    if (keyWordLeftIndex > 0)
                    {
                        if (!char.IsWhiteSpace(richTextBox1.Text[keyWordLeftIndex]))
                        {
                            if (lineFirstCharIndex<(keyWordLeftIndex - 1) && !char.IsWhiteSpace(richTextBox1.Text[keyWordLeftIndex-1]))
                            {
                                continue;
                            }
                        }
                    }
                    richTextBox1.Select(keyWordLeftIndex, keyWord.Length);
                    richTextBox1.SelectionColor = Color.Blue;
                }
                else
                {
                    richTextBox1.Select(keyWordLeftIndex, keyWord.Length);
                    richTextBox1.SelectionColor = Color.Black;
                }
            }
            //在注释里的关键字不用高亮
            if (selectionStart > (lineFirstCharIndex + lineText.Length))
            {
                richTextBox1.Select(selectionStart, 0);
                return;
            }
            StringBuilder strRightBuild = new StringBuilder();
            //右边
            int rightPosition = selectionStart;
            if (selectionStart < lineFirstCharIndex+lineText.Length)
            {
                int i = 0;
                while (true)
                {
                    if (selectionStart + i >= lineFirstCharIndex+lineText.Length)
                    {
                        break;
                    }
                    char str = richTextBox1.Text[selectionStart + i];
                    if (char.IsWhiteSpace(str))
                    {
                        break;
                    }
                    strRightBuild.Append(str);
                    i++;
                    rightPosition++;
                }
            }
            ////左边
            int leftPosition = selectionStart;
            StringBuilder strLeftBuild = new StringBuilder();
            if (selectionStart >= 0 && selectionStart>lineFirstCharIndex)
            {
                int i = 0;
                while (true)
                {
                    if (selectionStart - i <= 0)
                    {
                        break;
                    }
                    char str = richTextBox1.Text[selectionStart - i - 1];
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
            if (strLeftBuild.Length > 0)
            {
                char[] arrChar = strLeftBuild.ToString().ToCharArray();
                Array.Reverse(arrChar);
                strLeft = new string(arrChar);
            }
            if (strRightBuild.Length > 0)
            {
                strLeft += strRightBuild.ToString();
            }
            Common.Console.Log(strLeft);
            if (keyWordsNotSpace.Contains(strLeft))
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

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;//屏蔽Ctrl+ V组合按键

                DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Text);
                richTextBox1.Paste(myFormat);

                int initSelectionStart = richTextBox1.SelectionStart;
                
                string pattern = string.Join("|",keyWordsNotSpace); //关键字匹配
                MatchCollection keyWordsMatch = Regex.Matches(richTextBox1.Text, pattern);
                for (int i = 0; i < keyWordsMatch.Count; i++)
                {
                    string keyWord = keyWordsMatch[i].Value;
                    int keyWordLeftIndex = keyWordsMatch[i].Index;
                    //左边
                    if (keyWordLeftIndex > 0)
                    {
                        if (!char.IsWhiteSpace(richTextBox1.Text[keyWordLeftIndex - 1]))
                        {
                            continue;
                        }
                    }
                    //右边
                    if(keyWordLeftIndex + keyWord.Length < richTextBox1.TextLength)
                    {
                        if (!char.IsWhiteSpace(richTextBox1.Text[keyWordLeftIndex+keyWord.Length]))
                        {
                            continue;
                        }
                    }
                    richTextBox1.Select(keyWordLeftIndex, keyWord.Length);
                    richTextBox1.SelectionColor = Color.Blue;
                }
                SetTextColor();
                richTextBox1.Select(initSelectionStart, 0);
            }
        }
    }
}
