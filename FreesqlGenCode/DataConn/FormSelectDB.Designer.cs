namespace FreesqlGenCode.DataConn
{
    partial class FormSelectDB
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
            this.mysqlRadioButton1 = new System.Windows.Forms.RadioButton();
            this.sqlserverRadioButton1 = new System.Windows.Forms.RadioButton();
            this.sqliteRadioButton2 = new System.Windows.Forms.RadioButton();
            this.owndefineRadioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mysqlRadioButton1
            // 
            this.mysqlRadioButton1.AutoSize = true;
            this.mysqlRadioButton1.Checked = true;
            this.mysqlRadioButton1.Location = new System.Drawing.Point(81, 112);
            this.mysqlRadioButton1.Name = "mysqlRadioButton1";
            this.mysqlRadioButton1.Size = new System.Drawing.Size(88, 28);
            this.mysqlRadioButton1.TabIndex = 0;
            this.mysqlRadioButton1.TabStop = true;
            this.mysqlRadioButton1.Text = "Mysql";
            this.mysqlRadioButton1.UseVisualStyleBackColor = true;
            // 
            // sqlserverRadioButton1
            // 
            this.sqlserverRadioButton1.AutoSize = true;
            this.sqlserverRadioButton1.Location = new System.Drawing.Point(259, 112);
            this.sqlserverRadioButton1.Name = "sqlserverRadioButton1";
            this.sqlserverRadioButton1.Size = new System.Drawing.Size(113, 28);
            this.sqlserverRadioButton1.TabIndex = 1;
            this.sqlserverRadioButton1.TabStop = true;
            this.sqlserverRadioButton1.Text = "Sqlserver";
            this.sqlserverRadioButton1.UseVisualStyleBackColor = true;
            // 
            // sqliteRadioButton2
            // 
            this.sqliteRadioButton2.AutoSize = true;
            this.sqliteRadioButton2.Location = new System.Drawing.Point(501, 112);
            this.sqliteRadioButton2.Name = "sqliteRadioButton2";
            this.sqliteRadioButton2.Size = new System.Drawing.Size(91, 28);
            this.sqliteRadioButton2.TabIndex = 2;
            this.sqliteRadioButton2.TabStop = true;
            this.sqliteRadioButton2.Text = "SQLite";
            this.sqliteRadioButton2.UseVisualStyleBackColor = true;
            // 
            // owndefineRadioButton3
            // 
            this.owndefineRadioButton3.AutoSize = true;
            this.owndefineRadioButton3.Location = new System.Drawing.Point(80, 191);
            this.owndefineRadioButton3.Name = "owndefineRadioButton3";
            this.owndefineRadioButton3.Size = new System.Drawing.Size(89, 28);
            this.owndefineRadioButton3.TabIndex = 3;
            this.owndefineRadioButton3.Text = "自定义";
            this.owndefineRadioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "开始创建";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSelectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.owndefineRadioButton3);
            this.Controls.Add(this.sqliteRadioButton2);
            this.Controls.Add(this.sqlserverRadioButton1);
            this.Controls.Add(this.mysqlRadioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormSelectDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择数据库类型";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton mysqlRadioButton1;
        private RadioButton sqlserverRadioButton1;
        private RadioButton sqliteRadioButton2;
        private RadioButton owndefineRadioButton3;
        private Button button1;
    }
}