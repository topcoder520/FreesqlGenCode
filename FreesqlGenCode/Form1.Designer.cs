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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPanelShowGenCodeTemple1 = new System.Windows.Forms.Panel();
            this.genCodeBottomPanel1 = new System.Windows.Forms.Panel();
            this.genCodeRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.genCodeTopPanel1 = new System.Windows.Forms.Panel();
            this.genCodeButton1 = new System.Windows.Forms.Button();
            this.underLineToCheckBox2 = new System.Windows.Forms.CheckBox();
            this.allLowerCheckBox1 = new System.Windows.Forms.CheckBox();
            this.firstCharUpperCheckBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectTempleteComboBox1 = new System.Windows.Forms.ComboBox();
            this.filterTablenameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.namespaceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPanelTableTop1 = new System.Windows.Forms.Panel();
            this.dataGridViewTop1 = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDbType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDbTypeText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDbTypeTextFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaxLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsPrimary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsIdentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsNullable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColComent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.topFlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPanelShowGenCodeTemple1.SuspendLayout();
            this.genCodeBottomPanel1.SuspendLayout();
            this.genCodeTopPanel1.SuspendLayout();
            this.tabPanelTableTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop1)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 29);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1296, 720);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabPanelShowGenCodeTemple1);
            this.tabPage1.Controls.Add(this.tabPanelTableTop1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1288, 683);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "单表代码生成";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPanelShowGenCodeTemple1
            // 
            this.tabPanelShowGenCodeTemple1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPanelShowGenCodeTemple1.Controls.Add(this.genCodeBottomPanel1);
            this.tabPanelShowGenCodeTemple1.Controls.Add(this.genCodeTopPanel1);
            this.tabPanelShowGenCodeTemple1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelShowGenCodeTemple1.Location = new System.Drawing.Point(3, 281);
            this.tabPanelShowGenCodeTemple1.Name = "tabPanelShowGenCodeTemple1";
            this.tabPanelShowGenCodeTemple1.Size = new System.Drawing.Size(1282, 399);
            this.tabPanelShowGenCodeTemple1.TabIndex = 1;
            // 
            // genCodeBottomPanel1
            // 
            this.genCodeBottomPanel1.Controls.Add(this.genCodeRichTextBox1);
            this.genCodeBottomPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genCodeBottomPanel1.Location = new System.Drawing.Point(0, 136);
            this.genCodeBottomPanel1.Name = "genCodeBottomPanel1";
            this.genCodeBottomPanel1.Size = new System.Drawing.Size(1280, 261);
            this.genCodeBottomPanel1.TabIndex = 1;
            // 
            // genCodeRichTextBox1
            // 
            this.genCodeRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genCodeRichTextBox1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genCodeRichTextBox1.Location = new System.Drawing.Point(0, 0);
            this.genCodeRichTextBox1.Name = "genCodeRichTextBox1";
            this.genCodeRichTextBox1.Size = new System.Drawing.Size(1280, 261);
            this.genCodeRichTextBox1.TabIndex = 0;
            this.genCodeRichTextBox1.Text = "";
            // 
            // genCodeTopPanel1
            // 
            this.genCodeTopPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.genCodeTopPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genCodeTopPanel1.Controls.Add(this.genCodeButton1);
            this.genCodeTopPanel1.Controls.Add(this.underLineToCheckBox2);
            this.genCodeTopPanel1.Controls.Add(this.allLowerCheckBox1);
            this.genCodeTopPanel1.Controls.Add(this.firstCharUpperCheckBox1);
            this.genCodeTopPanel1.Controls.Add(this.label3);
            this.genCodeTopPanel1.Controls.Add(this.selectTempleteComboBox1);
            this.genCodeTopPanel1.Controls.Add(this.filterTablenameText);
            this.genCodeTopPanel1.Controls.Add(this.label2);
            this.genCodeTopPanel1.Controls.Add(this.namespaceText);
            this.genCodeTopPanel1.Controls.Add(this.label1);
            this.genCodeTopPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.genCodeTopPanel1.Location = new System.Drawing.Point(0, 0);
            this.genCodeTopPanel1.Name = "genCodeTopPanel1";
            this.genCodeTopPanel1.Size = new System.Drawing.Size(1280, 136);
            this.genCodeTopPanel1.TabIndex = 0;
            // 
            // genCodeButton1
            // 
            this.genCodeButton1.Location = new System.Drawing.Point(729, 87);
            this.genCodeButton1.Name = "genCodeButton1";
            this.genCodeButton1.Size = new System.Drawing.Size(112, 34);
            this.genCodeButton1.TabIndex = 9;
            this.genCodeButton1.Text = "生成代码";
            this.genCodeButton1.UseVisualStyleBackColor = true;
            this.genCodeButton1.Click += new System.EventHandler(this.genCodeButton1_Click);
            // 
            // underLineToCheckBox2
            // 
            this.underLineToCheckBox2.AutoSize = true;
            this.underLineToCheckBox2.Location = new System.Drawing.Point(371, 91);
            this.underLineToCheckBox2.Name = "underLineToCheckBox2";
            this.underLineToCheckBox2.Size = new System.Drawing.Size(108, 28);
            this.underLineToCheckBox2.TabIndex = 8;
            this.underLineToCheckBox2.Text = "下划线转";
            this.underLineToCheckBox2.UseVisualStyleBackColor = true;
            // 
            // allLowerCheckBox1
            // 
            this.allLowerCheckBox1.AutoSize = true;
            this.allLowerCheckBox1.Location = new System.Drawing.Point(211, 91);
            this.allLowerCheckBox1.Name = "allLowerCheckBox1";
            this.allLowerCheckBox1.Size = new System.Drawing.Size(108, 28);
            this.allLowerCheckBox1.TabIndex = 7;
            this.allLowerCheckBox1.Text = "全部小写";
            this.allLowerCheckBox1.UseVisualStyleBackColor = true;
            // 
            // firstCharUpperCheckBox1
            // 
            this.firstCharUpperCheckBox1.AutoSize = true;
            this.firstCharUpperCheckBox1.Location = new System.Drawing.Point(48, 91);
            this.firstCharUpperCheckBox1.Name = "firstCharUpperCheckBox1";
            this.firstCharUpperCheckBox1.Size = new System.Drawing.Size(126, 28);
            this.firstCharUpperCheckBox1.TabIndex = 6;
            this.firstCharUpperCheckBox1.Text = "首字母大写";
            this.firstCharUpperCheckBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(751, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "选择模板：";
            // 
            // selectTempleteComboBox1
            // 
            this.selectTempleteComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTempleteComboBox1.FormattingEnabled = true;
            this.selectTempleteComboBox1.Location = new System.Drawing.Point(857, 28);
            this.selectTempleteComboBox1.Name = "selectTempleteComboBox1";
            this.selectTempleteComboBox1.Size = new System.Drawing.Size(323, 32);
            this.selectTempleteComboBox1.TabIndex = 4;
            this.selectTempleteComboBox1.SelectedIndexChanged += new System.EventHandler(this.selectTempleteComboBox1_SelectedIndexChanged);
            // 
            // filterTablenameText
            // 
            this.filterTablenameText.Location = new System.Drawing.Point(513, 28);
            this.filterTablenameText.Name = "filterTablenameText";
            this.filterTablenameText.Size = new System.Drawing.Size(173, 30);
            this.filterTablenameText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "去掉表名字符：";
            // 
            // namespaceText
            // 
            this.namespaceText.Location = new System.Drawing.Point(137, 28);
            this.namespaceText.Name = "namespaceText";
            this.namespaceText.Size = new System.Drawing.Size(182, 30);
            this.namespaceText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "命名空间：";
            // 
            // tabPanelTableTop1
            // 
            this.tabPanelTableTop1.AutoScroll = true;
            this.tabPanelTableTop1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPanelTableTop1.Controls.Add(this.dataGridViewTop1);
            this.tabPanelTableTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPanelTableTop1.Location = new System.Drawing.Point(3, 3);
            this.tabPanelTableTop1.Name = "tabPanelTableTop1";
            this.tabPanelTableTop1.Size = new System.Drawing.Size(1282, 278);
            this.tabPanelTableTop1.TabIndex = 0;
            // 
            // dataGridViewTop1
            // 
            this.dataGridViewTop1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTop1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColCsType,
            this.ColDbType,
            this.ColDbTypeText,
            this.ColDbTypeTextFull,
            this.ColMaxLength,
            this.ColIsPrimary,
            this.ColIsIdentity,
            this.ColIsNullable,
            this.ColComent});
            this.dataGridViewTop1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTop1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTop1.Name = "dataGridViewTop1";
            this.dataGridViewTop1.ReadOnly = true;
            this.dataGridViewTop1.RowHeadersWidth = 20;
            this.dataGridViewTop1.RowTemplate.Height = 32;
            this.dataGridViewTop1.Size = new System.Drawing.Size(1280, 276);
            this.dataGridViewTop1.TabIndex = 0;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.MinimumWidth = 8;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.ToolTipText = "Name";
            this.ColName.Width = 150;
            // 
            // ColCsType
            // 
            this.ColCsType.HeaderText = "CsType";
            this.ColCsType.MinimumWidth = 8;
            this.ColCsType.Name = "ColCsType";
            this.ColCsType.ReadOnly = true;
            this.ColCsType.ToolTipText = "CsType";
            this.ColCsType.Width = 150;
            // 
            // ColDbType
            // 
            this.ColDbType.HeaderText = "DbType";
            this.ColDbType.MinimumWidth = 8;
            this.ColDbType.Name = "ColDbType";
            this.ColDbType.ReadOnly = true;
            this.ColDbType.ToolTipText = "DbType";
            this.ColDbType.Width = 150;
            // 
            // ColDbTypeText
            // 
            this.ColDbTypeText.HeaderText = "DbTypeText";
            this.ColDbTypeText.MinimumWidth = 8;
            this.ColDbTypeText.Name = "ColDbTypeText";
            this.ColDbTypeText.ReadOnly = true;
            this.ColDbTypeText.ToolTipText = "DbTypeText";
            this.ColDbTypeText.Width = 150;
            // 
            // ColDbTypeTextFull
            // 
            this.ColDbTypeTextFull.HeaderText = "DbTypeTextFull";
            this.ColDbTypeTextFull.MinimumWidth = 8;
            this.ColDbTypeTextFull.Name = "ColDbTypeTextFull";
            this.ColDbTypeTextFull.ReadOnly = true;
            this.ColDbTypeTextFull.ToolTipText = "DbTypeTextFull";
            this.ColDbTypeTextFull.Width = 150;
            // 
            // ColMaxLength
            // 
            this.ColMaxLength.HeaderText = "MaxLength";
            this.ColMaxLength.MinimumWidth = 8;
            this.ColMaxLength.Name = "ColMaxLength";
            this.ColMaxLength.ReadOnly = true;
            this.ColMaxLength.ToolTipText = "MaxLength";
            this.ColMaxLength.Width = 150;
            // 
            // ColIsPrimary
            // 
            this.ColIsPrimary.HeaderText = "IsPrimary";
            this.ColIsPrimary.MinimumWidth = 8;
            this.ColIsPrimary.Name = "ColIsPrimary";
            this.ColIsPrimary.ReadOnly = true;
            this.ColIsPrimary.ToolTipText = "IsPrimary";
            this.ColIsPrimary.Width = 150;
            // 
            // ColIsIdentity
            // 
            this.ColIsIdentity.HeaderText = "IsIdentity";
            this.ColIsIdentity.MinimumWidth = 8;
            this.ColIsIdentity.Name = "ColIsIdentity";
            this.ColIsIdentity.ReadOnly = true;
            this.ColIsIdentity.ToolTipText = "IsIdentity";
            this.ColIsIdentity.Width = 150;
            // 
            // ColIsNullable
            // 
            this.ColIsNullable.HeaderText = "IsNullable";
            this.ColIsNullable.MinimumWidth = 8;
            this.ColIsNullable.Name = "ColIsNullable";
            this.ColIsNullable.ReadOnly = true;
            this.ColIsNullable.ToolTipText = "IsNullable";
            this.ColIsNullable.Width = 150;
            // 
            // ColComent
            // 
            this.ColComent.HeaderText = "Coment";
            this.ColComent.MinimumWidth = 8;
            this.ColComent.Name = "ColComent";
            this.ColComent.ReadOnly = true;
            this.ColComent.ToolTipText = "Coment";
            this.ColComent.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1288, 683);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "多表代码生成";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tableContextMenuStrip1.Size = new System.Drawing.Size(241, 97);
            // 
            // modelGenToolStripMenuItem
            // 
            this.modelGenToolStripMenuItem.Name = "modelGenToolStripMenuItem";
            this.modelGenToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.modelGenToolStripMenuItem.Text = "单表代码生成";
            this.modelGenToolStripMenuItem.Click += new System.EventHandler(this.modelGenToolStripMenuItem_Click);
            // 
            // mulTableGenToolStripMenuItem
            // 
            this.mulTableGenToolStripMenuItem.Name = "mulTableGenToolStripMenuItem";
            this.mulTableGenToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.mulTableGenToolStripMenuItem.Text = "多表代码生成";
            this.mulTableGenToolStripMenuItem.Click += new System.EventHandler(this.mulTableGenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 821);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.topFlowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Freesql代码生成";
            this.topFlowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPanelShowGenCodeTemple1.ResumeLayout(false);
            this.genCodeBottomPanel1.ResumeLayout(false);
            this.genCodeTopPanel1.ResumeLayout(false);
            this.genCodeTopPanel1.PerformLayout();
            this.tabPanelTableTop1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop1)).EndInit();
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel tabPanelTableTop1;
        private Panel tabPanelShowGenCodeTemple1;
        private DataGridView dataGridViewTop1;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColCsType;
        private DataGridViewTextBoxColumn ColDbType;
        private DataGridViewTextBoxColumn ColDbTypeText;
        private DataGridViewTextBoxColumn ColDbTypeTextFull;
        private DataGridViewTextBoxColumn ColMaxLength;
        private DataGridViewTextBoxColumn ColIsPrimary;
        private DataGridViewTextBoxColumn ColIsIdentity;
        private DataGridViewTextBoxColumn ColIsNullable;
        private DataGridViewTextBoxColumn ColComent;
        private ContextMenuStrip tableContextMenuStrip1;
        private ToolStripMenuItem modelGenToolStripMenuItem;
        private ToolStripMenuItem mulTableGenToolStripMenuItem;
        private Panel genCodeTopPanel1;
        private Label label1;
        private Label label2;
        private TextBox namespaceText;
        private TextBox filterTablenameText;
        private Label label3;
        private ComboBox selectTempleteComboBox1;
        private CheckBox firstCharUpperCheckBox1;
        private CheckBox allLowerCheckBox1;
        private CheckBox underLineToCheckBox2;
        private Panel genCodeBottomPanel1;
        private RichTextBox genCodeRichTextBox1;
        private Button genCodeButton1;
        private TabPage tabPage2;
    }
}