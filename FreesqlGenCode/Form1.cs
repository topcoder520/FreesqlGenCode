using BLL;
using Common;
using Context;
using DataDefine;
using FreesqlGenCode.controls;
using Model;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FreesqlGenCode
{
    public partial class Form1 : Form
    {
        private BllFsDatabase bllFsDatabase = new BllFsDatabase();

        public Form1()
        {
            InitializeComponent();
            InitTreeView();
            InitTabControl();
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
        }

        private void InitTabControl() {
            #region 初始化tabControl
            ImageList tabImageList = new ImageList();
            tabImageList.Images.Add(Properties.Resources.close);
            tabControl1.ImageList = tabImageList;
            //tabControl1.TabPages.Clear();
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
            //暂时
            tabControl1.TabPages.Clear();
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

            tabControl1.TabPages.Clear();
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
            tabControl1.TabPages.Clear();
        }

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

            FormLoading frmLoading = null;
            ThreadPool.QueueUserWorkItem(new WaitCallback(a =>
            {
                this.Invoke((Action)delegate ()
                {
                    frmLoading = new FormLoading("正在生成中，请稍后.....");
                    frmLoading.ShowDialog();
                });
            }));

            FileInfo[] fileInfos = FileUtil.loadTemplates("");

            FsDatabase fsDatabase = (FsDatabase)node.Tag;
            DBConnect dBConnect = ContextUtils.GetDBConnect(fsDatabase.DBKey);
            if (dBConnect.TestConnect())
            {
                TreeNode parentNode = node.Parent;
                string selTable = parentNode.Text + "." + node.Text;
                List<List<string>> listCols = dBConnect.GetColInfos(selTable);
                TabPageTag tag = new TabPageTag();
                tag.DBKey = fsDatabase.DBKey;
                tag.TableName = selTable;
                tag.fsDatabase = fsDatabase;
                tag.treeNodeTableNode = node;
                openSingleTableTabPage(listCols,tag,fileInfos);
            }
            else
            {
                MessageBox.Show("数据库连接不可用!"+dBConnect.GetException());
                return;
            }
            this.Invoke((Action)delegate () { 
                frmLoading?.Close(); 
            });
            treeView1.SelectedNode = node;
        }

        private void openSingleTableTabPage(List<List<string>> listCols, TabPageTag tag, FileInfo[] fileInfos)
        {
            int cntPages = tabControl1.TabPages.Count;
            TabPage? tabPage = null;
            for (int i = 0; i < cntPages; i++)
            {
                TabPage next = tabControl1.TabPages[i];
                TabPageTag nextTag = (TabPageTag)next.Tag;
                if(nextTag.DBKey == tag.DBKey && nextTag.TableName == tag.TableName)
                {
                    tabPage = next;
                    break;
                }
            }
            if(tabPage == null)
            {
                tabPage = new TabPage();
                MySingleControl.listFileInfo = fileInfos.ToList();
                MySingleControl mySingleControl = new MySingleControl();
                mySingleControl.Dock = System.Windows.Forms.DockStyle.Fill;
                mySingleControl.Location = new System.Drawing.Point(0, 0);
                mySingleControl.Name = "mySingleControl";
                mySingleControl.Padding = new System.Windows.Forms.Padding(3);
                mySingleControl.TabIndex = 0;
                tabPage.Controls.Add(mySingleControl);
                tabPage.Text = "单表 "+tag.TableName;
                tabPage.ToolTipText = tabPage.Text;
                foreach (List<string> colInfo in listCols)
                {
                    mySingleControl.dataGridViewTop1.Rows.Add(colInfo.ToArray());
                }
                tabPage.Tag = tag;
                tabControl1.TabPages.Add(tabPage);
            }
            tabControl1.SelectedTab= tabPage;
        }


        /// <summary>
        /// 多表代码生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mulTableGenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tabPage2.Select();
            //tabControl1.SelectedTab = tabPage2;
        }

       
    }

    class TabPageTag
    {
        public string DBKey { get; set; }

        public string TableName { get; set; }

        public FsDatabase fsDatabase { get; set; }

        public TreeNode treeNodeTableNode { get; set; }
    }
}