using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreesqlGenCode.controls
{
    public partial class JoinTableColumnRow : UserControl
    {
        public JoinTableColumnRow()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            List<string> comboxDes = new List<string>();
            foreach (EnumJoinType item in Enum.GetValues(typeof(EnumJoinType)))
            {
                comboxDes.Add(GetDescription(item));
            }
            comboBox1.Items.AddRange(comboxDes.ToArray());
            comboBox1.SelectedItem = comboBox1.Items[0];
            FsLine fsLine = (FsLine)this.Tag;
            if (fsLine != null)
            {
                string StartTableName = fsLine.GetStartTableName();
                string EndTableName = fsLine.GetEndTableName();

                label1.Text = EndTableName + "." + fsLine.EndColumn;
                label2.Text = StartTableName + "." + fsLine.StartColumn;

                label3.Text = fsLine.EndTable;
                label6.Text = fsLine.EndTableAlias;

                comboBox1.SelectedItem = GetDescription(fsLine.JoinType);
            }

        }


        public event EventHandler DelRowEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs =  MessageBox.Show("是否删除该字段相关外键数据", "提示", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                DelRowEvent?.Invoke(this,e);
            }
        }

        public void SyncInfo()
        {
            FsLine fsLine = (FsLine)this.Tag;
            if(fsLine != null)
            {
               fsLine.JoinType = fsLine.GetEnumJoinTypeBy(comboBox1.SelectedText);
            }
        }
        public string GetDescription(Enum arg)
        {
            Type t = arg.GetType();
            string name = Enum.GetName(t, arg);
            FieldInfo fInfo = t.GetField(name);
            DescriptionAttribute attr = Attribute.GetCustomAttribute(fInfo, typeof(DescriptionAttribute), false) as DescriptionAttribute;
            if (attr != null)
            {
                return attr.Description;
            }
            return "";

        }
    }
}
