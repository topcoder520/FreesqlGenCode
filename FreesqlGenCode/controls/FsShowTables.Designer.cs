using Dm;
using MySqlX.XDevAPI.Relational;
using System.ComponentModel;

namespace FreesqlGenCode.controls
{
    partial class FsShowTables
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableContextMenuStrip1
            // 
            this.tableContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tableContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editNoteToolStripMenuItem});
            this.tableContextMenuStrip1.Name = "tableContextMenuStrip1";
            this.tableContextMenuStrip1.Size = new System.Drawing.Size(241, 67);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.editNoteToolStripMenuItem.Text = "编辑节点";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // FsShowTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FsShowTables";
            this.Size = new System.Drawing.Size(1088, 683);
            this.tableContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int i = 0; i < fsLines.Count; i++)
            {
                fsLines[i].ResetPoint();
                fsLines[i].OnPaint(e);
            }
        }

        #region tableNote 节点
        /// <summary>
        /// 列的宽度
        /// </summary>
        public int ColWidth { get; set; } = 400;
        /// <summary>
        /// 子元素的上下间距
        /// </summary>
        public int MarginTopBottomOfTable { get; set; } = 35;

        private Dictionary<int, List<FsTableControl>> pairsTable = new Dictionary<int, List<FsTableControl>>();

        public FsTableControl SelectedNote { get; set; }

        private void SelectedNoteEvent(object sender, EventArgs e)
        {
            SelectedNote = sender as FsTableControl;
            MouseEventArgs me = e as MouseEventArgs;
            if (me.Button == MouseButtons.Right)
            {
                this.tableContextMenuStrip1.Show(this.SelectedNote, me.Location);
            }
        }

        private int TableId = 0;

        public void AddTableControl(FsTableControl table)
        {
            if (table.PrevNode != null && !table.PrevNode.NextNodeList.Contains(table))
            {
                table.PrevNode.NextNodeList.Add(table);
            }
            if(table.TableId <= 0)
            {
                table.TableId = ++TableId;
            }
            table.SelectedNoteEvent += SelectedNoteEvent;
            table.DoubleClickNodeEvent += editNoteToolStripMenuItem_Click;

            int col = table.Col;
            if (col < 0)
            {
                col = 0;
            }
            List<FsTableControl> lstTable;
            if (!pairsTable.TryGetValue(col, out lstTable))
            {
                lstTable = new List<FsTableControl>();
                pairsTable.Add(col, lstTable);
            }
            lstTable.Add(table);

            table.AutoSize = true;
            table.Name = "fsTableControl" + table.TableId;
            table.Size = new System.Drawing.Size(181, 33);
            table.TabIndex = table.TableId;
            //计算table控件放置的位置
            int x = 10;
            int y = 35;
            x += col * ColWidth;
            int cntTable = lstTable.Count;
            y += (cntTable - 1) * table.Size.Height + (cntTable - 1) * MarginTopBottomOfTable;
            table.Location = new System.Drawing.Point(x, y);
            //先添加节点
            this.Controls.Add(table);
            //再添加线
            AddLine(table);
        }
        public void RemoveTableControl(int tableId, int col)
        {
            List<FsTableControl> lstTable;
            if (pairsTable.TryGetValue(col, out lstTable))
            {
                for (int i = 0; i < lstTable.Count; i++)
                {
                    FsTableControl fsTable = lstTable[i];
                    if (fsTable.TableId == tableId)
                    {
                        RemoveNode(fsTable);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="node"></param>
        public void RemoveNode(FsTableControl node)
        {
            if (node == null) return;
            if (node.PrevNode != null)
            {//断开父节点
                int cnt = node.PrevNode.NextNodeList.Count;
                for (int i = 0; i < cnt; i++)
                {
                    if (node.PrevNode.NextNodeList[i].TableId == node.TableId)
                    {
                        node.PrevNode.NextNodeList.RemoveAt(i);
                        break;
                    }
                }
                node.PrevNode = null;
            }
            //删除所有子节点
            if (node.NextNodeList.Count > 0)
            {
                int cnt = node.NextNodeList.Count;
                for (int i = 0; i < cnt; i++)
                {
                    FsTableControl fsTable = node.NextNodeList[i];
                    RemoveNode(fsTable);
                }
            }
            //删除节点
            List<FsTableControl> lstTable;
            if (pairsTable.TryGetValue(node.Col, out lstTable))
            {
                int cnt = lstTable.Count;
                for (int i = 0; i < cnt; i++)
                {
                    FsTableControl fsTable = lstTable[i];
                    if (fsTable.TableId == node.TableId)
                    {
                        this.Controls.Remove(fsTable);
                        FsLine line = fsTable.Tag as FsLine;
                        if (fsLines.Contains(line))
                        {
                            fsLines.Remove(line);
                        }
                        if (i != (cnt - 1))
                        {//重新规划列剩下节点的位置
                            for (int j = i + 1; j <= cnt - 1; j++)
                            {
                                int x = lstTable[j].Location.X;
                                int y = lstTable[j].Location.Y;
                                y = y - (lstTable[j].Height + MarginTopBottomOfTable);
                                lstTable[j].Location = new Point(x, y);
                                //调整节点的线
                                FsLine fsLine = lstTable[j].Tag as FsLine;
                                Point endPoint = lstTable[j].LeftPoint(-10);
                                fsLine.SetEnd(endPoint);
                            }
                        }
                        lstTable.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        #endregion

        #region lineNode 线
        private List<FsLine> fsLines = new List<FsLine>();
        private void AddLine(FsTableControl node)
        {
            FsLine line = (FsLine)node.Tag;
            if (line == null)
            {
                line = new FsLine();
            }
            Point reEnd = node.LeftPoint(-10);
            line.SetEnd(reEnd);
            line.Node = node;
            node.Tag = line;
            if (node.PrevNode != null)
            {
                Point reStart = node.PrevNode.RightPoint();
                line.SetStart(reStart);
                fsLines.Add(line);
            }
        }

        #endregion

        private ContextMenuStrip tableContextMenuStrip1;
        private ToolStripMenuItem editNoteToolStripMenuItem;
    }
}
