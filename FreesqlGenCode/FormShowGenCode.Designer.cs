namespace FreesqlGenCode
{
    partial class FormShowGenCode
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPageModel1 = new System.Windows.Forms.TabPage();
            this.modelRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tabPageModel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 584);
            this.panel1.TabIndex = 0;
            // 
            // tabPageModel1
            // 
            this.tabPageModel1.Controls.Add(this.modelRichTextBox1);
            this.tabPageModel1.Location = new System.Drawing.Point(4, 33);
            this.tabPageModel1.Name = "tabPageModel1";
            this.tabPageModel1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModel1.Size = new System.Drawing.Size(1000, 547);
            this.tabPageModel1.TabIndex = 0;
            this.tabPageModel1.Text = "Model";
            this.tabPageModel1.UseVisualStyleBackColor = true;
            // 
            // modelRichTextBox1
            // 
            this.modelRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelRichTextBox1.Location = new System.Drawing.Point(3, 3);
            this.modelRichTextBox1.Name = "modelRichTextBox1";
            this.modelRichTextBox1.Size = new System.Drawing.Size(994, 541);
            this.modelRichTextBox1.TabIndex = 0;
            this.modelRichTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageModel1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 584);
            this.tabControl1.TabIndex = 0;
            // 
            // FormShowGenCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 584);
            this.Controls.Add(this.panel1);
            this.Name = "FormShowGenCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "代码生成";
            this.panel1.ResumeLayout(false);
            this.tabPageModel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageModel1;
        private RichTextBox modelRichTextBox1;
    }
}