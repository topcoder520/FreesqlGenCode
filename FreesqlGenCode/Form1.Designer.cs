using FreesqlGenCode.controls;

namespace FreesqlGenCode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点7", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点1", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点9");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点2", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点3", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("服务器", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            this.fsPictureBox1 = new FreesqlGenCode.controls.FsAddDbPictureBox();
            this.fsDelDbPictureBox1 = new FreesqlGenCode.controls.FsDelDbPictureBox();
            this.topFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControlPanel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new FreesqlGenCode.controls.MyTabControl();
            this.firstTabPage1 = new System.Windows.Forms.TabPage();
            this.rootTreeNodeContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rootTreeNodeReToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rootTreeNodeAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conctContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conctConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conctCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conctDelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modelGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mulTableGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.topFlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.firstTabPage1.SuspendLayout();
            this.rootTreeNodeContextMenuStrip1.SuspendLayout();
            this.conctContextMenuStrip1.SuspendLayout();
            this.dbContextMenuStrip1.SuspendLayout();
            this.tableContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fsPictureBox1
            // 
            this.fsPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.fsPictureBox1.FsBackColor = System.Drawing.Color.Transparent;
            this.fsPictureBox1.FsHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fsPictureBox1.FsLeaveBackColor = System.Drawing.Color.Transparent;
            this.fsPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.fsPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.fsPictureBox1.Name = "fsPictureBox1";
            this.fsPictureBox1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.fsPictureBox1.Size = new System.Drawing.Size(101, 98);
            this.fsPictureBox1.TabIndex = 0;
            this.fsPictureBox1.FsClick += new System.EventHandler(this.fsPictureBox1_FsClick);
            // 
            // fsDelDbPictureBox1
            // 
            this.fsDelDbPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.fsDelDbPictureBox1.FsBackColor = System.Drawing.Color.Transparent;
            this.fsDelDbPictureBox1.FsHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fsDelDbPictureBox1.FsLeaveBackColor = System.Drawing.Color.Transparent;
            this.fsDelDbPictureBox1.Location = new System.Drawing.Point(101, 0);
            this.fsDelDbPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.fsDelDbPictureBox1.Name = "fsDelDbPictureBox1";
            this.fsDelDbPictureBox1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.fsDelDbPictureBox1.Size = new System.Drawing.Size(99, 98);
            this.fsDelDbPictureBox1.TabIndex = 1;
            this.fsDelDbPictureBox1.FsClick += new System.EventHandler(this.fsDelDbPictureBox1_FsClick);
            // 
            // topFlowLayoutPanel1
            // 
            this.topFlowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.topFlowLayoutPanel1.Controls.Add(this.fsPictureBox1);
            this.topFlowLayoutPanel1.Controls.Add(this.fsDelDbPictureBox1);
            this.topFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.topFlowLayoutPanel1.Name = "topFlowLayoutPanel1";
            this.topFlowLayoutPanel1.Size = new System.Drawing.Size(1700, 101);
            this.topFlowLayoutPanel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 101);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.tabControlPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1700, 720);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点8";
            treeNode1.Text = "节点8";
            treeNode2.Name = "节点7";
            treeNode2.Text = "节点7";
            treeNode3.Name = "节点1";
            treeNode3.Text = "节点1";
            treeNode4.Name = "节点9";
            treeNode4.Text = "节点9";
            treeNode5.Name = "节点2";
            treeNode5.Text = "节点2";
            treeNode6.Name = "节点10";
            treeNode6.Text = "节点10";
            treeNode7.Name = "节点3";
            treeNode7.Text = "节点3";
            treeNode8.Name = "节点4";
            treeNode8.Text = "节点4";
            treeNode9.Name = "节点5";
            treeNode9.Text = "节点5";
            treeNode10.Name = "节点6";
            treeNode10.Text = "节点6";
            treeNode11.Name = "节点0";
            treeNode11.Text = "服务器";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(400, 720);
            this.treeView1.TabIndex = 0;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.tabControl1);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 0);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Size = new System.Drawing.Size(1296, 720);
            this.tabControlPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.firstTabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1296, 720);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // firstTabPage1
            // 
            this.firstTabPage1.Controls.Add(this.label1);
            this.firstTabPage1.Location = new System.Drawing.Point(4, 34);
            this.firstTabPage1.Name = "firstTabPage1";
            this.firstTabPage1.Size = new System.Drawing.Size(1288, 682);
            this.firstTabPage1.TabIndex = 0;
            this.firstTabPage1.Text = "首页";
            this.firstTabPage1.UseVisualStyleBackColor = true;
            // 
            // rootTreeNodeContextMenuStrip1
            // 
            this.rootTreeNodeContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.rootTreeNodeContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rootTreeNodeReToolStripMenuItem,
            this.rootTreeNodeAddToolStripMenuItem});
            this.rootTreeNodeContextMenuStrip1.Name = "rootTreeNodeContextMenuStrip1";
            this.rootTreeNodeContextMenuStrip1.Size = new System.Drawing.Size(117, 64);
            // 
            // rootTreeNodeReToolStripMenuItem
            // 
            this.rootTreeNodeReToolStripMenuItem.Name = "rootTreeNodeReToolStripMenuItem";
            this.rootTreeNodeReToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.rootTreeNodeReToolStripMenuItem.Text = "刷新";
            this.rootTreeNodeReToolStripMenuItem.Click += new System.EventHandler(this.rootTreeNodeReToolStripMenuItem_Click);
            // 
            // rootTreeNodeAddToolStripMenuItem
            // 
            this.rootTreeNodeAddToolStripMenuItem.Name = "rootTreeNodeAddToolStripMenuItem";
            this.rootTreeNodeAddToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.rootTreeNodeAddToolStripMenuItem.Text = "添加";
            this.rootTreeNodeAddToolStripMenuItem.Click += new System.EventHandler(this.fsPictureBox1_FsClick);
            // 
            // conctContextMenuStrip1
            // 
            this.conctContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.conctContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conctConnectToolStripMenuItem,
            this.conctCloseToolStripMenuItem,
            this.conctDelToolStripMenuItem});
            this.conctContextMenuStrip1.Name = "conctContextMenuStrip1";
            this.conctContextMenuStrip1.Size = new System.Drawing.Size(117, 94);
            // 
            // conctConnectToolStripMenuItem
            // 
            this.conctConnectToolStripMenuItem.Name = "conctConnectToolStripMenuItem";
            this.conctConnectToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.conctConnectToolStripMenuItem.Text = "连接";
            this.conctConnectToolStripMenuItem.Click += new System.EventHandler(this.conctConnectToolStripMenuItem_Click);
            // 
            // conctCloseToolStripMenuItem
            // 
            this.conctCloseToolStripMenuItem.Name = "conctCloseToolStripMenuItem";
            this.conctCloseToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.conctCloseToolStripMenuItem.Text = "关闭";
            this.conctCloseToolStripMenuItem.Click += new System.EventHandler(this.conctCloseToolStripMenuItem_Click);
            // 
            // conctDelToolStripMenuItem
            // 
            this.conctDelToolStripMenuItem.Name = "conctDelToolStripMenuItem";
            this.conctDelToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.conctDelToolStripMenuItem.Text = "删除";
            this.conctDelToolStripMenuItem.Click += new System.EventHandler(this.fsDelDbPictureBox1_FsClick);
            // 
            // dbContextMenuStrip1
            // 
            this.dbContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.dbContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDBToolStripMenuItem,
            this.refreshDBToolStripMenuItem,
            this.dbCloseToolStripMenuItem});
            this.dbContextMenuStrip1.Name = "dbContextMenuStrip1";
            this.dbContextMenuStrip1.Size = new System.Drawing.Size(171, 94);
            // 
            // openDBToolStripMenuItem
            // 
            this.openDBToolStripMenuItem.Name = "openDBToolStripMenuItem";
            this.openDBToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.openDBToolStripMenuItem.Text = "打开数据库";
            this.openDBToolStripMenuItem.Click += new System.EventHandler(this.openDBToolStripMenuItem_Click);
            // 
            // refreshDBToolStripMenuItem
            // 
            this.refreshDBToolStripMenuItem.Name = "refreshDBToolStripMenuItem";
            this.refreshDBToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.refreshDBToolStripMenuItem.Text = "刷新";
            this.refreshDBToolStripMenuItem.Click += new System.EventHandler(this.openDBToolStripMenuItem_Click);
            // 
            // dbCloseToolStripMenuItem
            // 
            this.dbCloseToolStripMenuItem.Name = "dbCloseToolStripMenuItem";
            this.dbCloseToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.dbCloseToolStripMenuItem.Text = "关闭数据库";
            this.dbCloseToolStripMenuItem.Click += new System.EventHandler(this.dbCloseToolStripMenuItem_Click);
            // 
            // tableContextMenuStrip1
            // 
            this.tableContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tableContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelGenToolStripMenuItem,
            this.mulTableGenToolStripMenuItem});
            this.tableContextMenuStrip1.Name = "tableContextMenuStrip1";
            this.tableContextMenuStrip1.Size = new System.Drawing.Size(189, 64);
            // 
            // modelGenToolStripMenuItem
            // 
            this.modelGenToolStripMenuItem.Name = "modelGenToolStripMenuItem";
            this.modelGenToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.modelGenToolStripMenuItem.Text = "单表代码生成";
            this.modelGenToolStripMenuItem.Click += new System.EventHandler(this.modelGenToolStripMenuItem_Click);
            // 
            // mulTableGenToolStripMenuItem
            // 
            this.mulTableGenToolStripMenuItem.Name = "mulTableGenToolStripMenuItem";
            this.mulTableGenToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.mulTableGenToolStripMenuItem.Text = "多表代码生成";
            this.mulTableGenToolStripMenuItem.Click += new System.EventHandler(this.mulTableGenToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "多表代码生成默认在首页";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 821);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.topFlowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "FreesqlGenCode代码工具";
            this.topFlowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.firstTabPage1.ResumeLayout(false);
            this.firstTabPage1.PerformLayout();
            this.rootTreeNodeContextMenuStrip1.ResumeLayout(false);
            this.conctContextMenuStrip1.ResumeLayout(false);
            this.dbContextMenuStrip1.ResumeLayout(false);
            this.tableContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private controls.FsAddDbPictureBox fsPictureBox1;
        private controls.FsDelDbPictureBox fsDelDbPictureBox1;
        private FlowLayoutPanel topFlowLayoutPanel1;
        private SplitContainer splitContainer1;
        private TreeView treeView1;
        private ContextMenuStrip rootTreeNodeContextMenuStrip1;
        private ToolStripMenuItem rootTreeNodeReToolStripMenuItem;
        private ToolStripMenuItem rootTreeNodeAddToolStripMenuItem;
        private ContextMenuStrip conctContextMenuStrip1;
        private ToolStripMenuItem conctConnectToolStripMenuItem;
        private ToolStripMenuItem conctCloseToolStripMenuItem;
        private ToolStripMenuItem conctDelToolStripMenuItem;
        private ContextMenuStrip dbContextMenuStrip1;
        private ToolStripMenuItem openDBToolStripMenuItem;
        private ToolStripMenuItem refreshDBToolStripMenuItem;
        private ToolStripMenuItem dbCloseToolStripMenuItem;
        private Panel tabControlPanel1;
        private MyTabControl tabControl1;
        private ContextMenuStrip tableContextMenuStrip1;
        private ToolStripMenuItem modelGenToolStripMenuItem;
        private ToolStripMenuItem mulTableGenToolStripMenuItem;
        private TabPage firstTabPage1;
        private Label label1;
    }
}