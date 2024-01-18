namespace FreesqlGenCode.controls
{
    partial class MyGenCodeSqlControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.queryViewListBox1 = new System.Windows.Forms.ListBox();
            this.genCodeTablePanel1 = new System.Windows.Forms.Panel();
            this.fsShowTables1 = new FreesqlGenCode.controls.FsShowTables();
            this.topPanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EditQueryViewLabel1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.genCodeTablePanel1.SuspendLayout();
            this.topPanel1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.genCodeTablePanel1);
            this.splitContainer1.Panel2.Controls.Add(this.topPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1361, 694);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(300, 694);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "我的查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.queryViewListBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 651);
            this.panel1.TabIndex = 0;
            // 
            // queryViewListBox1
            // 
            this.queryViewListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryViewListBox1.FormattingEnabled = true;
            this.queryViewListBox1.ItemHeight = 24;
            this.queryViewListBox1.Location = new System.Drawing.Point(0, 0);
            this.queryViewListBox1.Name = "queryViewListBox1";
            this.queryViewListBox1.Size = new System.Drawing.Size(286, 651);
            this.queryViewListBox1.TabIndex = 0;
            this.queryViewListBox1.SelectedIndexChanged += new System.EventHandler(this.queryViewListBox1_SelectedIndexChanged);
            // 
            // genCodeTablePanel1
            // 
            this.genCodeTablePanel1.Controls.Add(this.fsShowTables1);
            this.genCodeTablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genCodeTablePanel1.Location = new System.Drawing.Point(0, 36);
            this.genCodeTablePanel1.Name = "genCodeTablePanel1";
            this.genCodeTablePanel1.Size = new System.Drawing.Size(1057, 658);
            this.genCodeTablePanel1.TabIndex = 1;
            // 
            // fsShowTables1
            // 
            this.fsShowTables1.AutoScroll = true;
            this.fsShowTables1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fsShowTables1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fsShowTables1.ColWidth = 400;
            this.fsShowTables1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fsShowTables1.Location = new System.Drawing.Point(0, 0);
            this.fsShowTables1.MarginTopBottomOfTable = 35;
            this.fsShowTables1.Name = "fsShowTables1";
            this.fsShowTables1.SelectedNote = null;
            this.fsShowTables1.Size = new System.Drawing.Size(1057, 658);
            this.fsShowTables1.TabIndex = 0;
            // 
            // topPanel1
            // 
            this.topPanel1.Controls.Add(this.label1);
            this.topPanel1.Controls.Add(this.EditQueryViewLabel1);
            this.topPanel1.Controls.Add(this.button2);
            this.topPanel1.Controls.Add(this.button1);
            this.topPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel1.Location = new System.Drawing.Point(0, 0);
            this.topPanel1.Name = "topPanel1";
            this.topPanel1.Size = new System.Drawing.Size(1057, 36);
            this.topPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(68, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "删除";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditQueryViewLabel1
            // 
            this.EditQueryViewLabel1.AutoSize = true;
            this.EditQueryViewLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EditQueryViewLabel1.Location = new System.Drawing.Point(15, 4);
            this.EditQueryViewLabel1.Name = "EditQueryViewLabel1";
            this.EditQueryViewLabel1.Size = new System.Drawing.Size(46, 24);
            this.EditQueryViewLabel1.TabIndex = 2;
            this.EditQueryViewLabel1.Text = "编辑";
            this.EditQueryViewLabel1.Click += new System.EventHandler(this.EditQueryViewLabel1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.DarkCyan;
            this.button2.Location = new System.Drawing.Point(785, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "生成SQL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(927, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(117, 34);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // MyGenCodeSqlControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MyGenCodeSqlControl";
            this.Size = new System.Drawing.Size(1361, 694);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.genCodeTablePanel1.ResumeLayout(false);
            this.topPanel1.ResumeLayout(false);
            this.topPanel1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel topPanel1;
        private Panel genCodeTablePanel1;
        public FsShowTables fsShowTables1;
        private Button button2;
        private Button button1;
        private Panel panel1;
        public ListBox queryViewListBox1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem 编辑ToolStripMenuItem;
        private Label EditQueryViewLabel1;
        private Label label1;
    }
}
