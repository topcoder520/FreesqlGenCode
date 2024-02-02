using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FreesqlGenCode.controls
{
    public class MyTabControl : TabControl
    {
        private int IconWOrH = 16;
        private Image icon = null;
        private Image iconRed = null;

        public MyTabControl() :base() {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;

            icon = Properties.Resources.close;
            IconWOrH = icon.Width;
            IconWOrH = icon.Height +4;

            iconRed = Properties.Resources.closeRed;
        }

        

        private int yoffset = 8;

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = GetTabRect(e.Index);
            string title = this.TabPages[e.Index].Text;
            title = handleString(title, r.Width-30);
            if (e.Index == this.SelectedIndex)    //当前选中的Tab页，设置不同的样式以示选中
            {
                Brush selected_color = Brushes.White; //选中的项的背景色
                g.FillRectangle(selected_color, r); //改变选项卡标签的背景色
                g.DrawString(title, this.Font, new SolidBrush(Color.Black), new PointF(r.X, r.Y + 5));//PointF选项卡标题的位置
                r.Offset(r.Width - IconWOrH, yoffset);
                g.DrawImage(iconRed, new Point(r.X, r.Y));//选项卡上的图标的位置 fntTab = new System.Drawing.Font(e.Font, FontStyle.Bold);
            }
            else//非选中的
            {
                Brush selected_color = Brushes.WhiteSmoke; //选中的项的背景色
                g.FillRectangle(selected_color, r); //改变选项卡标签的背景色
                g.DrawString(title, this.Font, new SolidBrush(Color.Black), new PointF(r.X, r.Y + 5));//PointF选项卡标题的位置
                r.Offset(r.Width - IconWOrH, yoffset);
                g.DrawImage(icon, new Point(r.X, r.Y));//选项卡上的图标的位置
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            Point point = e.Location;
            Rectangle r = GetTabRect(this.SelectedIndex);
            r.Offset(r.Width - IconWOrH - 3, yoffset);
            r.Width = IconWOrH;
            r.Height = IconWOrH;
            if (r.Contains(point))
            {
                TabPage tabPage = this.TabPages[this.SelectedIndex];
                if(this.SelectedIndex == 0 && tabPage.Tag == null)
                {
                    MessageBox.Show("默认页不允许关闭");
                    return;
                }
                this.TabPages.RemoveAt(this.SelectedIndex);
            } 
        }

        private string handleString(string text,int maxLen)
        {
            int textLen = GetStringLength(text);
            if (textLen <= maxLen) { 
                return text;
            }
            //计算一定宽度内能容纳多少个字符
            int len = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                len += GetStringLength(text[i].ToString());
                if(len > maxLen)
                {
                    break;
                }
                sb.Append(text[i]);
            }
            return sb.ToString() +"...";
        }

        private int GetStringLength(string text,int addLength = 0)
        {
            Font f = this.Font;
            Size size =  TextRenderer.MeasureText(text,f,new Size(0,0),TextFormatFlags.NoPadding);
            return size.Width + addLength;
        }
    }
}
