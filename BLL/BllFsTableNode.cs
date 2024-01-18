using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllFsTableNode
    {
        public BllFsTableNode() { }

        private readonly DalFsTableNode dal = new DalFsTableNode();

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FsTableNode model)
        {
            return dal.Add(model);
        }
        public int Update(Expression<Func<FsTableNode, FsTableNode>> columns, Expression<Func<FsTableNode, bool>> whereExpression)
        {
            return dal.Update(columns, whereExpression);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int Id)
        {
            return dal.Delete(Id);
        }
        public int Delete(Expression<Func<FsTableNode, bool>> whereExpession)
        {
            return dal.Delete(whereExpession);
        }
        public int DeleteReal(int QueryViewId)
        {
            return dal.DeleteReal(QueryViewId);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FsTableNode GetModel(int Id)
        {
            return dal.GetModel(Id);
        }

        public FsTableNode GetModel(Expression<Func<FsTableNode, bool>> whereExpression)
        {
            return dal.GetModel(whereExpression);
        }
        /// <summary>
        /// 获取记录
        /// </summary>
        public List<FsTableNode> GetList(Expression<Func<FsTableNode, bool>> whereExpression, int? Top = null, string orderBy = "")
        {
            return dal.GetList(whereExpression, Top, orderBy);
        }

    }
}
