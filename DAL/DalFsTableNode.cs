using Context;
using DataDefine;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalFsTableNode : SqlBase
    {
        public DalFsTableNode() { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FsTableNode model)
        {
            return (int)fsql.Insert<FsTableNode>().AppendData(model).ExecuteIdentity();
        }

        public int Update(Expression<Func<FsTableNode, FsTableNode>> columns, Expression<Func<FsTableNode, bool>> whereExpression)
        {
            return fsql.Update<FsTableNode>().Set(columns).Where(whereExpression).ExecuteAffrows();
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int Id)
        {
            return fsql.Update<FsTableNode>().Set(a => a.State, (int)EnumState.Delete).Where(a => a.Id == Id).ExecuteAffrows();
        }

        public int Delete(Expression<Func<FsTableNode, bool>> whereExpession)
        {
            return fsql.Update<FsTableNode>().Set(a => a.State, (int)EnumState.Delete).Where(whereExpession).ExecuteAffrows();
        }

        public int DeleteReal(int QueryViewId)
        {
            return fsql.Delete<FsTableNode>(new
            {
                QueryViewId = QueryViewId
            }).ExecuteAffrows();
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FsTableNode GetModel(int Id)
        {
            return fsql.Select<FsTableNode>().Where(a => a.Id == Id).First();
        }
        public FsTableNode GetModel(Expression<Func<FsTableNode, bool>> whereExpression)
        {
            return fsql.Select<FsTableNode>().Where(whereExpression).First();
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FsTableNode> GetList(Expression<Func<FsTableNode, bool>> whereExpression, int? Top = null, string orderBy = "")
        {
            var temp = fsql.Select<FsTableNode>().Where(whereExpression);
            if (Top != null)
            {
                temp = temp.Limit(Top.Value);
            }
            if (!string.IsNullOrWhiteSpace(orderBy))
            {
                temp = temp.OrderBy(orderBy);
            }
            return temp.ToList();


        }

    }
}
