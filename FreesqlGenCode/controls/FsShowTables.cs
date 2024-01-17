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

namespace FreesqlGenCode.controls
{
    public partial class FsShowTables : UserControl
    {

        public FsShowTables()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 编辑节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FsTableControl fsTable = SelectedNote;
            if(fsTable != null)
            {
                TreeNode node = this.Tag as TreeNode;
                TreeNode parentNode = node.Parent;

               FsLine fsLine = fsTable.Tag as FsLine;
                if (fsTable.Text.StartsWith(parentNode.Text + "."))
                {
                    fsLine.EndTable = fsTable.Text;
                }
                else
                {
                    fsLine.EndTable = parentNode.Text + "." + fsTable.Text;
                }

                FsDatabase fsDatabase = node.Tag as FsDatabase;
                string DBKey = fsDatabase.DBKey;
                string tableName = string.Empty;
                if (fsTable.Text.StartsWith(parentNode.Text+"."))
                {
                    tableName= fsTable.Text;
                }
                else
                {
                    tableName = parentNode.Text + "." + fsTable.Text;
                }
                FormTableNoteInfo tableNoteInfo = new FormTableNoteInfo(DBKey, parentNode.Text, tableName);
                tableNoteInfo.StartPosition = FormStartPosition.CenterScreen;
                tableNoteInfo.Text = "节点信息 " + tableName;
                tableNoteInfo.Tag = fsTable;
                tableNoteInfo.AddNodeEvent += new EventHandler((sender, e) =>
                {
                    FsTableControl node = sender as FsTableControl;
                    this.AddTableControl(node);
                    this.Invalidate();
                });
                tableNoteInfo.RemoveNodeEvent += new EventHandler((sender, e) =>
                {
                    FsTableControl node = sender as FsTableControl;
                    this.RemoveNode(node);
                    this.Invalidate();
                });
                tableNoteInfo.ShowDialog();

            }
        }
    }
}
