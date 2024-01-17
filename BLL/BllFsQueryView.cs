using Common;
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
    public class BllFsQueryView
    {
        public BllFsQueryView() { }

        private readonly DalFsQueryView dal = new DalFsQueryView();

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FsQueryView model)
        {
            return dal.Add(model);
        }
        public int Update(Expression<Func<FsQueryView, FsQueryView>> columns, Expression<Func<FsQueryView, bool>> whereExpression)
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
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FsQueryView GetModel(int Id)
        {
            return dal.GetModel(Id);
        }

        public FsQueryView GetModel(Expression<Func<FsQueryView, bool>> whereExpression)
        {
            return dal.GetModel(whereExpression);
        }
        /// <summary>
        /// 获取记录
        /// </summary>
        public List<FsQueryView> GetList(Expression<Func<FsQueryView, bool>> whereExpression, int? Top = null, string orderBy = "")
        {
            return dal.GetList(whereExpression, Top, orderBy);
        }

    }
}
