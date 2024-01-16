using FreesqlGenCode.controls;

namespace FreesqlGenCode
{
    partial class FormTestLine
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
            this.components = new System.ComponentModel.Container();
            this.fsShowTables1 = new FreesqlGenCode.controls.FsShowTables();
            this.SuspendLayout();
            // 
            // fsShowTables1
            // 
            this.fsShowTables1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fsShowTables1.Location = new System.Drawing.Point(0, 0);
            this.fsShowTables1.MarginTopBottomOfTable = 35;
            this.fsShowTables1.Name = "fsShowTables1";
            this.fsShowTables1.Size = new System.Drawing.Size(931, 548);
            this.fsShowTables1.TabIndex = 0;

            FsTableControl fsTable = new FsTableControl();
            fsTable.Text = "测试表table";
            fsTable.TableId = 0;
            fsTable.Col = 0;
            fsShowTables1.AddTableControl(fsTable);

            FsTableControl fsTable2 = new FsTableControl();
            fsTable2.Text = "222测试表table2222";
            fsTable2.TableId = 1;
            fsTable2.Col = 1;
            fsTable2.PrevNode = fsTable;
            fsTable.NextNodeList.Add(fsTable2);
            fsShowTables1.AddTableControl(fsTable2);

            FsTableControl fsTable3 = new FsTableControl();
            fsTable3.Text = "222测试表table2222";
            fsTable3.TableId = 3;
            fsTable3.Col = 1;
            fsTable3.PrevNode = fsTable;
            fsTable.NextNodeList.Add(fsTable3);
            fsShowTables1.AddTableControl(fsTable3);

            //fsShowTables1.RemoveTableControl(fsTable2.TableId, fsTable2.Col);
            // 
            // FormTestLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 548);
            this.Controls.Add(this.fsShowTables1);
            this.Name = "FormTestLine";
            this.Text = "FormTestLine";
            this.ResumeLayout(false);

        }

        #endregion

        private FsLine fsLine;
        private FsLine fsLine1;
        private FsShowTables fsShowTables1;
    }
}