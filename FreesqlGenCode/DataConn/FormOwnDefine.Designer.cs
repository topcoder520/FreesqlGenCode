namespace FreesqlGenCode.DataConn
{
    partial class FormOwnDefine
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
            this.mysqlradioButton1 = new System.Windows.Forms.RadioButton();
            this.sqlserverradioButton2 = new System.Windows.Forms.RadioButton();
            this.sqliteradioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.connectstringtextBox1 = new System.Windows.Forms.TextBox();
            this.testbutton1 = new System.Windows.Forms.Button();
            this.savebutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mysqlradioButton1
            // 
            this.mysqlradioButton1.AutoSize = true;
            this.mysqlradioButton1.Checked = true;
            this.mysqlradioButton1.Location = new System.Drawing.Point(109, 76);
            this.mysqlradioButton1.Name = "mysqlradioButton1";
            this.mysqlradioButton1.Size = new System.Drawing.Size(88, 28);
            this.mysqlradioButton1.TabIndex = 0;
            this.mysqlradioButton1.TabStop = true;
            this.mysqlradioButton1.Text = "Mysql";
            this.mysqlradioButton1.UseVisualStyleBackColor = true;
            // 
            // sqlserverradioButton2
            // 
            this.sqlserverradioButton2.AutoSize = true;
            this.sqlserverradioButton2.Location = new System.Drawing.Point(323, 76);
            this.sqlserverradioButton2.Name = "sqlserverradioButton2";
            this.sqlserverradioButton2.Size = new System.Drawing.Size(113, 28);
            this.sqlserverradioButton2.TabIndex = 1;
            this.sqlserverradioButton2.Text = "Sqlserver";
            this.sqlserverradioButton2.UseVisualStyleBackColor = true;
            // 
            // sqliteradioButton3
            // 
            this.sqliteradioButton3.AutoSize = true;
            this.sqliteradioButton3.Location = new System.Drawing.Point(538, 76);
            this.sqliteradioButton3.Name = "sqliteradioButton3";
            this.sqliteradioButton3.Size = new System.Drawing.Size(91, 28);
            this.sqliteradioButton3.TabIndex = 2;
            this.sqliteradioButton3.Text = "SQLite";
            this.sqliteradioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "连接名称：";
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(212, 185);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(417, 30);
            this.nametextBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "数据库连接串：";
            // 
            // connectstringtextBox1
            // 
            this.connectstringtextBox1.Location = new System.Drawing.Point(212, 244);
            this.connectstringtextBox1.Multiline = true;
            this.connectstringtextBox1.Name = "connectstringtextBox1";
            this.connectstringtextBox1.Size = new System.Drawing.Size(417, 133);
            this.connectstringtextBox1.TabIndex = 6;
            // 
            // testbutton1
            // 
            this.testbutton1.Location = new System.Drawing.Point(85, 453);
            this.testbutton1.Name = "testbutton1";
            this.testbutton1.Size = new System.Drawing.Size(121, 47);
            this.testbutton1.TabIndex = 7;
            this.testbutton1.Text = "测试连接";
            this.testbutton1.UseVisualStyleBackColor = true;
            this.testbutton1.Click += new System.EventHandler(this.testbutton1_Click);
            // 
            // savebutton2
            // 
            this.savebutton2.Location = new System.Drawing.Point(594, 453);
            this.savebutton2.Name = "savebutton2";
            this.savebutton2.Size = new System.Drawing.Size(124, 47);
            this.savebutton2.TabIndex = 8;
            this.savebutton2.Text = "保存";
            this.savebutton2.UseVisualStyleBackColor = true;
            this.savebutton2.Click += new System.EventHandler(this.savebutton2_Click);
            // 
            // FormOwnDefine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.savebutton2);
            this.Controls.Add(this.testbutton1);
            this.Controls.Add(this.connectstringtextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sqliteradioButton3);
            this.Controls.Add(this.sqlserverradioButton2);
            this.Controls.Add(this.mysqlradioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormOwnDefine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "自定义 配置数据库连接";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton mysqlradioButton1;
        private RadioButton sqlserverradioButton2;
        private RadioButton sqliteradioButton3;
        private Label label1;
        private TextBox nametextBox1;
        private Label label2;
        private TextBox connectstringtextBox1;
        private Button testbutton1;
        private Button savebutton2;
    }
}