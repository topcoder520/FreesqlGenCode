using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreesqlGenCode.controls
{
    public partial class FsLine
    {
        public FsTableControl? Node { get; set; }

        private Point _Start { get; set; } = new Point(0,0);

        private Point _End { get; set; } = new Point(0,0);

        public FsLine() { }

        public Point GetStart() { return new Point(_Start.X, _Start.Y); }

        public Point GetEnd() { return new Point(_End.X, _End.Y); }

        public void SetStart(Point point)
        {
            _Start = new Point(point.X,point.Y);
        }
        public void SetEnd(Point point)
        {
            _End = new Point(point.X, point.Y);
        }
        /// <summary>
        /// 画线
        /// </summary>
        /// <param name="e"></param>
        public void OnPaint(PaintEventArgs e)
        {
            int width = 8;
            int height = 8;
            Pen pen = new Pen(Color.Red);
            Graphics g = e.Graphics;
            g.DrawLine(pen, _Start, _End);
            
            Brush bush = new SolidBrush(Color.Red);//填充的颜色
            //g.DrawEllipse(pen, _Start.X, _Start.Y - height/2, width, height);
            g.FillEllipse(bush, _Start.X, _Start.Y - height / 2, width, height);
            g.DrawEllipse(pen,_End.X,_End.Y - height / 2, width,height);
            bush.Dispose();
            pen.Dispose();
        }

        public void ResetPoint()
        {
            if(this.Node != null)
            {
                this._Start = this.Node.PrevNode.RightPoint();
                this._End = this.Node.LeftPoint(-10);
            }
        }

    }

    public partial class FsLine
    {
        /// <summary>
        /// 0 待删除  1 正常
        /// </summary>
        public int Flag { get; set; } = 1; 

        /// <summary>
        /// 开始节点
        /// </summary>
        public string StartTable { get; set; }

        public string StartTableAlias { get; set; } = "";

        public string StartColumn { get; set; }
        /// <summary>
        /// 结束节点
        /// </summary>
        public string EndTable { get; set; }

        public string EndTableAlias { get; set; } = "";

        public string EndColumn { get; set; }
        /// <summary>
        /// 连接类型
        /// </summary>
        public EnumJoinType JoinType { get; set; }

        public EnumJoinType GetEnumJoinTypeBy(string des)
        {
            if (!string.IsNullOrWhiteSpace(des))
            {
                foreach (EnumJoinType item in Enum.GetValues(typeof(EnumJoinType)))
                {
                    if (item.GetDescription() == des)
                    {
                        return item;
                    }
                }
            }
            return EnumJoinType.LeftJoin;
        }

        public string GetStartTableName()
        {
            return string.IsNullOrWhiteSpace(StartTableAlias) ? StartTable : StartTableAlias;
        }
        public string GetEndTableName()
        {
            return string.IsNullOrWhiteSpace(EndTableAlias) ? EndTable : EndTableAlias;
        }


        // left join Address a on a.Id = User.Id
        public override string ToString()
        {
            string StartTableName = GetStartTableName();
            string EndTableName = GetEndTableName();
            StringBuilder sb = new StringBuilder();
            sb.Append(JoinType.GetDescription());
            sb.Append(" ");
            sb.Append(EndTable);
            sb.Append(" ");
            sb.Append(EndTableAlias);
            sb.Append(" ON ");
            sb.Append(EndTableName);
            sb.Append(".");
            sb.Append(EndColumn);
            sb.Append(" = ");
            sb.Append(StartTableName);
            sb.Append(".");
            sb.Append(StartColumn);
            return sb.ToString();
        }

        public string GetSimpleString()
        {
            return string.Join("",new string[] { StartTable,".",StartColumn,"=",EndTable,".",EndColumn,"\n"});
        }
    }

    public enum EnumJoinType
    {
        [System.ComponentModel.Description("LEFT JOIN ")]
        LeftJoin = 0,
        [System.ComponentModel.Description("RIGHT JOIN ")]
        RightJoin = 1,
        [System.ComponentModel.Description("INNER JOIN ")]
        InnerJoin = 2,
    }
}
