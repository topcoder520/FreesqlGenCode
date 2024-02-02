using BLL;
using Common;
using Context;
using DataDefine;
using FreesqlGenCode.controls;
using FreesqlGenCode.DataConn;
using Model;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FreesqlGenCode
{
    public partial class Form1 : Form
    {
        private readonly BllFsDatabase bllFsDatabase = new BllFsDatabase();
        private readonly BllFsTableNode bllFsTableNode = new BllFsTableNode();
        private readonly BllFsQueryView bllFsQueryView = new BllFsQueryView();

        public Form1()
        {
            InitializeComponent();
            InitTreeView("init");
            InitTabControl();
        }

        /// <summary>
        /// 初始化TreeNode
        /// </summary>
        private void InitTreeView(string initFlag="init")
        {
            #region 初始化树形节点
            if(initFlag == "init")
            {
                ImageList imageList = new ImageList();
                imageList.Images.Add(Properties.Resources.monitor);
                imageList.Images.Add(Properties.Resources.database);
                imageList.Images.Add(Properties.Resources.application3);

                List<FsDatabase> listData = bllFsDatabase.GetList(a => a.State == (int)EnumState.Normal);
                treeView1.BeginUpdate();
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

                firstPageListView1.SmallImageList = imageList;
            }
            else
            {
                List<FsDatabase> listData = bllFsDatabase.GetList(a => a.State == (int)EnumState.Normal);
                List<TreeNode> newData = new List<TreeNode>();
                TreeNode root = treeView1.Nodes[0];
                foreach (var item in listData)
                {
                    bool exist = false;
                    for (int i = 0; i < root.Nodes.Count; i++)
                    {
                        FsDatabase fsDB = root.Nodes[i].Tag as FsDatabase;
                        if(item.DBKey == fsDB.DBKey)
                        {
                            exist = true;
                            break;
                        }
                    }
                    if (!exist)
                    {
                        TreeNode treeNode = new TreeNode(item.DatabaseName + $"({item.DBType})", 0, 0);
                        treeNode.Tag = item;
                        newData.Add(treeNode);
                    }
                }
                if (newData.Count > 0)
                {
                    root.Nodes.AddRange(newData.ToArray());
                }
                for (int i = 0; i < root.Nodes.Count; i++)
                {
                    TreeNode conctNode = root.Nodes[i];
                    conctNode.Collapse();
                }
            }

            #endregion

        }

        private void InitTabControl() {
            #region 初始化tabControl
            ImageList tabImageList = new ImageList();
            tabImageList.Images.Add(Properties.Resources.close);
            tabControl1.ImageList = tabImageList;
            
            #endregion
        }
        /// <summary>
        /// 添加数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fsPictureBox1_FsClick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("FsClick");
            //MessageBox.Show("add Database");
            FormSelectDB formSelectDB = new FormSelectDB();
            formSelectDB.SelectDBChanged += new EventHandler<EventArgs>((object? sender,EventArgs e) => {
                formSelectDB.Close();
                string dbType = sender as string;
                if(dbType == "mysql")
                {
                    FormConnMysql connMysql = new FormConnMysql();
                    connMysql.SaveDataHandler += new EventHandler((object? sender,EventArgs e) =>
                    {
                        InitTreeView("NotInit");
                        ClearTabPages("");
                    });
                    connMysql.ShowDialog();
                }else if(dbType == "sqlserver")
                {
                    FormConnSqlserver connSqlserver = new FormConnSqlserver();
                    connSqlserver.SaveDataHandler += new EventHandler((object? sender, EventArgs e) =>
                    {
                        InitTreeView("NotInit");
                        ClearTabPages("");
                    });
                    connSqlserver.ShowDialog();
                }
            });
            formSelectDB.Show();
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
                MessageBox.Show("请选择数据库连接");
                return;
            }
            FsDatabase fsDatabase = (FsDatabase)selectNode.Tag;
            string fsText = fsDatabase.DatabaseName + $"({fsDatabase.DBType})";
            if(fsText != selectNode.Text || selectNode.SelectedImageIndex > 0)
            {//只删除数据库连接节点
                MessageBox.Show("请选择数据库连接");
                return;
            }
            DialogResult rs =  MessageBox.Show("确认删除该连接吗?","提示", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                string connName = selectNode.Text.Substring(0,selectNode.Text.LastIndexOf('('));
                int cnt = bllFsDatabase.Delete(a => a.DatabaseName == connName && a.State == (int)EnumState.Normal);
                if (cnt > 0)
                {
                    treeView1.Nodes.Remove(selectNode);
                    Context.ContextUtils.DelDBConnect(fsDatabase.DBKey);
                    InitTreeView("NotInit");
                    ClearTabPages(fsDatabase.DBKey);

                    //首页内容清除
                    firstPageListView1.BeginUpdate();
                    firstPageListView1.Items.Clear();
                    firstPageListView1.EndUpdate();
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
                    if(node.Nodes.Count > 0)
                    {
                        conctConnectToolStripMenuItem.Visible = false;
                        conctCloseToolStripMenuItem.Visible = true;
                        conctDelToolStripMenuItem.Visible = false;
                    }
                    else
                    {
                        conctConnectToolStripMenuItem.Visible = true;
                        conctCloseToolStripMenuItem.Visible = false;
                        conctDelToolStripMenuItem.Visible = true;
                    }
                    this.conctContextMenuStrip1.Show(treeView1,e.Location);
                }else if(node.SelectedImageIndex == 1)
                {
                    //数据库
                    if (node.Nodes.Count > 0)
                    {
                        openDBToolStripMenuItem.Visible = false;
                        refreshDBToolStripMenuItem.Visible = true;
                        //dbCloseToolStripMenuItem.Visible = true;
                        mulTableToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        openDBToolStripMenuItem.Visible = true;
                        refreshDBToolStripMenuItem.Visible = false;
                       // dbCloseToolStripMenuItem.Visible = false;
                        mulTableToolStripMenuItem.Visible = true;
                    }
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
            InitTreeView("NotInit");
            //暂时
            //ClearTabPages("");
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

            ClearTabPages(fsDatabase.DBKey);
        }

        private void ClearTabPages(string DBKey,string DataBase="")
        {
            int count = tabControl1.TabPages.Count;
            for (int i = count -1; i >0; i--)
            {
                if (!string.IsNullOrWhiteSpace(DBKey) && !string.IsNullOrWhiteSpace(DataBase))
                {//刪除数据库相关的tabpage
                    TabPage tabPage = tabControl1.TabPages[i];
                    if (tabPage.Tag != null && tabPage.Tag is not TabPageTag)
                    {
                        continue;
                    }
                    TabPageTag tag = tabPage.Tag as TabPageTag;
                    TreeNode dataBaseNode = tag.treeNodeTableNode.Parent;
                    if (tag.DBKey == DBKey && DataBase == dataBaseNode.Text)
                    {
                        tabControl1.TabPages.RemoveAt(i);
                    }
                }
                else if (!string.IsNullOrWhiteSpace(DBKey))
                {//删除连接相关的tabpage
                    TabPage tabPage = tabControl1.TabPages[i];
                    if (tabPage.Tag != null && tabPage.Tag is not TabPageTag)
                    {
                        continue;
                    }
                    TabPageTag tag = tabPage.Tag as TabPageTag;
                    if (tag.DBKey == DBKey)
                    {
                        tabControl1.TabPages.RemoveAt(i);
                    }
                }
                else
                {//删除所有tabpage
                    tabControl1.TabPages.RemoveAt(i);
                }
            }
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
            //建立连接
            //查询连接的数据库列表
            Context.DBConnect dBConnect = Context.ContextUtils.CreateConnectDB(enumDatabase, fsDatabase.DBKey, fsDatabase.ConnectString);
            if (dBConnect.TestConnect())
            {
                this.ShowLoadingAsync("正在加载数据...", (control) => {
                    List<string> dbNameList = dBConnect.GetDataBases();
                    control.Invoke(() => {
                        treeView1.BeginUpdate();
                        node.Nodes.Clear();
                        foreach (var item in dbNameList)
                        {
                            TreeNode childNode = new TreeNode(item, 1, 1);
                            childNode.Tag = node.Tag;
                            node.Nodes.Add(childNode);
                        }
                        treeView1.EndUpdate();
                        node.ExpandAll();
                    });
                    return Task.FromResult(1);
                });
            }
            else
            {
                MessageBox.Show("数据库连接失败!" + dBConnect.GetException());
            }

        }
        /// <summary>
        /// 打开数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void openDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                return;
            }
            FsDatabase fsDatabase = (FsDatabase)node.Tag;
            await this.ShowLoadingAsync("正在加载数据...", (control) =>
            {
                Context.DBConnect dBConnect = Context.ContextUtils.GetDBConnect(fsDatabase.DBKey);
                //查询数据库下的所有表
                List<string> lst = dBConnect.GetTableNamesBy(node.Text);
                control.Invoke(() =>
                {
                    treeView1.BeginUpdate();
                    node.Nodes.Clear();
                    foreach (var item in lst)
                    {
                        TreeNode tableNode = new TreeNode(node.Text+"."+item, 2, 2);
                        tableNode.Tag = node.Tag;
                        node.Nodes.Add(tableNode);
                    }
                    treeView1.EndUpdate();
                    node.ExpandAll();
                });
                return Task.FromResult(1);
            });
            treeView1_AfterSelect(sender,null);
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
            FsDatabase fsDatabase = node.Tag as FsDatabase;
            ClearTabPages(fsDatabase.DBKey,node.Text);
            firstPageListView1.BeginUpdate();
            firstPageListView1.Items.Clear();
            firstPageListView1.EndUpdate();
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
            FsDatabase fsDatabase = (FsDatabase)node.Tag;
            DBConnect dBConnect = ContextUtils.GetDBConnect(fsDatabase.DBKey);
            if (dBConnect.TestConnect())
            {
                this.ShowLoadingAsync("正在加载数据...", (control)=>
                {
                    FileInfo[] fileInfos = FileUtil.loadTemplates("");
                    TreeNode parentNode = node.Parent;
                    string selTable = node.Text;
                    if (!node.Text.StartsWith(parentNode.Text + "."))
                    {
                        selTable = parentNode.Text + "." + node.Text;
                    }
                    List<List<string>> listCols = dBConnect.GetColInfos(selTable);
                    control.Invoke(() =>
                    {
                        TabPageTag tag = new TabPageTag();
                        tag.DBKey = fsDatabase.DBKey;
                        tag.TableName = selTable;
                        tag.fsDatabase = fsDatabase;
                        tag.treeNodeTableNode = node;
                        openSingleTableTabPage(listCols, tag, fileInfos);
                    });
                    return Task.FromResult(1);
                });
            }
            else
            {
                MessageBox.Show("数据库连接不可用!"+dBConnect.GetException());
                return;
            }
        }

        private void openSingleTableTabPage(List<List<string>> listCols, TabPageTag tag, FileInfo[] fileInfos)
        {
            int cntPages = tabControl1.TabPages.Count;
            TabPage? tabPage = null;
            for (int i = 0; i < cntPages; i++)
            {
                TabPage next = tabControl1.TabPages[i];
                if(next.Tag == null || next.Tag is not TabPageTag nextTag)
                {
                    continue;
                }
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
                tabPage.Text = tag.TableName;
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
        /// 数据库 多表代码生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mulTableGenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                return;
            }
            FormBatchGen formBatchGen = new FormBatchGen();
            formBatchGen.conctLabel2.Text = node.Parent.Text;
            formBatchGen.dbNameLabel3.Text = node.Text;
            formBatchGen.Tag = node;
            formBatchGen.ShowDialog();
        }

        /// <summary>
        /// 点击数据库 显示首页数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private  async void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                return;
            }
            if (node.Text == "服务器")
            {
                firstPageListView1.BeginUpdate();
                firstPageListView1.Items.Clear();
                firstPageListView1.EndUpdate();
                return;
            }
            FsDatabase fsDatabase = (FsDatabase)node.Tag;
            if (fsDatabase == null)
            {
                return;
            }
            Context.DBConnect dBConnect = Context.ContextUtils.GetDBConnect(fsDatabase.DBKey);
            if (node.SelectedImageIndex == 0)
            {//数据库连接节点 或者顶级节点
             //清除listview
                if (firstPageListView1.Items.Count == 0) return;
                firstPageListView1.BeginUpdate();
                firstPageListView1.Items.Clear();
                firstPageListView1.EndUpdate();
            }
            else if (node.SelectedImageIndex == 1)
            {//数据库节点
                if (node.Nodes.Count == 0)
                {
                    //数据库没打开 清除listview
                    if (firstPageListView1.Items.Count == 0) return;
                    firstPageListView1.BeginUpdate();
                    firstPageListView1.Items.Clear();
                    firstPageListView1.EndUpdate();
                }
                else
                {
                    //数据库已经打开 显示listview
                    if (firstPageListView1.Items.Count == 0)
                    {
                        this.ShowLoadingAsync("正在加载数据...", (control) =>
                        {
                            List<TableInfo> listTable = dBConnect.GetTablesBy(node.Text);
                            control.Invoke(() =>
                            {
                                firstPageListView1.BeginUpdate();
                                firstPageListView1.Tag = node; //储存数据库节点
                                for (int i = 0; i < listTable.Count; i++)
                                {
                                    TableInfo tableInfo = listTable[i];
                                    ListViewItem viewItem = new ListViewItem(node.Text+"."+tableInfo.Name, 2);
                                    viewItem.SubItems.Add(tableInfo.Schema);
                                    viewItem.SubItems.Add(tableInfo.DbTableType);
                                    viewItem.SubItems.Add(tableInfo.Columns.ToString());
                                    viewItem.SubItems.Add(tableInfo.Indexes.ToString());
                                    viewItem.SubItems.Add(tableInfo.Comment);
                                    firstPageListView1.Items.Add(viewItem);
                                }
                                firstPageListView1.EndUpdate();
                            });
                            return Task.FromResult(1);
                        });
                    }
                    else
                    {
                        TreeNode viewNode = (TreeNode)firstPageListView1.Tag;
                        if (viewNode == null || viewNode.Text != node.Text)
                        {//数据库一样 不用再查数据
                            this.ShowLoadingAsync("正在加载数据...", (control) =>
                            {
                                List<TableInfo> listTable = dBConnect.GetTablesBy(node.Text);
                                control.Invoke(() =>
                                {
                                    firstPageListView1.BeginUpdate();
                                    firstPageListView1.Items.Clear();
                                    firstPageListView1.Tag = node; //储存数据库节点
                                    for (int i = 0; i < listTable.Count; i++)
                                    {
                                        TableInfo tableInfo = listTable[i];
                                        ListViewItem viewItem = new ListViewItem(node.Text+"."+tableInfo.Name, 2);
                                        viewItem.SubItems.Add(tableInfo.Schema);
                                        viewItem.SubItems.Add(tableInfo.DbTableType);
                                        viewItem.SubItems.Add(tableInfo.Columns.ToString());
                                        viewItem.SubItems.Add(tableInfo.Indexes.ToString());
                                        viewItem.SubItems.Add(tableInfo.Comment);
                                        firstPageListView1.Items.Add(viewItem);
                                    }
                                    firstPageListView1.EndUpdate();
                                });
                                return Task.FromResult(1);
                            });
                        }
                    }
                }

            }
            else if (node.SelectedImageIndex == 2)
            {//表节点
             //显示listview
             //数据库已经打开 显示listview
                if (firstPageListView1.Items.Count == 0)
                {
                    this.ShowLoadingAsync("正在加载数据...", (control) =>
                    {
                        List<TableInfo> listTable = dBConnect.GetTablesBy(node.Parent.Text);
                        control.Invoke(() =>
                        {
                            firstPageListView1.BeginUpdate();
                            firstPageListView1.Tag = node.Parent; //储存数据库节点
                            for (int i = 0; i < listTable.Count; i++)
                            {
                                TableInfo tableInfo = listTable[i];
                                ListViewItem viewItem = new ListViewItem(node.Parent.Text+tableInfo.Name, 2);
                                viewItem.SubItems.Add(tableInfo.Schema);
                                viewItem.SubItems.Add(tableInfo.DbTableType);
                                viewItem.SubItems.Add(tableInfo.Columns.ToString());
                                viewItem.SubItems.Add(tableInfo.Indexes.ToString());
                                viewItem.SubItems.Add(tableInfo.Comment);
                                firstPageListView1.Items.Add(viewItem);
                            }
                            firstPageListView1.EndUpdate();
                        });
                        return Task.FromResult(1);
                    });
                }
                else
                {
                    TreeNode viewNode = (TreeNode)firstPageListView1.Tag;
                    if (viewNode == null || viewNode.Text != node.Parent.Text)
                    {//数据库一样 不用再查数据
                        this.ShowLoadingAsync("正在加载数据...", (control) =>
                        {
                            List<TableInfo> listTable = dBConnect.GetTablesBy(node.Parent.Text);
                            control.Invoke(() => {
                                firstPageListView1.BeginUpdate();
                                firstPageListView1.Items.Clear();
                                firstPageListView1.Tag = node.Parent; //储存数据库节点
                                for (int i = 0; i < listTable.Count; i++)
                                {
                                    TableInfo tableInfo = listTable[i];
                                    ListViewItem viewItem = new ListViewItem(node.Parent.Text+"."+tableInfo.Name, 2);
                                    viewItem.SubItems.Add(tableInfo.Schema);
                                    viewItem.SubItems.Add(tableInfo.DbTableType);
                                    viewItem.SubItems.Add(tableInfo.Columns.ToString());
                                    viewItem.SubItems.Add(tableInfo.Indexes.ToString());
                                    viewItem.SubItems.Add(tableInfo.Comment);
                                    firstPageListView1.Items.Add(viewItem);
                                }
                                firstPageListView1.EndUpdate();
                            });
                            return Task.FromResult(1);
                        });
                    }
                }
            }
        }

        /// <summary>
        /// 首页 ListView 右键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstPageListView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Right)
            {
                ListViewItem item =  firstPageListView1.SelectedItems[0];
                if (item != null)
                {
                    listViewContextMenuStrip1.Show(firstPageListView1,e.Location);
                }
            }
        }
        /// <summary>
        /// listview 代码生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = firstPageListView1.SelectedItems[0];
            if (item != null)
            {
                //获取数据库节点
                TreeNode node = firstPageListView1.Tag as TreeNode;
                if (node == null)
                {
                    return;
                }

                FsDatabase fsDatabase = (FsDatabase)node.Tag;
                DBConnect dBConnect = ContextUtils.GetDBConnect(fsDatabase.DBKey);
                if (dBConnect.TestConnect())
                {
                    this.ShowLoadingAsync("正在加载数据...", (control) => {
                        FileInfo[] fileInfos = FileUtil.loadTemplates("");
                        string selTable = item.Text;
                        if (!item.Text.StartsWith(node.Text + "."))
                        {
                            selTable = node.Text + "." + item.Text;
                        }
                        List<List<string>> listCols = dBConnect.GetColInfos(selTable);
                        control.Invoke(() => {
                            TabPageTag tag = new TabPageTag();
                            tag.DBKey = fsDatabase.DBKey;
                            tag.TableName = selTable;
                            tag.fsDatabase = fsDatabase;
                            //获取表节点信息
                            int cntChild = node.Nodes.Count;
                            for (int i = 0; i < cntChild; i++)
                            {
                                TreeNode childNode = node.Nodes[i];
                                if (childNode.Text == item.Text)
                                {
                                    tag.treeNodeTableNode = childNode;
                                    break;
                                }
                            }
                            //开启page
                            openSingleTableTabPage(listCols, tag, fileInfos);
                        });
                        return Task.FromResult(1);
                    });
                }
                else
                {
                    MessageBox.Show("数据库连接不可用!" + dBConnect.GetException());
                    return;
                }
            }
        }
        /// <summary>
        /// 查询代码生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void queryGenCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                return;
            }
            openGenCodeSqlPage(node);
        }

        private void openGenCodeSqlPage(TreeNode node,TreeNode? pNode = null)
        {
            FsDatabase fsDatabase = (FsDatabase)node.Tag;
            TreeNode parentNode = node.Parent;
            if(parentNode == null)
            {
                parentNode = pNode;
            }
            string selTable = node.Text;
            if (!node.Text.StartsWith(parentNode.Text + "."))
            {
                selTable = parentNode.Text + "." + node.Text;
            }
            TabPageTag tag = new TabPageTag();
            tag.DBKey = fsDatabase.DBKey;
            tag.TableName = selTable;
            tag.fsDatabase = fsDatabase;
            tag.treeNodeTableNode = node;
            TabPage tabPage = new TabPage();
            MyGenCodeSqlControl codeControl = new MyGenCodeSqlControl();
            codeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            codeControl.Location = new System.Drawing.Point(0, 0);
            codeControl.Name = "gencodesqlControl";
            codeControl.Padding = new System.Windows.Forms.Padding(3);
            codeControl.TabIndex = 0;
            codeControl.fsShowTables1.Tag = node;
            codeControl.SaveViewNodeTreeEvent += new EventHandler((object? sender,EventArgs e) =>
            {
                //保存节点树
                if(sender == null)
                {
                    return;
                }
                int QueryViewId = (int)sender;
                //删除所有节点
                bllFsTableNode.DeleteReal(QueryViewId);
                //重新添加所有节点
                Dictionary<int, List<FsTableControl>> pairs = codeControl.fsShowTables1.GetDictNotes();
                if (pairs.Count > 0)
                {
                    Dictionary<int,int> keyValues= new Dictionary<int,int>();
                    for (int i = 0; i < pairs.Count; i++)
                    {
                        List<FsTableControl> fsTables = pairs[i];
                        foreach(FsTableControl node in fsTables)
                        {
                            int ParentNodeId =0;
                            if(node.PrevNode!= null)
                            {
                                keyValues.TryGetValue(node.PrevNode.TableId, out ParentNodeId);
                            }
                            FsLine fsLine = node.Tag as FsLine;
                            int nodeId =  bllFsTableNode.Add(new FsTableNode() { 
                                ParentId = ParentNodeId,
                                NodeName = node.Text,
                                TableName = fsLine.EndTable,
                                TableNameAlias = fsLine.EndTableAlias,
                                TableColumn = fsLine.EndColumn,
                                ParentTableName = fsLine.StartTable,
                                ParentTableNameAlias = fsLine.StartTableAlias,
                                ParentTableColumn= fsLine.StartColumn,
                                JoinType = (int)fsLine.JoinType,
                                QueryViewId = QueryViewId,
                                Col = node.Col,
                                LocationX = node.Location.X,
                                LocationY = node.Location.Y,
                                QueryFields = string.Join(",", node.QueryFields.ToArray()),
                                State = (int)EnumState.Normal
                            });
                            keyValues.Add(node.TableId,nodeId);
                        }
                    }
                }
                FsQueryView fsQueryView = bllFsQueryView.GetModel(QueryViewId);
                MessageBox.Show("保存成功!");
            });
            codeControl.RefreshDataOfQueryViewListBoxEvent += new EventHandler((object? sender,EventArgs e) => {
                MyGenCodeSqlControl myGenCodeSql = (MyGenCodeSqlControl)sender;
                myGenCodeSql.queryViewListBox1.Items.Clear();
                List<FsQueryView> fsQueries = bllFsQueryView.GetList(a=>a.State == (int)EnumState.Normal 
                    && a.DBKey == fsDatabase.DBKey && a.DBName == parentNode.Text);
                myGenCodeSql.queryViewListBox1.Items.AddRange(fsQueries.Select(a=>a.QueryName).ToArray());
            });
            codeControl.SelectedQueryItemEvent += new Func<string, int>((selectedItemText) =>
            {
                FsQueryView fsQuery = bllFsQueryView.GetModel(a => a.DBKey == fsDatabase.DBKey && a.DBName == parentNode.Text && a.QueryName == selectedItemText && a.State == (int)EnumState.Normal);
                if(fsQuery != null)
                {
                    Task.Run(() =>
                    {
                        List<FsTableNode> lstNode = bllFsTableNode.GetList(a => a.QueryViewId == fsQuery.Id && a.State == (int)EnumState.Normal, null, " Col ASC ");
                        if (lstNode.Count > 0)
                        {
                            codeControl.fsShowTables1.Invoke(() =>
                            {
                                codeControl.fsShowTables1.ClearNodes();
                                foreach (var item in lstNode)
                                {
                                    codeControl.fsShowTables1.CreateTableComtrol(item);
                                }
                                codeControl.fsShowTables1.Invalidate();
                            });
                        }
                    });
                    return fsQuery.Id;
                }
                return 0;
            });
            codeControl.DelQueryViewEvent += new EventHandler((queryViewId, e) =>
            {
                FsQueryView fsQuery = bllFsQueryView.GetModel(a => a.Id == (int)queryViewId && a.State == (int)EnumState.Normal);
                if (fsQuery != null)
                {
                    bllFsQueryView.Delete(fsQuery.Id);
                    codeControl.queryViewListBox1.Items.Remove(fsQuery.QueryName);
                    codeControl.fsShowTables1.ClearNodes();
                }
            });
            if (pNode == null)
            {
                FsTableControl fsTable = new FsTableControl();
                fsTable.Text = selTable;
                fsTable.Col = 0;
                codeControl.fsShowTables1.AddTableControl(fsTable);
            }
            tabPage.Controls.Add(codeControl);
            tabPage.Text = selTable;
            tabPage.ToolTipText = selTable;
            tabPage.Tag = tag;
            tabControl1.TabPages.Add(tabPage);
            tabControl1.SelectedTab = tabPage;
        }
        /// <summary>
        /// 查询生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void queryViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;//数据库节点
            if (node == null)
            {
                return;
            }
            FsDatabase fsDatabase = node.Tag as FsDatabase;
            TreeNode parentNode = new TreeNode();
            parentNode.Text = node.Text;
            TreeNode treeNode = new TreeNode();
            treeNode.Tag = fsDatabase;
            openGenCodeSqlPage(treeNode,parentNode);
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