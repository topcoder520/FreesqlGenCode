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
                "rownum "," TOP "," top "," UNION "," union "," ALL "," all "," VIEW "," view ",
                };

        public async void SetKeyWorlds()
        {
            await Task.Run(() =>
            {
                //查询关键字
                keyWorlds.Append(keyWorlds[0]);

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
        /// <summary>
        /// 过滤条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

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
                                    object[] arr = dt.Rows[i].ItemArray.Select(a=> a is int? a+"":a).ToArray();
                                    dataGridView1.Rows.Add(dt.Rows[i].ItemArray);
                                }
                            }
                        });
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
    }
}
