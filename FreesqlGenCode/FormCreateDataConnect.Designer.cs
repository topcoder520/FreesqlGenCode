namespace FreesqlGenCode
{
    partial class FormCreateDataConnect
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
            this.selectTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.defineRadioButton4 = new System.Windows.Forms.RadioButton();
            this.sqliteRadioButton3 = new System.Windows.Forms.RadioButton();
            this.sqlServerRadioButton2 = new System.Windows.Forms.RadioButton();
            this.mysqlRadioButton1 = new System.Windows.Forms.RadioButton();
            this.mysqlConfigConnectGroupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mysqlConnectNameTextBox1 = new System.Windows.Forms.TextBox();
            this.mysqlHostTextBox2 = new System.Windows.Forms.TextBox();
            this.mysqlPortTextBox3 = new System.Windows.Forms.TextBox();
            this.mysqlUsernametextBox4 = new System.Windows.Forms.TextBox();
            this.mysqlPasswordTextBox5 = new System.Windows.Forms.TextBox();
            this.nextButton1 = new System.Windows.Forms.Button();
            this.preButton2 = new System.Windows.Forms.Button();
            this.testConButton3 = new System.Windows.Forms.Button();
            this.saveButton1 = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.selectTypeGroupBox.SuspendLayout();
            this.mysqlConfigConnectGroupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectTypeGroupBox
            // 
            this.selectTypeGroupBox.BackColor = System.Drawing.Color.White;
            this.selectTypeGroupBox.Controls.Add(this.defineRadioButton4);
            this.selectTypeGroupBox.Controls.Add(this.sqliteRadioButton3);
            this.selectTypeGroupBox.Controls.Add(this.sqlServerRadioButton2);
            this.selectTypeGroupBox.Controls.Add(this.mysqlRadioButton1);
            this.selectTypeGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectTypeGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectTypeGroupBox.Location = new System.Drawing.Point(0, 510);
            this.selectTypeGroupBox.Margin = new System.Windows.Forms.Padding(12);
            this.selectTypeGroupBox.Name = "selectTypeGroupBox";
            this.selectTypeGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectTypeGroupBox.Size = new System.Drawing.Size(814, 510);
            this.selectTypeGroupBox.TabIndex = 0;
            this.selectTypeGroupBox.TabStop = false;
            this.selectTypeGroupBox.Text = "选择数据库类型";
            // 
            // defineRadioButton4
            // 
            this.defineRadioButton4.AutoSize = true;
            this.defineRadioButton4.Location = new System.Drawing.Point(112, 216);
            this.defineRadioButton4.Name = "defineRadioButton4";
            this.defineRadioButton4.Size = new System.Drawing.Size(89, 28);
            this.defineRadioButton4.TabIndex = 7;
            this.defineRadioButton4.TabStop = true;
            this.defineRadioButton4.Text = "自定义";
            this.defineRadioButton4.UseVisualStyleBackColor = true;
            // 
            // sqliteRadioButton3
            // 
            this.sqliteRadioButton3.AutoSize = true;
            this.sqliteRadioButton3.Location = new System.Drawing.Point(540, 136);
            this.sqliteRadioButton3.Name = "sqliteRadioButton3";
            this.sqliteRadioButton3.Size = new System.Drawing.Size(84, 28);
            this.sqliteRadioButton3.TabIndex = 6;
            this.sqliteRadioButton3.TabStop = true;
            this.sqliteRadioButton3.Text = "Sqlite";
            this.sqliteRadioButton3.UseVisualStyleBackColor = true;
            // 
            // sqlServerRadioButton2
            // 
            this.sqlServerRadioButton2.AutoSize = true;
            this.sqlServerRadioButton2.Location = new System.Drawing.Point(317, 136);
            this.sqlServerRadioButton2.Name = "sqlServerRadioButton2";
            this.sqlServerRadioButton2.Size = new System.Drawing.Size(113, 28);
            this.sqlServerRadioButton2.TabIndex = 5;
            this.sqlServerRadioButton2.TabStop = true;
            this.sqlServerRadioButton2.Text = "Sqlserver";
            this.sqlServerRadioButton2.UseVisualStyleBackColor = true;
            // 
            // mysqlRadioButton1
            // 
            this.mysqlRadioButton1.AutoSize = true;
            this.mysqlRadioButton1.Location = new System.Drawing.Point(112, 136);
            this.mysqlRadioButton1.Name = "mysqlRadioButton1";
            this.mysqlRadioButton1.Size = new System.Drawing.Size(88, 28);
            this.mysqlRadioButton1.TabIndex = 4;
            this.mysqlRadioButton1.TabStop = true;
            this.mysqlRadioButton1.Text = "Mysql";
            this.mysqlRadioButton1.UseVisualStyleBackColor = true;
            // 
            // mysqlConfigConnectGroupBox1
            // 
            this.mysqlConfigConnectGroupBox1.BackColor = System.Drawing.Color.White;
            this.mysqlConfigConnectGroupBox1.Controls.Add(this.tableLayoutPanel1);
            this.mysqlConfigConnectGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mysqlConfigConnectGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.mysqlConfigConnectGroupBox1.Name = "mysqlConfigConnectGroupBox1";
            this.mysqlConfigConnectGroupBox1.Size = new System.Drawing.Size(814, 510);
            this.mysqlConfigConnectGroupBox1.TabIndex = 6;
            this.mysqlConfigConnectGroupBox1.TabStop = false;
            this.mysqlConfigConnectGroupBox1.Text = "配置数据库连接";
            this.mysqlConfigConnectGroupBox1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.28424F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.71576F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.mysqlConnectNameTextBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mysqlHostTextBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mysqlPortTextBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mysqlUsernametextBox4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.mysqlPasswordTextBox5, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 308);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "连接名称：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "主机：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "端口：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "用户名：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "密码：";
            // 
            // mysqlConnectNameTextBox1
            // 
            this.mysqlConnectNameTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mysqlConnectNameTextBox1.Location = new System.Drawing.Point(166, 15);
            this.mysqlConnectNameTextBox1.Name = "mysqlConnectNameTextBox1";
            this.mysqlConnectNameTextBox1.Size = new System.Drawing.Size(528, 30);
            this.mysqlConnectNameTextBox1.TabIndex = 5;
            // 
            // mysqlHostTextBox2
            // 
            this.mysqlHostTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mysqlHostTextBox2.Location = new System.Drawing.Point(166, 75);
            this.mysqlHostTextBox2.Name = "mysqlHostTextBox2";
            this.mysqlHostTextBox2.Size = new System.Drawing.Size(528, 30);
            this.mysqlHostTextBox2.TabIndex = 6;
            // 
            // mysqlPortTextBox3
            // 
            this.mysqlPortTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mysqlPortTextBox3.Location = new System.Drawing.Point(166, 135);
            this.mysqlPortTextBox3.Name = "mysqlPortTextBox3";
            this.mysqlPortTextBox3.Size = new System.Drawing.Size(150, 30);
            this.mysqlPortTextBox3.TabIndex = 7;
            // 
            // mysqlUsernametextBox4
            // 
            this.mysqlUsernametextBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mysqlUsernametextBox4.Location = new System.Drawing.Point(166, 195);
            this.mysqlUsernametextBox4.Name = "mysqlUsernametextBox4";
            this.mysqlUsernametextBox4.Size = new System.Drawing.Size(528, 30);
            this.mysqlUsernametextBox4.TabIndex = 8;
            // 
            // mysqlPasswordTextBox5
            // 
            this.mysqlPasswordTextBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mysqlPasswordTextBox5.Location = new System.Drawing.Point(166, 259);
            this.mysqlPasswordTextBox5.Name = "mysqlPasswordTextBox5";
            this.mysqlPasswordTextBox5.PasswordChar = '*';
            this.mysqlPasswordTextBox5.Size = new System.Drawing.Size(528, 30);
            this.mysqlPasswordTextBox5.TabIndex = 9;
            // 
            // nextButton1
            // 
            this.nextButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton1.Location = new System.Drawing.Point(595, 24);
            this.nextButton1.Name = "nextButton1";
            this.nextButton1.Size = new System.Drawing.Size(120, 46);
            this.nextButton1.TabIndex = 1;
            this.nextButton1.Text = "下一步";
            this.nextButton1.UseVisualStyleBackColor = true;
            this.nextButton1.Visible = false;
            this.nextButton1.Click += new System.EventHandler(this.nextButton1_Click);
            // 
            // preButton2
            // 
            this.preButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.preButton2.Location = new System.Drawing.Point(440, 26);
            this.preButton2.Name = "preButton2";
            this.preButton2.Size = new System.Drawing.Size(120, 46);
            this.preButton2.TabIndex = 2;
            this.preButton2.Text = "上一步";
            this.preButton2.UseVisualStyleBackColor = true;
            this.preButton2.Click += new System.EventHandler(this.preButton2_Click);
            // 
            // testConButton3
            // 
            this.testConButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.testConButton3.Location = new System.Drawing.Point(52, 26);
            this.testConButton3.Name = "testConButton3";
            this.testConButton3.Size = new System.Drawing.Size(120, 46);
            this.testConButton3.TabIndex = 3;
            this.testConButton3.Text = "测试连接";
            this.testConButton3.UseVisualStyleBackColor = true;
            this.testConButton3.Click += new System.EventHandler(this.testConButton3_Click);
            // 
            // saveButton1
            // 
            this.saveButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton1.Location = new System.Drawing.Point(595, 24);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(120, 48);
            this.saveButton1.TabIndex = 4;
            this.saveButton1.Text = "保存";
            this.saveButton1.UseVisualStyleBackColor = true;
            this.saveButton1.Visible = false;
            this.saveButton1.Click += new System.EventHandler(this.saveButton1_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.saveButton1);
            this.bottomPanel.Controls.Add(this.testConButton3);
            this.bottomPanel.Controls.Add(this.nextButton1);
            this.bottomPanel.Controls.Add(this.preButton2);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 415);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(814, 95);
            this.bottomPanel.TabIndex = 5;
            // 
            // FormCreateDataConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 510);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.selectTypeGroupBox);
            this.Controls.Add(this.mysqlConfigConnectGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreateDataConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择数据库类型";
            this.selectTypeGroupBox.ResumeLayout(false);
            this.selectTypeGroupBox.PerformLayout();
            this.mysqlConfigConnectGroupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox selectTypeGroupBox;
        private Button nextButton1;
        private RadioButton mysqlRadioButton1;
        private RadioButton sqlServerRadioButton2;
        private RadioButton sqliteRadioButton3;
        private RadioButton defineRadioButton4;
        private Button preButton2;
        private Button testConButton3;
        private Button saveButton1;
        private Panel bottomPanel;
        private GroupBox mysqlConfigConnectGroupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox mysqlConnectNameTextBox1;
        private TextBox mysqlHostTextBox2;
        private TextBox mysqlPortTextBox3;
        private TextBox mysqlUsernametextBox4;
        private TextBox mysqlPasswordTextBox5;
    }
}