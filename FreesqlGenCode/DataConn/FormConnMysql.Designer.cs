namespace FreesqlGenCode.DataConn
{
    partial class FormConnMysql
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.hosttextBox2 = new System.Windows.Forms.TextBox();
            this.porttextBox3 = new System.Windows.Forms.TextBox();
            this.usernametextBox4 = new System.Windows.Forms.TextBox();
            this.passwordtextBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nametextBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.hosttextBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.porttextBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.usernametextBox4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.passwordtextBox5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(87, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 330);
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
            this.label2.Location = new System.Drawing.Point(141, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "主机：";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "用户名：";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "密码：";
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
            this.hosttextBox2.Location = new System.Drawing.Point(211, 70);
            this.hosttextBox2.Name = "hosttextBox2";
            this.hosttextBox2.Size = new System.Drawing.Size(443, 30);
            this.hosttextBox2.TabIndex = 6;
            this.hosttextBox2.Text = "localhost";
            // 
            // porttextBox3
            // 
            this.porttextBox3.Location = new System.Drawing.Point(211, 137);
            this.porttextBox3.Name = "porttextBox3";
            this.porttextBox3.Size = new System.Drawing.Size(150, 30);
            this.porttextBox3.TabIndex = 7;
            this.porttextBox3.Text = "3306";
            // 
            // usernametextBox4
            // 
            this.usernametextBox4.Location = new System.Drawing.Point(211, 205);
            this.usernametextBox4.Name = "usernametextBox4";
            this.usernametextBox4.Size = new System.Drawing.Size(443, 30);
            this.usernametextBox4.TabIndex = 8;
            this.usernametextBox4.Text = "root";
            // 
            // passwordtextBox5
            // 
            this.passwordtextBox5.Location = new System.Drawing.Point(211, 274);
            this.passwordtextBox5.Name = "passwordtextBox5";
            this.passwordtextBox5.PasswordChar = '*';
            this.passwordtextBox5.Size = new System.Drawing.Size(443, 30);
            this.passwordtextBox5.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "端口：";
            // 
            // testConnbutton1
            // 
            this.testConnbutton1.Location = new System.Drawing.Point(70, 423);
            this.testConnbutton1.Name = "testConnbutton1";
            this.testConnbutton1.Size = new System.Drawing.Size(115, 48);
            this.testConnbutton1.TabIndex = 1;
            this.testConnbutton1.Text = "测试连接";
            this.testConnbutton1.UseVisualStyleBackColor = true;
            this.testConnbutton1.Click += new System.EventHandler(this.testConnbutton1_Click);
            // 
            // savebutton1
            // 
            this.savebutton1.Location = new System.Drawing.Point(705, 423);
            this.savebutton1.Name = "savebutton1";
            this.savebutton1.Size = new System.Drawing.Size(124, 48);
            this.savebutton1.TabIndex = 2;
            this.savebutton1.Text = "保存";
            this.savebutton1.UseVisualStyleBackColor = true;
            this.savebutton1.Click += new System.EventHandler(this.savebutton1_Click);
            // 
            // FormConnMysql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 495);
            this.Controls.Add(this.savebutton1);
            this.Controls.Add(this.testConnbutton1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormConnMysql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mysql 配置数据库连接";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nametextBox1;
        private TextBox hosttextBox2;
        private TextBox porttextBox3;
        private TextBox usernametextBox4;
        private TextBox passwordtextBox5;
        private Button testConnbutton1;
        private Button savebutton1;
    }
}