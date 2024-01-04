using System.ComponentModel;

namespace FreesqlGenCode.controls
{
    partial class FsAddDbPictureBox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.AddDBPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddDBPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddDBPictureBox
            // 
            this.AddDBPictureBox.BackColor = System.Drawing.Color.White;
            this.AddDBPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDBPictureBox.Image = global::FreesqlGenCode.Properties.Resources.database_add;
            this.AddDBPictureBox.Location = new System.Drawing.Point(0, 0);
            this.AddDBPictureBox.Name = "AddDBPictureBox";
            this.AddDBPictureBox.Size = new System.Drawing.Size(209, 125);
            this.AddDBPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddDBPictureBox.TabIndex = 0;
            this.AddDBPictureBox.TabStop = false;
            this.AddDBPictureBox.Click += new System.EventHandler(this.AddDBPictureBox_Click);
            this.AddDBPictureBox.MouseEnter += new System.EventHandler(this.AddDBPictureBox_MouseHover);
            this.AddDBPictureBox.MouseLeave += new System.EventHandler(this.AddDBPictureBox_MouseLeave);
            // 
            // FsPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AddDBPictureBox);
            this.Name = "FsPictureBox";
            this.Size = new System.Drawing.Size(209, 125);
            ((System.ComponentModel.ISupportInitialize)(this.AddDBPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox AddDBPictureBox;

        #region 自定义属性

        [Browsable(true)]
        public Color FsBackColor {
            get {
                return AddDBPictureBox.BackColor;
            }
            set
            {
                AddDBPictureBox.BackColor = value;
                this.BackColor = value;
            }
        }

        [Browsable(true)]
        public Color FsHoverBackColor { get; set; } = Color.White;

        [Browsable(true)]
        public Color FsLeaveBackColor { get; set; } = Color.White;

        public event EventHandler FsClick;

        #endregion
    }
}
