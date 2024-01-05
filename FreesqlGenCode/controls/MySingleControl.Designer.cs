using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreesqlGenCode.controls
{
    public partial class MySingleControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            this.tabPanelShowGenCodeTemplePanel1 = new System.Windows.Forms.Panel();
            this.genCodeBottomPanel1 = new System.Windows.Forms.Panel();
            this.mysingleTabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.genCodeRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.modelRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.setParamGroupBox1 = new System.Windows.Forms.GroupBox();
            this.genCodeTopPanel1 = new System.Windows.Forms.Panel();
            this.underLineToCheckBox2 = new System.Windows.Forms.CheckBox();
            this.allLowerCheckBox1 = new System.Windows.Forms.CheckBox();
            this.firstCharUpperCheckBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectTempleteComboBox1 = new System.Windows.Forms.ComboBox();
            this.filterTablenameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.namespaceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPanelTableTop1 = new System.Windows.Forms.Panel();
            this.dataGridViewTop1 = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDbType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDbTypeText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDbTypeTextFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaxLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsPrimary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsIdentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsNullable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColComent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setParamPanel1 = new System.Windows.Forms.Panel();
            this.tabPanelShowGenCodeTemplePanel1.SuspendLayout();
            this.genCodeBottomPanel1.SuspendLayout();
            this.mysingleTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.setParamGroupBox1.SuspendLayout();
            this.genCodeTopPanel1.SuspendLayout();
            this.tabPanelTableTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop1)).BeginInit();
            this.setParamPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanelShowGenCodeTemplePanel1
            // 
            this.tabPanelShowGenCodeTemplePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPanelShowGenCodeTemplePanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPanelShowGenCodeTemplePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPanelShowGenCodeTemplePanel1.Controls.Add(this.genCodeBottomPanel1);
            this.tabPanelShowGenCodeTemplePanel1.Location = new System.Drawing.Point(2, 460);
            this.tabPanelShowGenCodeTemplePanel1.Name = "tabPanelShowGenCodeTemplePanel1";
            this.tabPanelShowGenCodeTemplePanel1.Size = new System.Drawing.Size(1282, 321);
            this.tabPanelShowGenCodeTemplePanel1.TabIndex = 1;
            // 
            // genCodeBottomPanel1
            // 
            this.genCodeBottomPanel1.Controls.Add(this.mysingleTabControl1);
            this.genCodeBottomPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genCodeBottomPanel1.Location = new System.Drawing.Point(0, 0);
            this.genCodeBottomPanel1.Name = "genCodeBottomPanel1";
            this.genCodeBottomPanel1.Size = new System.Drawing.Size(1280, 319);
            this.genCodeBottomPanel1.TabIndex = 1;
            // 
            // mysingleTabControl1
            // 
            this.mysingleTabControl1.Controls.Add(this.tabPage1);
            this.mysingleTabControl1.Controls.Add(this.tabPage2);
            this.mysingleTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mysingleTabControl1.Location = new System.Drawing.Point(0, 0);
            this.mysingleTabControl1.Name = "mysingleTabControl1";
            this.mysingleTabControl1.SelectedIndex = 0;
            this.mysingleTabControl1.Size = new System.Drawing.Size(1280, 319);
            this.mysingleTabControl1.TabIndex = 1;
            this.mysingleTabControl1.SelectedIndexChanged += new System.EventHandler(this.mysingleTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.genCodeRichTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1272, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "模板";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // genCodeRichTextBox1
            // 
            this.genCodeRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genCodeRichTextBox1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genCodeRichTextBox1.Location = new System.Drawing.Point(3, 3);
            this.genCodeRichTextBox1.Name = "genCodeRichTextBox1";
            this.genCodeRichTextBox1.Size = new System.Drawing.Size(1266, 276);
            this.genCodeRichTextBox1.TabIndex = 0;
            this.genCodeRichTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.modelRichTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1272, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "生成代码";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // modelRichTextBox1
            // 
            this.modelRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelRichTextBox1.Location = new System.Drawing.Point(3, 3);
            this.modelRichTextBox1.Name = "modelRichTextBox1";
            this.modelRichTextBox1.Size = new System.Drawing.Size(1266, 276);
            this.modelRichTextBox1.TabIndex = 0;
            this.modelRichTextBox1.Text = "";
            // 
            // setParamGroupBox1
            // 
            this.setParamGroupBox1.Controls.Add(this.genCodeTopPanel1);
            this.setParamGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setParamGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.setParamGroupBox1.Name = "setParamGroupBox1";
            this.setParamGroupBox1.Size = new System.Drawing.Size(1282, 176);
            this.setParamGroupBox1.TabIndex = 2;
            this.setParamGroupBox1.TabStop = false;
            this.setParamGroupBox1.Text = "参数设置";
            // 
            // genCodeTopPanel1
            // 
            this.genCodeTopPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.genCodeTopPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genCodeTopPanel1.Controls.Add(this.underLineToCheckBox2);
            this.genCodeTopPanel1.Controls.Add(this.allLowerCheckBox1);
            this.genCodeTopPanel1.Controls.Add(this.firstCharUpperCheckBox1);
            this.genCodeTopPanel1.Controls.Add(this.label3);
            this.genCodeTopPanel1.Controls.Add(this.selectTempleteComboBox1);
            this.genCodeTopPanel1.Controls.Add(this.filterTablenameText);
            this.genCodeTopPanel1.Controls.Add(this.label2);
            this.genCodeTopPanel1.Controls.Add(this.namespaceText);
            this.genCodeTopPanel1.Controls.Add(this.label1);
            this.genCodeTopPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genCodeTopPanel1.Location = new System.Drawing.Point(3, 26);
            this.genCodeTopPanel1.Name = "genCodeTopPanel1";
            this.genCodeTopPanel1.Size = new System.Drawing.Size(1276, 147);
            this.genCodeTopPanel1.TabIndex = 0;
            // 
            // underLineToCheckBox2
            // 
            this.underLineToCheckBox2.AutoSize = true;
            this.underLineToCheckBox2.Location = new System.Drawing.Point(371, 91);
            this.underLineToCheckBox2.Name = "underLineToCheckBox2";
            this.underLineToCheckBox2.Size = new System.Drawing.Size(108, 28);
            this.underLineToCheckBox2.TabIndex = 8;
            this.underLineToCheckBox2.Text = "下划线转";
            this.underLineToCheckBox2.UseVisualStyleBackColor = true;
            // 
            // allLowerCheckBox1
            // 
            this.allLowerCheckBox1.AutoSize = true;
            this.allLowerCheckBox1.Location = new System.Drawing.Point(211, 91);
            this.allLowerCheckBox1.Name = "allLowerCheckBox1";
            this.allLowerCheckBox1.Size = new System.Drawing.Size(108, 28);
            this.allLowerCheckBox1.TabIndex = 7;
            this.allLowerCheckBox1.Text = "全部小写";
            this.allLowerCheckBox1.UseVisualStyleBackColor = true;
            // 
            // firstCharUpperCheckBox1
            // 
            this.firstCharUpperCheckBox1.AutoSize = true;
            this.firstCharUpperCheckBox1.Location = new System.Drawing.Point(48, 91);
            this.firstCharUpperCheckBox1.Name = "firstCharUpperCheckBox1";
            this.firstCharUpperCheckBox1.Size = new System.Drawing.Size(126, 28);
            this.firstCharUpperCheckBox1.TabIndex = 6;
            this.firstCharUpperCheckBox1.Text = "首字母大写";
            this.firstCharUpperCheckBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(751, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "选择模板：";
            // 
            // selectTempleteComboBox1
            // 
            this.selectTempleteComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTempleteComboBox1.FormattingEnabled = true;
            this.selectTempleteComboBox1.Location = new System.Drawing.Point(857, 28);
            this.selectTempleteComboBox1.Name = "selectTempleteComboBox1";
            this.selectTempleteComboBox1.Size = new System.Drawing.Size(323, 32);
            this.selectTempleteComboBox1.TabIndex = 4;
            this.selectTempleteComboBox1.SelectedIndexChanged += new System.EventHandler(this.selectTempleteComboBox1_SelectedIndexChanged);
            // 
            // filterTablenameText
            // 
            this.filterTablenameText.Location = new System.Drawing.Point(513, 28);
            this.filterTablenameText.Name = "filterTablenameText";
            this.filterTablenameText.Size = new System.Drawing.Size(173, 30);
            this.filterTablenameText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "去掉表名字符：";
            // 
            // namespaceText
            // 
            this.namespaceText.Location = new System.Drawing.Point(137, 28);
            this.namespaceText.Name = "namespaceText";
            this.namespaceText.Size = new System.Drawing.Size(182, 30);
            this.namespaceText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "命名空间：";
            // 
            // tabPanelTableTop1
            // 
            this.tabPanelTableTop1.AutoScroll = true;
            this.tabPanelTableTop1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPanelTableTop1.Controls.Add(this.dataGridViewTop1);
            this.tabPanelTableTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPanelTableTop1.Location = new System.Drawing.Point(3, 3);
            this.tabPanelTableTop1.Name = "tabPanelTableTop1";
            this.tabPanelTableTop1.Size = new System.Drawing.Size(1282, 278);
            this.tabPanelTableTop1.TabIndex = 0;
            // 
            // dataGridViewTop1
            // 
            this.dataGridViewTop1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTop1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColCsType,
            this.ColDbType,
            this.ColDbTypeText,
            this.ColDbTypeTextFull,
            this.ColMaxLength,
            this.ColIsPrimary,
            this.ColIsIdentity,
            this.ColIsNullable,
            this.ColComent});
            this.dataGridViewTop1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTop1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTop1.Name = "dataGridViewTop1";
            this.dataGridViewTop1.ReadOnly = true;
            this.dataGridViewTop1.RowHeadersWidth = 20;
            this.dataGridViewTop1.RowTemplate.Height = 32;
            this.dataGridViewTop1.Size = new System.Drawing.Size(1280, 276);
            this.dataGridViewTop1.TabIndex = 0;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.MinimumWidth = 8;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.ToolTipText = "Name";
            this.ColName.Width = 150;
            // 
            // ColCsType
            // 
            this.ColCsType.HeaderText = "CsType";
            this.ColCsType.MinimumWidth = 8;
            this.ColCsType.Name = "ColCsType";
            this.ColCsType.ReadOnly = true;
            this.ColCsType.ToolTipText = "CsType";
            this.ColCsType.Width = 150;
            // 
            // ColDbType
            // 
            this.ColDbType.HeaderText = "DbType";
            this.ColDbType.MinimumWidth = 8;
            this.ColDbType.Name = "ColDbType";
            this.ColDbType.ReadOnly = true;
            this.ColDbType.ToolTipText = "DbType";
            this.ColDbType.Width = 150;
            // 
            // ColDbTypeText
            // 
            this.ColDbTypeText.HeaderText = "DbTypeText";
            this.ColDbTypeText.MinimumWidth = 8;
            this.ColDbTypeText.Name = "ColDbTypeText";
            this.ColDbTypeText.ReadOnly = true;
            this.ColDbTypeText.ToolTipText = "DbTypeText";
            this.ColDbTypeText.Width = 150;
            // 
            // ColDbTypeTextFull
            // 
            this.ColDbTypeTextFull.HeaderText = "DbTypeTextFull";
            this.ColDbTypeTextFull.MinimumWidth = 8;
            this.ColDbTypeTextFull.Name = "ColDbTypeTextFull";
            this.ColDbTypeTextFull.ReadOnly = true;
            this.ColDbTypeTextFull.ToolTipText = "DbTypeTextFull";
            this.ColDbTypeTextFull.Width = 150;
            // 
            // ColMaxLength
            // 
            this.ColMaxLength.HeaderText = "MaxLength";
            this.ColMaxLength.MinimumWidth = 8;
            this.ColMaxLength.Name = "ColMaxLength";
            this.ColMaxLength.ReadOnly = true;
            this.ColMaxLength.ToolTipText = "MaxLength";
            this.ColMaxLength.Width = 150;
            // 
            // ColIsPrimary
            // 
            this.ColIsPrimary.HeaderText = "IsPrimary";
            this.ColIsPrimary.MinimumWidth = 8;
            this.ColIsPrimary.Name = "ColIsPrimary";
            this.ColIsPrimary.ReadOnly = true;
            this.ColIsPrimary.ToolTipText = "IsPrimary";
            this.ColIsPrimary.Width = 150;
            // 
            // ColIsIdentity
            // 
            this.ColIsIdentity.HeaderText = "IsIdentity";
            this.ColIsIdentity.MinimumWidth = 8;
            this.ColIsIdentity.Name = "ColIsIdentity";
            this.ColIsIdentity.ReadOnly = true;
            this.ColIsIdentity.ToolTipText = "IsIdentity";
            this.ColIsIdentity.Width = 150;
            // 
            // ColIsNullable
            // 
            this.ColIsNullable.HeaderText = "IsNullable";
            this.ColIsNullable.MinimumWidth = 8;
            this.ColIsNullable.Name = "ColIsNullable";
            this.ColIsNullable.ReadOnly = true;
            this.ColIsNullable.ToolTipText = "IsNullable";
            this.ColIsNullable.Width = 150;
            // 
            // ColComent
            // 
            this.ColComent.HeaderText = "Coment";
            this.ColComent.MinimumWidth = 8;
            this.ColComent.Name = "ColComent";
            this.ColComent.ReadOnly = true;
            this.ColComent.ToolTipText = "Coment";
            this.ColComent.Width = 150;
            // 
            // setParamPanel1
            // 
            this.setParamPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.setParamPanel1.Controls.Add(this.setParamGroupBox1);
            this.setParamPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.setParamPanel1.Location = new System.Drawing.Point(3, 281);
            this.setParamPanel1.Name = "setParamPanel1";
            this.setParamPanel1.Size = new System.Drawing.Size(1282, 176);
            this.setParamPanel1.TabIndex = 3;
            // 
            // MySingleControl
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.setParamPanel1);
            this.Controls.Add(this.tabPanelShowGenCodeTemplePanel1);
            this.Controls.Add(this.tabPanelTableTop1);
            this.Location = new System.Drawing.Point(4, 34);
            this.Name = "MySingleControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(1288, 787);
            this.tabPanelShowGenCodeTemplePanel1.ResumeLayout(false);
            this.genCodeBottomPanel1.ResumeLayout(false);
            this.mysingleTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.setParamGroupBox1.ResumeLayout(false);
            this.genCodeTopPanel1.ResumeLayout(false);
            this.genCodeTopPanel1.PerformLayout();
            this.tabPanelTableTop1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop1)).EndInit();
            this.setParamPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel tabPanelTableTop1;
        private Panel tabPanelShowGenCodeTemplePanel1;
        public DataGridView dataGridViewTop1;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColCsType;
        private DataGridViewTextBoxColumn ColDbType;
        private DataGridViewTextBoxColumn ColDbTypeText;
        private DataGridViewTextBoxColumn ColDbTypeTextFull;
        private DataGridViewTextBoxColumn ColMaxLength;
        private DataGridViewTextBoxColumn ColIsPrimary;
        private DataGridViewTextBoxColumn ColIsIdentity;
        private DataGridViewTextBoxColumn ColIsNullable;
        private DataGridViewTextBoxColumn ColComent;
        private Panel genCodeTopPanel1;
        private Label label1;
        private Label label2;
        private TextBox namespaceText;
        private TextBox filterTablenameText;
        private Label label3;
        private ComboBox selectTempleteComboBox1;
        private CheckBox firstCharUpperCheckBox1;
        private CheckBox allLowerCheckBox1;
        private CheckBox underLineToCheckBox2;
        private Panel genCodeBottomPanel1;
        private RichTextBox genCodeRichTextBox1;
        private TabControl mysingleTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox modelRichTextBox1;
        private GroupBox setParamGroupBox1;
        private Panel setParamPanel1;
    }
}
