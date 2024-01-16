namespace FreesqlGenCode
{
    partial class FormSelectTableColumns
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
            this.topPanel1 = new System.Windows.Forms.Panel();
            this.rightPanel1 = new System.Windows.Forms.Panel();
            this.columnLabel4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aliasTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableNameLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.centerPanel1 = new System.Windows.Forms.Panel();
            this.columnListBox1 = new System.Windows.Forms.ListBox();
            this.leftPanel1 = new System.Windows.Forms.Panel();
            this.tableListBox1 = new System.Windows.Forms.ListBox();
            this.bottomPanel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.joinTableColumnRow1 = new FreesqlGenCode.controls.JoinTableColumnRow();
            this.joinTableColumnRow2 = new FreesqlGenCode.controls.JoinTableColumnRow();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.topPanel1.SuspendLayout();
            this.rightPanel1.SuspendLayout();
            this.centerPanel1.SuspendLayout();
            this.leftPanel1.SuspendLayout();
            this.bottomPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel1
            // 
            this.topPanel1.Controls.Add(this.rightPanel1);
            this.topPanel1.Controls.Add(this.centerPanel1);
            this.topPanel1.Controls.Add(this.leftPanel1);
            this.topPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel1.Location = new System.Drawing.Point(0, 0);
            this.topPanel1.Name = "topPanel1";
            this.topPanel1.Size = new System.Drawing.Size(952, 281);
            this.topPanel1.TabIndex = 0;
            // 
            // rightPanel1
            // 
            this.rightPanel1.BackColor = System.Drawing.Color.White;
            this.rightPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel1.Controls.Add(this.columnLabel4);
            this.rightPanel1.Controls.Add(this.label2);
            this.rightPanel1.Controls.Add(this.aliasTextBox1);
            this.rightPanel1.Controls.Add(this.label3);
            this.rightPanel1.Controls.Add(this.tableNameLabel2);
            this.rightPanel1.Controls.Add(this.label1);
            this.rightPanel1.Controls.Add(this.button1);
            this.rightPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel1.Location = new System.Drawing.Point(542, 0);
            this.rightPanel1.Name = "rightPanel1";
            this.rightPanel1.Size = new System.Drawing.Size(410, 281);
            this.rightPanel1.TabIndex = 2;
            // 
            // columnLabel4
            // 
            this.columnLabel4.AutoSize = true;
            this.columnLabel4.Location = new System.Drawing.Point(77, 107);
            this.columnLabel4.Name = "columnLabel4";
            this.columnLabel4.Size = new System.Drawing.Size(0, 24);
            this.columnLabel4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "表字段：";
            // 
            // aliasTextBox1
            // 
            this.aliasTextBox1.Location = new System.Drawing.Point(62, 54);
            this.aliasTextBox1.Name = "aliasTextBox1";
            this.aliasTextBox1.Size = new System.Drawing.Size(257, 30);
            this.aliasTextBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alias：";
            // 
            // tableNameLabel2
            // 
            this.tableNameLabel2.AutoSize = true;
            this.tableNameLabel2.Location = new System.Drawing.Point(77, 15);
            this.tableNameLabel2.Name = "tableNameLabel2";
            this.tableNameLabel2.Size = new System.Drawing.Size(0, 24);
            this.tableNameLabel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择表:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // centerPanel1
            // 
            this.centerPanel1.Controls.Add(this.columnListBox1);
            this.centerPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.centerPanel1.Location = new System.Drawing.Point(323, 0);
            this.centerPanel1.Name = "centerPanel1";
            this.centerPanel1.Size = new System.Drawing.Size(219, 281);
            this.centerPanel1.TabIndex = 1;
            // 
            // columnListBox1
            // 
            this.columnListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnListBox1.FormattingEnabled = true;
            this.columnListBox1.ItemHeight = 24;
            this.columnListBox1.Location = new System.Drawing.Point(0, 0);
            this.columnListBox1.Name = "columnListBox1";
            this.columnListBox1.Size = new System.Drawing.Size(219, 281);
            this.columnListBox1.TabIndex = 0;
            this.columnListBox1.SelectedIndexChanged += new System.EventHandler(this.columnListBox1_SelectedIndexChanged);
            // 
            // leftPanel1
            // 
            this.leftPanel1.Controls.Add(this.tableListBox1);
            this.leftPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel1.Location = new System.Drawing.Point(0, 0);
            this.leftPanel1.Name = "leftPanel1";
            this.leftPanel1.Size = new System.Drawing.Size(323, 281);
            this.leftPanel1.TabIndex = 0;
            // 
            // tableListBox1
            // 
            this.tableListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableListBox1.FormattingEnabled = true;
            this.tableListBox1.ItemHeight = 24;
            this.tableListBox1.Location = new System.Drawing.Point(0, 0);
            this.tableListBox1.Name = "tableListBox1";
            this.tableListBox1.Size = new System.Drawing.Size(323, 281);
            this.tableListBox1.TabIndex = 0;
            this.tableListBox1.SelectedIndexChanged += new System.EventHandler(this.tableListBox1_SelectedIndexChanged);
            // 
            // bottomPanel1
            // 
            this.bottomPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bottomPanel1.Controls.Add(this.flowLayoutPanel1);
            this.bottomPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel1.Location = new System.Drawing.Point(0, 281);
            this.bottomPanel1.Name = "bottomPanel1";
            this.bottomPanel1.Size = new System.Drawing.Size(952, 279);
            this.bottomPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.joinTableColumnRow1);
            this.flowLayoutPanel1.Controls.Add(this.joinTableColumnRow2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(952, 279);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // joinTableColumnRow1
            // 
            this.joinTableColumnRow1.BackColor = System.Drawing.SystemColors.Control;
            this.joinTableColumnRow1.Location = new System.Drawing.Point(3, 13);
            this.joinTableColumnRow1.Name = "joinTableColumnRow1";
            this.joinTableColumnRow1.Size = new System.Drawing.Size(949, 50);
            this.joinTableColumnRow1.TabIndex = 0;
            // 
            // joinTableColumnRow2
            // 
            this.joinTableColumnRow2.Location = new System.Drawing.Point(3, 69);
            this.joinTableColumnRow2.Name = "joinTableColumnRow2";
            this.joinTableColumnRow2.Size = new System.Drawing.Size(949, 41);
            this.joinTableColumnRow2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 63);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Location = new System.Drawing.Point(801, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormSelectTableColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bottomPanel1);
            this.Controls.Add(this.topPanel1);
            this.MaximizeBox = false;
            this.Name = "FormSelectTableColumns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSelectTableColumns";
            this.topPanel1.ResumeLayout(false);
            this.rightPanel1.ResumeLayout(false);
            this.rightPanel1.PerformLayout();
            this.centerPanel1.ResumeLayout(false);
            this.leftPanel1.ResumeLayout(false);
            this.bottomPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel topPanel1;
        private Panel bottomPanel1;
        private Panel centerPanel1;
        private Panel leftPanel1;
        private ListBox tableListBox1;
        private ListBox columnListBox1;
        private Panel rightPanel1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private controls.JoinTableColumnRow joinTableColumnRow1;
        private controls.JoinTableColumnRow joinTableColumnRow2;
        private Label label1;
        private Label tableNameLabel2;
        private Label label3;
        private TextBox aliasTextBox1;
        private Label label2;
        private Label columnLabel4;
        private Panel panel1;
        private Button button2;
        private Panel panel2;
        private Button button3;
    }
}