using System.ComponentModel;

namespace FreesqlGenCode.controls
{
    partial class FsTableControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableNameLabel1 = new System.Windows.Forms.Label();
            this.tableLeftPictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLeftPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableNameLabel1);
            this.panel1.Controls.Add(this.tableLeftPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 34);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableNameLabel1
            // 
            this.tableNameLabel1.AutoSize = true;
            this.tableNameLabel1.Location = new System.Drawing.Point(34, 6);
            this.tableNameLabel1.Name = "tableNameLabel1";
            this.tableNameLabel1.Size = new System.Drawing.Size(63, 24);
            this.tableNameLabel1.TabIndex = 1;
            this.tableNameLabel1.Text = "label1";
            this.tableNameLabel1.DoubleClick += new System.EventHandler(this.tableNameLabel1_DoubleClick);
            this.tableNameLabel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FsTableControl_MouseClick);
            this.tableNameLabel1.MouseEnter += new System.EventHandler(this.tableNameLabel1_Enter);
            this.tableNameLabel1.MouseLeave += new System.EventHandler(this.tableNameLabel1_Leave);
            // 
            // tableLeftPictureBox1
            // 
            this.tableLeftPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLeftPictureBox1.Image = global::FreesqlGenCode.Properties.Resources.application;
            this.tableLeftPictureBox1.Location = new System.Drawing.Point(15, 8);
            this.tableLeftPictureBox1.Name = "tableLeftPictureBox1";
            this.tableLeftPictureBox1.Size = new System.Drawing.Size(22, 21);
            this.tableLeftPictureBox1.TabIndex = 0;
            this.tableLeftPictureBox1.TabStop = false;
            this.tableLeftPictureBox1.DoubleClick += new System.EventHandler(this.tableNameLabel1_DoubleClick);
            this.tableLeftPictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FsTableControl_MouseClick);
            this.tableLeftPictureBox1.MouseEnter += new System.EventHandler(this.tableNameLabel1_Enter);
            this.tableLeftPictureBox1.MouseLeave += new System.EventHandler(this.tableNameLabel1_Leave);
            // 
            // FsTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "FsTableControl";
            this.Size = new System.Drawing.Size(118, 34);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLeftPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private Panel panel1;
        private PictureBox tableLeftPictureBox1;
        private Label tableNameLabel1;

        [Browsable(true)]
        public override string Text { get{ return tableNameLabel1.Text; } set{ 
                tableNameLabel1.Text = value;
                if (string.IsNullOrEmpty(value))
                {
                    return;
                }
                this._internalToolTip.SetToolTip(this, value);
            }
        }
        [DefaultValue("")]
        [Localizable(true)]
        public string ToolTipText
        {
            get => tableNameLabel1.Text;
            set
            {
                if (value is null)
                {
                    value = string.Empty;
                }

                if (value == tableNameLabel1.Text)
                {
                    return;
                }

                //tableNameLabel1.Text = value;
                _internalToolTip.SetToolTip(this, value);
            }
        }
        /// <summary>
        /// 唯一标识
        /// </summary>
        public int TableId { get; set; }
        /// <summary>
        /// 所在列 第几列
        /// </summary>
        public int Col { get; set; }

        /// <summary>
        /// 上一节点
        /// </summary>
        public FsTableControl PrevNode { get; set; }
        /// <summary>
        /// 下一节点
        /// </summary>
        public List<FsTableControl> NextNodeList { get; set; } = new List<FsTableControl>();
        /// <summary>
        /// 准备节点 还没有画
        /// </summary>
        public List<FsTableControl> PreNextNodeList { get; set; } = new List<FsTableControl>();

        /// <summary>
        /// 左边连接点
        /// </summary>
        /// <returns></returns>
        public Point LeftPoint(int subSpanX=0,int subSpanY=0)
        {
            Point point = this.Location;
            int x = point.X + subSpanX;
            int y = point.Y + subSpanY;
            y += this.Height / 2;
            return new Point(x, y);
        }
        /// <summary>
        /// 右边连接点
        /// </summary>
        /// <returns></returns>
        public Point RightPoint()
        {
            Point point = this.Location;
            int x = point.X;
            int y = point.Y;
            x += this.Width;
            y += this.Height / 2;
            return new Point(x, y);
        }
        private readonly ToolTip _internalToolTip = new ToolTip();
        /// <summary>
        /// 生成sql时要查询的字段集合 每次保存都要重新生成
        /// </summary>
        public List<string> QueryFields = new List<string>();

    }
}
