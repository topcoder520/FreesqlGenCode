namespace FreesqlGenCode.DataConn
{
    partial class FormConnSqlserver
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernamelabel4 = new System.Windows.Forms.Label();
            this.passwordlabel5 = new System.Windows.Forms.Label();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.hosttextBox2 = new System.Windows.Forms.TextBox();
            this.usernametextBox4 = new System.Windows.Forms.TextBox();
            this.passwordtextBox5 = new System.Windows.Forms.TextBox();
            this.initDBtextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.testConnbutton1 = new System.Windows.Forms.Button();
            this.savebutton1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.76902F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.23098F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernamelabel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.passwordlabel5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.nametextBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.hosttextBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernametextBox4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.passwordtextBox5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.initDBtextBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(88, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 375);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "连接名称：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "主机：";
            // 
            // usernamelabel4
            // 
            this.usernamelabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernamelabel4.AutoSize = true;
            this.usernamelabel4.Location = new System.Drawing.Point(123, 233);
            this.usernamelabel4.Name = "usernamelabel4";
            this.usernamelabel4.Size = new System.Drawing.Size(82, 24);
            this.usernamelabel4.TabIndex = 3;
            this.usernamelabel4.Text = "用户名：";
            // 
            // passwordlabel5
            // 
            this.passwordlabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordlabel5.AutoSize = true;
            this.passwordlabel5.Location = new System.Drawing.Point(141, 292);
            this.passwordlabel5.Name = "passwordlabel5";
            this.passwordlabel5.Size = new System.Drawing.Size(64, 24);
            this.passwordlabel5.TabIndex = 4;
            this.passwordlabel5.Text = "密码：";
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(211, 3);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(443, 30);
            this.nametextBox1.TabIndex = 5;
            // 
            // hosttextBox2
            // 
            this.hosttextBox2.Location = new System.Drawing.Point(211, 55);
            this.hosttextBox2.Name = "hosttextBox2";
            this.hosttextBox2.Size = new System.Drawing.Size(443, 30);
            this.hosttextBox2.TabIndex = 6;
            // 
            // usernametextBox4
            // 
            this.usernametextBox4.Location = new System.Drawing.Point(211, 236);
            this.usernametextBox4.Name = "usernametextBox4";
            this.usernametextBox4.Size = new System.Drawing.Size(443, 30);
            this.usernametextBox4.TabIndex = 8;
            this.usernametextBox4.Text = "sa";
            // 
            // passwordtextBox5
            // 
            this.passwordtextBox5.Location = new System.Drawing.Point(211, 295);
            this.passwordtextBox5.Name = "passwordtextBox5";
            this.passwordtextBox5.PasswordChar = '*';
            this.passwordtextBox5.Size = new System.Drawing.Size(443, 30);
            this.passwordtextBox5.TabIndex = 9;
            // 
            // initDBtextBox1
            // 
            this.initDBtextBox1.Location = new System.Drawing.Point(211, 107);
            this.initDBtextBox1.Name = "initDBtextBox1";
            this.initDBtextBox1.Size = new System.Drawing.Size(443, 30);
            this.initDBtextBox1.TabIndex = 10;
            this.initDBtextBox1.Text = "master";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "初始数据库：";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "验证：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SQL Server 验证",
            "Windows 验证"});
            this.comboBox1.Location = new System.Drawing.Point(211, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(443, 32);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // testConnbutton1
            // 
            this.testConnbutton1.Location = new System.Drawing.Point(70, 474);
            this.testConnbutton1.Name = "testConnbutton1";
            this.testConnbutton1.Size = new System.Drawing.Size(115, 48);
            this.testConnbutton1.TabIndex = 1;
            this.testConnbutton1.Text = "测试连接";
            this.testConnbutton1.UseVisualStyleBackColor = true;
            this.testConnbutton1.Click += new System.EventHandler(this.testConnbutton1_Click);
            // 
            // savebutton1
            // 
            this.savebutton1.Location = new System.Drawing.Point(705, 474);
            this.savebutton1.Name = "savebutton1";
            this.savebutton1.Size = new System.Drawing.Size(124, 48);
            this.savebutton1.TabIndex = 2;
            this.savebutton1.Text = "保存";
            this.savebutton1.UseVisualStyleBackColor = true;
            this.savebutton1.Click += new System.EventHandler(this.savebutton1_Click);
            // 
            // FormConnSqlserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 550);
            this.Controls.Add(this.savebutton1);
            this.Controls.Add(this.testConnbutton1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormConnSqlserver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sqlserver 配置数据库连接";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label usernamelabel4;
        private Label passwordlabel5;
        private TextBox nametextBox1;
        private TextBox hosttextBox2;
        private TextBox usernametextBox4;
        private TextBox passwordtextBox5;
        private Button testConnbutton1;
        private Button savebutton1;
        private TextBox initDBtextBox1;
        private Label label6;
        private ComboBox comboBox1;
    }
}