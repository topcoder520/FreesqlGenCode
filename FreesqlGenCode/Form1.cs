using BLL;
using Common;
using Context;
using DataDefine;
using Model;

namespace FreesqlGenCode
{
    public partial class Form1 : Form
    {
        private BllFsDatabase bllFsDatabase = new BllFsDatabase();

        public Form1()
        {
            InitializeComponent();
            InitTreeView();
        }
        /// <summary>
        /// 初始化TreeNode
        /// </summary>
        private void InitTreeView()
        {
            #region 初始化树形节点
            treeView1.BeginUpdate();
            ImageList imageList = new ImageList();
            imageList.Images.Add(Properties.Resources.monitor);
            imageList.Images.Add(Properties.Resources.database);
            imageList.Images.Add(Properties.Resources.application);

            List<FsDatabase> listData = bllFsDatabase.GetList(a => a.State == (int)EnumState.Normal);
            treeView1.Nodes.Clear();
            treeView1.ImageList = imageList;
            TreeNode[] treeNodes = new TreeNode[listData.Count];
            for (int i = 0; i < listData.Count; i++)
            {
                FsDatabase fsDatabase = listData[i];
                treeNodes[i] = new TreeNode(fsDatabase.DatabaseName + $"({fsDatabase.DBType})", 0, 0);
                treeNodes[i].Tag = fsDatabase;
            }
            TreeNode rootNode = new TreeNode("服务器", 0, 0, treeNodes);
            treeView1.Nodes.Add(rootNode);
            treeView1.ExpandAll();
            treeView1.EndUpdate();
            #endregion

            #region 初始化tabControl
            ImageList tabImageList = new ImageList();
            tabImageList.Images.Add(Properties.Resources.close);
            tabControl1.ImageList = tabImageList;
            if (tabControl1.TabPages.Count > 0)
            {
                
            }
            #endregion


        }

        private void fsPictureBox1_FsClick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("FsClick");
            //MessageBox.Show("add Database");
            Form CreateDataConnectForm = new FormCreateDataConnect();
            DialogResult rs =  CreateDataConnectForm.ShowDialog();
            if (rs == DialogResult.OK) { 
                
            }
            InitTreeView();
        }
        /// <summary>
        /// 删除连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fsDelDbPictureBox1_FsClick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("FsClick");
            //MessageBox.Show("del Database");
            TreeNode selectNode =  treeView1.SelectedNode;
            if(selectNode == null)
            {
                MessageBox.Show("请选择连接节点");
                return;
            }
            DialogResult rs =  MessageBox.Show("确认删除该连接吗?","提示", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                int cnt = bllFsDatabase.Delete(a => a.DatabaseName == selectNode.Text);
                if (cnt > 0)
                {
                    InitTreeView();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        /// <summary>
        /// 对 服务器节点右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                TreeNode node =  treeView1.SelectedNode;
                if(node == null)
                {
                    return;
                }
                if(node.Text == "服务器")
                {
                    //根节点
                    this.rootTreeNodeContextMenuStrip1.Show(treeView1,e.Location);
                }
                else if(node.SelectedImageIndex == 0)
                {
                    //连接节点
                    this.conctContextMenuStrip1.Show(treeView1,e.Location);
                }else if(node.SelectedImageIndex == 1)
                {
                    //数据库
                    this.dbContextMenuStrip1.Show(treeView1, e.Location);
                }
                else if (node.SelectedImageIndex == 2)
                {
                    //数据表
                    this.tableContextMenuStrip1.Show(treeView1, e.Location);
                }
            }
        }

        /// <summary>
        /// 双击 节点树
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                return;
            }
            if(node.Text == "服务器")
            {
                return;
            }
            if(node.ImageIndex == 0)
            {//打开连接
                if (node.Nodes.Count > 0)
                {
                    return;
                }
                conctConnectToolStripMenuItem_Click(sender, e);
            }else if(node.ImageIndex == 1)
            {//打开数据库
                if (node.Nodes.Count > 0)
                {
                    return;
                }
                openDBToolStripMenuItem_Click(sender,e);
            }else if(node.ImageIndex == 2)
            {//打开表

            }
        }

        /// <summary>
        /// 根节点刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rootTreeNodeReToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitTreeView();
        }
        /// <summary>
        /// TreeNode 关闭连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void conctCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node= treeView1.SelectedNode;
            if(node == null )
            {
                return;
            }
            treeView1.BeginUpdate();
            node.Nodes.Clear();
            treeView1.EndUpdate();
            FsDatabase fsDatabase = (FsDatabase)node.Tag;
            Context.ContextUtils.DelDBConnect(fsDatabase.DBKey);
            CloseResourceClear();
        }

        private void CloseResourceClear()
        {
            dataGridViewTop1.Rows.Clear();
            tabPage1.Text = "";
            tabPage1.ToolTipText = "";

            genCodeRichTextBox1.Text = "";
            selectTableNode = null;
            listFileInfo.Clear();
        }

        /// <summary>
        /// TreeNode 打开节点连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void conctConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                return;
            }
            FormLoading formLoading = null;
            ThreadPool.QueueUserWorkItem(new WaitCallback(a => {
                this.Invoke(() => {
                    formLoading = new FormLoading("正在连接数据库...");
                    formLoading.ShowDialog();
                });
            }));
            treeView1.BeginUpdate();
            FsDatabase fsDatabase = (FsDatabase)node.Tag;
            EnumDatabase enumDatabase = EnumDatabase.Mysql;
            if (fsDatabase.DBType.ToLower() == EnumDatabase.Mysql.GetDescription().ToLower())
            {
                enumDatabase = EnumDatabase.Mysql;
            }
            else if (fsDatabase.DBType.ToLower() == EnumDatabase.Sqlserver.GetDescription().ToLower())
            {
                enumDatabase = EnumDatabase.Sqlserver;
            }
            if (fsDatabase.DBType.ToLower() == EnumDatabase.SqlLite.GetDescription().ToLower())
            {
                enumDatabase = EnumDatabase.SqlLite;
            }
            node.Nodes.Clear();

            //建立连接
            //查询连接的数据库列表
            Context.DBConnect dBConnect = Context.ContextUtils.CreateConnectDB(enumDatabase, fsDatabase.ConnectString);
            if (dBConnect.TestConnect())
            {
                List<string> dbNameList = dBConnect.GetDataBases();
                foreach (var item in dbNameList)
                {
                    TreeNode childNode = new TreeNode(item, 1, 1);
                    childNode.Tag = node.Tag;
                    node.Nodes.Add(childNode);
                }
                treeView1.EndUpdate();
                node.ExpandAll();
            }
            else
            {
                treeView1.EndUpdate();
                MessageBox.Show("数据库连接失败!" + dBConnect.GetException());
            }
            this.Invoke(new Action(() => {
                formLoading?.Close();
            }));
        }
        /// <summary>
        /// 打开数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                return;
            }
            FormLoading formLoading  = null;
            ThreadPool.QueueUserWorkItem(new WaitCallback(a => {
                this.Invoke((Action)(() =>
                {
                    formLoading = new FormLoading("");
                    formLoading.ShowDialog();
                }));
            }));
            treeView1.BeginUpdate();
            node.Nodes.Clear();

            FsDatabase fsDatabase = (FsDatabase)node.Tag;
            Context.DBConnect dBConnect = Context.ContextUtils.GetDBConnect(fsDatabase.DBKey);
            //查询数据库下的所有表
            List<string> lst = dBConnect.GetTablesBy(node.Text);
            foreach (var item in lst)
            {
                TreeNode tableNode = new TreeNode(item, 2, 2);
                tableNode.Tag = node.Tag;
                node.Nodes.Add(tableNode);
            }
            treeView1.EndUpdate();
            node.ExpandAll();
            this.Invoke((Action)delegate () { formLoading?.Close(); });
        }
        /// <summary>
        /// 关闭数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dbCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                return;
            }
            treeView1.BeginUpdate();
            node.Nodes.Clear();
            treeView1.EndUpdate();
            CloseResourceClear();
        }

        private List<FileInfo> listFileInfo = new List<FileInfo>();
        delegate void DelegateMethod(int a);


        TreeNode? selectTableNode;

        /// <summary>
        /// 代码生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modelGenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取表信息
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                return;
            }
            tabPage1.Select();
            tabControl1.SelectedTab = tabPage1;
            selectTableNode = null;
            listFileInfo.Clear();

            FormLoading frmLoading = null;
            ThreadPool.QueueUserWorkItem(new WaitCallback(a =>
            {
                this.Invoke((Action)delegate ()
                {
                    frmLoading = new FormLoading("正在生成中，请稍后.....");
                    frmLoading.ShowDialog();
                });
            }));

            FsDatabase fsDatabase = (FsDatabase)node.Tag;
            DBConnect dBConnect = ContextUtils.GetDBConnect(fsDatabase.DBKey);
            if (dBConnect.TestConnect())
            {
                selectTableNode = node;

                TreeNode parentNode = node.Parent;
                dataGridViewTop1.Rows.Clear();
                string selTable = parentNode.Text + "." + node.Text;
                List<List<string>> listCols = dBConnect.GetColInfos(selTable);
                foreach(List<string> colInfo in listCols)
                {
                    dataGridViewTop1.Rows.Add(colInfo.ToArray());
                }
                //选项卡
                tabPage1.Text = "单表代码生成："+selTable;
                tabPage1.ToolTipText= selTable;

                selectTempleteComboBox1.Items.Clear();


                Task.Run(() => {
                    FileInfo[] fileInfos = FileUtil.loadTemplates("");
                    var deleteMethod1 = new DelegateMethod((a) => {
                        this.selectTempleteComboBox1.Items.Insert(a, fileInfos[a].Name);
                    });
                    for (int i = 0; i < fileInfos.Length; i++)
                    {
                        this.selectTempleteComboBox1.Invoke(deleteMethod1,i);
                        listFileInfo.Add(fileInfos[i]);
                    }
                    if (fileInfos.Length > 0 && this.selectTempleteComboBox1.Items.Count>0)
                    {
                        this.selectTempleteComboBox1.Invoke(() => {
                            this.selectTempleteComboBox1.SelectedItem = this.selectTempleteComboBox1.Items[0];
                            string htmlTemplate = File.ReadAllText(fileInfos[0].FullName);
                            this.genCodeRichTextBox1.Text = htmlTemplate;
                        });
                    }
                    
                });
            }
            else
            {
                MessageBox.Show("数据库连接不可用!"+dBConnect.GetException());
                return;
            }
            this.Invoke((Action)delegate () { frmLoading?.Close(); });
        }


        /// <summary>
        /// 多表代码生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mulTableGenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage2.Select();
            tabControl1.SelectedTab = tabPage2;
        }

        /// <summary>
        /// 选择模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectTempleteComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = selectTempleteComboBox1.SelectedItem as string;
            FileInfo fileInfo = listFileInfo.Where(a => a.Name == fileName).FirstOrDefault();
            if (fileInfo != null)
            {
                string htmlTemplate = File.ReadAllText(fileInfo.FullName);
                this.genCodeRichTextBox1.Text = htmlTemplate;
            }
        }

        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genCodeButton1_Click(object sender, EventArgs e)
        {
            if(selectTableNode == null)
            {
                MessageBox.Show("请选择数据表");
                return;
            }
            if (string.IsNullOrWhiteSpace(namespaceText.Text))
            {
                MessageBox.Show("请输入命名空间");
                return;
            }
            if(listFileInfo.Count == 0)
            {
                MessageBox.Show("请选择模板");
                return;
            }
            FsDatabase database = (FsDatabase)selectTableNode.Tag;
            TaskBuild task = ContextUtils.CreateTaskBuild(database.DBKey,selectTableNode.Parent.Text);
            task.tableName = selectTableNode.Text;
            task.FileName = selectTempleteComboBox1.SelectedText;
            task.NamespaceName = namespaceText.Text;
            task.FilterTableChar = filterTablenameText.Text;
            task.FirstUpper = firstCharUpperCheckBox1.Checked;
            task.AllLower = allLowerCheckBox1.Checked;
            task.UnderLineTranser = underLineToCheckBox2.Checked;
            task.Templates = new Template[] { new Template() {
                TemplatePath = selectTempleteComboBox1.SelectedItem as string,
                TemplateText = genCodeRichTextBox1.Text,
                IsChangeText = false,
            } };
            FormShowGenCode formShowGenCode = new FormShowGenCode(listFileInfo, task);
            DialogResult rs =  formShowGenCode.ShowDialog();
            if(rs == DialogResult.OK)
            {

            }
        }
    }
}