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
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("节点7", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("节点1", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("节点9");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("节点2", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("节点3", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("服务器", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode16,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            this.fsPictureBox1 = new FreesqlGenCode.controls.FsAddDbPictureBox();
            this.fsDelDbPictureBox1 = new FreesqlGenCode.controls.FsDelDbPictureBox();
            this.topFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControlPanel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new FreesqlGenCode.controls.MyTabControl();
            this.firstTabPage1 = new System.Windows.Forms.TabPage();
            this.firstPageListViewPanel1 = new System.Windows.Forms.Panel();
            this.firstPageListView1 = new System.Windows.Forms.ListView();
            this.columnNameHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnSchemaHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnDbTableTypeHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnColumnsHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnIndexesHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnCommentHeader1 = new System.Windows.Forms.ColumnHeader();
            this.firstPageToolPanel1 = new System.Windows.Forms.Panel();
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
            this.mulTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modelGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topFlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.firstTabPage1.SuspendLayout();
            this.firstPageListViewPanel1.SuspendLayout();
            this.rootTreeNodeContextMenuStrip1.SuspendLayout();
            this.conctContextMenuStrip1.SuspendLayout();
            this.dbContextMenuStrip1.SuspendLayout();
            this.tableContextMenuStrip1.SuspendLayout();
            this.listViewContextMenuStrip1.SuspendLayout();
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
            treeNode12.Name = "节点8";
            treeNode12.Text = "节点8";
            treeNode13.Name = "节点7";
            treeNode13.Text = "节点7";
            treeNode14.Name = "节点1";
            treeNode14.Text = "节点1";
            treeNode15.Name = "节点9";
            treeNode15.Text = "节点9";
            treeNode16.Name = "节点2";
            treeNode16.Text = "节点2";
            treeNode17.Name = "节点10";
            treeNode17.Text = "节点10";
            treeNode18.Name = "节点3";
            treeNode18.Text = "节点3";
            treeNode19.Name = "节点4";
            treeNode19.Text = "节点4";
            treeNode20.Name = "节点5";
            treeNode20.Text = "节点5";
            treeNode21.Name = "节点6";
            treeNode21.Text = "节点6";
            treeNode22.Name = "节点0";
            treeNode22.Text = "服务器";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22});
            this.treeView1.Size = new System.Drawing.Size(400, 720);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
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
            this.firstTabPage1.Controls.Add(this.firstPageListViewPanel1);
            this.firstTabPage1.Controls.Add(this.firstPageToolPanel1);
            this.firstTabPage1.Location = new System.Drawing.Point(4, 34);
            this.firstTabPage1.Name = "firstTabPage1";
            this.firstTabPage1.Size = new System.Drawing.Size(1288, 682);
            this.firstTabPage1.TabIndex = 0;
            this.firstTabPage1.Text = "对象";
            this.firstTabPage1.UseVisualStyleBackColor = true;
            // 
            // firstPageListViewPanel1
            // 
            this.firstPageListViewPanel1.Controls.Add(this.firstPageListView1);
            this.firstPageListViewPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstPageListViewPanel1.Location = new System.Drawing.Point(0, 51);
            this.firstPageListViewPanel1.Name = "firstPageListViewPanel1";
            this.firstPageListViewPanel1.Size = new System.Drawing.Size(1288, 631);
            this.firstPageListViewPanel1.TabIndex = 1;
            // 
            // firstPageListView1
            // 
            this.firstPageListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameHeader1,
            this.columnSchemaHeader1,
            this.columnDbTableTypeHeader1,
            this.columnColumnsHeader1,
            this.columnIndexesHeader1,
            this.columnCommentHeader1});
            this.firstPageListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstPageListView1.Location = new System.Drawing.Point(0, 0);
            this.firstPageListView1.Name = "firstPageListView1";
            this.firstPageListView1.Size = new System.Drawing.Size(1288, 631);
            this.firstPageListView1.TabIndex = 0;
            this.firstPageListView1.UseCompatibleStateImageBehavior = false;
            this.firstPageListView1.View = System.Windows.Forms.View.Details;
            this.firstPageListView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.firstPageListView1_MouseClick);
            // 
            // columnNameHeader1
            // 
            this.columnNameHeader1.Text = "表名";
            this.columnNameHeader1.Width = 350;
            // 
            // columnSchemaHeader1
            // 
            this.columnSchemaHeader1.Text = "Schema ";
            this.columnSchemaHeader1.Width = 120;
            // 
            // columnDbTableTypeHeader1
            // 
            this.columnDbTableTypeHeader1.Text = "类型";
            this.columnDbTableTypeHeader1.Width = 120;
            // 
            // columnColumnsHeader1
            // 
            this.columnColumnsHeader1.Text = "列";
            this.columnColumnsHeader1.Width = 120;
            // 
            // columnIndexesHeader1
            // 
            this.columnIndexesHeader1.Text = "索引";
            this.columnIndexesHeader1.Width = 120;
            // 
            // columnCommentHeader1
            // 
            this.columnCommentHeader1.Text = "注释";
            this.columnCommentHeader1.Width = 624;
            // 
            // firstPageToolPanel1
            // 
            this.firstPageToolPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstPageToolPanel1.Location = new System.Drawing.Point(0, 0);
            this.firstPageToolPanel1.Name = "firstPageToolPanel1";
            this.firstPageToolPanel1.Size = new System.Drawing.Size(1288, 51);
            this.firstPageToolPanel1.TabIndex = 0;
            // 
            // rootTreeNodeContextMenuStrip1
            // 
            this.rootTreeNodeContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.rootTreeNodeContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rootTreeNodeReToolStripMenuItem,
            this.rootTreeNodeAddToolStripMenuItem});
            this.rootTreeNodeContextMenuStrip1.Name = "rootTreeNodeContextMenuStrip1";
            this.rootTreeNodeContextMenuStrip1.Size = new System.Drawing.Size(153, 64);
            // 
            // rootTreeNodeReToolStripMenuItem
            // 
            this.rootTreeNodeReToolStripMenuItem.Name = "rootTreeNodeReToolStripMenuItem";
            this.rootTreeNodeReToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.rootTreeNodeReToolStripMenuItem.Text = "刷新";
            this.rootTreeNodeReToolStripMenuItem.Click += new System.EventHandler(this.rootTreeNodeReToolStripMenuItem_Click);
            // 
            // rootTreeNodeAddToolStripMenuItem
            // 
            this.rootTreeNodeAddToolStripMenuItem.Name = "rootTreeNodeAddToolStripMenuItem";
            this.rootTreeNodeAddToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.rootTreeNodeAddToolStripMenuItem.Text = "添加连接";
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
            this.conctContextMenuStrip1.Size = new System.Drawing.Size(153, 94);
            // 
            // conctConnectToolStripMenuItem
            // 
            this.conctConnectToolStripMenuItem.Name = "conctConnectToolStripMenuItem";
            this.conctConnectToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.conctConnectToolStripMenuItem.Text = "打开连接";
            this.conctConnectToolStripMenuItem.Click += new System.EventHandler(this.conctConnectToolStripMenuItem_Click);
            // 
            // conctCloseToolStripMenuItem
            // 
            this.conctCloseToolStripMenuItem.Name = "conctCloseToolStripMenuItem";
            this.conctCloseToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.conctCloseToolStripMenuItem.Text = "关闭连接";
            this.conctCloseToolStripMenuItem.Click += new System.EventHandler(this.conctCloseToolStripMenuItem_Click);
            // 
            // conctDelToolStripMenuItem
            // 
            this.conctDelToolStripMenuItem.Name = "conctDelToolStripMenuItem";
            this.conctDelToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.conctDelToolStripMenuItem.Text = "删除连接";
            this.conctDelToolStripMenuItem.Click += new System.EventHandler(this.fsDelDbPictureBox1_FsClick);
            // 
            // dbContextMenuStrip1
            // 
            this.dbContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.dbContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDBToolStripMenuItem,
            this.refreshDBToolStripMenuItem,
            this.mulTableToolStripMenuItem,
            this.dbCloseToolStripMenuItem});
            this.dbContextMenuStrip1.Name = "dbContextMenuStrip1";
            this.dbContextMenuStrip1.Size = new System.Drawing.Size(171, 124);
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
            // mulTableToolStripMenuItem
            // 
            this.mulTableToolStripMenuItem.Name = "mulTableToolStripMenuItem";
            this.mulTableToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.mulTableToolStripMenuItem.Text = "代码生成";
            this.mulTableToolStripMenuItem.Click += new System.EventHandler(this.mulTableGenToolStripMenuItem_Click);
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
            this.modelGenToolStripMenuItem});
            this.tableContextMenuStrip1.Name = "tableContextMenuStrip1";
            this.tableContextMenuStrip1.Size = new System.Drawing.Size(153, 34);
            // 
            // modelGenToolStripMenuItem
            // 
            this.modelGenToolStripMenuItem.Name = "modelGenToolStripMenuItem";
            this.modelGenToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.modelGenToolStripMenuItem.Text = "代码生成";
            this.modelGenToolStripMenuItem.Click += new System.EventHandler(this.modelGenToolStripMenuItem_Click);
            // 
            // listViewContextMenuStrip1
            // 
            this.listViewContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.listViewContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listViewToolStripMenuItem});
            this.listViewContextMenuStrip1.Name = "listViewContextMenuStrip1";
            this.listViewContextMenuStrip1.Size = new System.Drawing.Size(153, 34);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.listViewToolStripMenuItem.Text = "代码生成";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
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
            this.firstPageListViewPanel1.ResumeLayout(false);
            this.rootTreeNodeContextMenuStrip1.ResumeLayout(false);
            this.conctContextMenuStrip1.ResumeLayout(false);
            this.dbContextMenuStrip1.ResumeLayout(false);
            this.tableContextMenuStrip1.ResumeLayout(false);
            this.listViewContextMenuStrip1.ResumeLayout(false);
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
        private TabPage firstTabPage1;
        private ToolStripMenuItem mulTableToolStripMenuItem;
        private Panel firstPageToolPanel1;
        private Panel firstPageListViewPanel1;
        private ListView firstPageListView1;
        private ColumnHeader columnNameHeader1;
        private ColumnHeader columnSchemaHeader1;
        private ColumnHeader columnDbTableTypeHeader1;
        private ColumnHeader columnColumnsHeader1;
        private ColumnHeader columnIndexesHeader1;
        private ColumnHeader columnCommentHeader1;
        private ContextMenuStrip listViewContextMenuStrip1;
        private ToolStripMenuItem listViewToolStripMenuItem;
    }
}