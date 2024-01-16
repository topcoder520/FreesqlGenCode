namespace FreesqlGenCode
{
    partial class FormTableNoteInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DbType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsShowQuery = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ForeignColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectForeign = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.aliasTextBox1 = new System.Windows.Forms.TextBox();
            this.allCheckBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.DbType,
            this.Comment,
            this.IsShowQuery,
            this.ForeignColumn,
            this.selectForeign});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 445);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "字段名";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 150;
            // 
            // DbType
            // 
            this.DbType.HeaderText = "类型";
            this.DbType.MinimumWidth = 8;
            this.DbType.Name = "DbType";
            this.DbType.ReadOnly = true;
            this.DbType.Width = 150;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "注释";
            this.Comment.MinimumWidth = 8;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 150;
            // 
            // IsShowQuery
            // 
            this.IsShowQuery.FalseValue = "false";
            this.IsShowQuery.HeaderText = "查询";
            this.IsShowQuery.MinimumWidth = 8;
            this.IsShowQuery.Name = "IsShowQuery";
            this.IsShowQuery.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsShowQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsShowQuery.TrueValue = "true";
            this.IsShowQuery.Width = 150;
            // 
            // ForeignColumn
            // 
            this.ForeignColumn.HeaderText = "外键字段";
            this.ForeignColumn.MinimumWidth = 8;
            this.ForeignColumn.Name = "ForeignColumn";
            this.ForeignColumn.ReadOnly = true;
            this.ForeignColumn.Width = 200;
            // 
            // selectForeign
            // 
            this.selectForeign.HeaderText = "操作";
            this.selectForeign.MinimumWidth = 8;
            this.selectForeign.Name = "selectForeign";
            this.selectForeign.ReadOnly = true;
            this.selectForeign.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selectForeign.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.selectForeign.Text = "设置";
            this.selectForeign.ToolTipText = "设置外键字段";
            this.selectForeign.UseColumnTextForButtonValue = true;
            this.selectForeign.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 42);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.aliasTextBox1);
            this.flowLayoutPanel1.Controls.Add(this.allCheckBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 42);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alias：";
            // 
            // aliasTextBox1
            // 
            this.aliasTextBox1.Location = new System.Drawing.Point(78, 9);
            this.aliasTextBox1.Name = "aliasTextBox1";
            this.aliasTextBox1.Size = new System.Drawing.Size(213, 30);
            this.aliasTextBox1.TabIndex = 3;
            // 
            // allCheckBox1
            // 
            this.allCheckBox1.AutoSize = true;
            this.allCheckBox1.Location = new System.Drawing.Point(317, 9);
            this.allCheckBox1.Margin = new System.Windows.Forms.Padding(23, 3, 3, 3);
            this.allCheckBox1.Name = "allCheckBox1";
            this.allCheckBox1.Size = new System.Drawing.Size(108, 28);
            this.allCheckBox1.TabIndex = 4;
            this.allCheckBox1.Text = "全部查询";
            this.allCheckBox1.UseVisualStyleBackColor = true;
            this.allCheckBox1.CheckedChanged += new System.EventHandler(this.allCheckBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(880, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 445);
            this.panel2.TabIndex = 2;
            // 
            // FormTableNoteInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormTableNoteInfo";
            this.Text = "节点信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox aliasTextBox1;
        private CheckBox allCheckBox1;
        private Button button1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn DbType;
        private DataGridViewTextBoxColumn Comment;
        private DataGridViewCheckBoxColumn IsShowQuery;
        private DataGridViewTextBoxColumn ForeignColumn;
        private DataGridViewButtonColumn selectForeign;
    }
}