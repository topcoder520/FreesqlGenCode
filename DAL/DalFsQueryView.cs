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
    public class DalFsQueryView : SqlBase
    {
        public DalFsQueryView() { }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FsQueryView model)
        {
            return (int)fsql.Insert<FsQueryView>().AppendData(model).ExecuteIdentity();
        }

        public int Update(Expression<Func<FsQueryView, FsQueryView>> columns, Expression<Func<FsQueryView, bool>> whereExpression)
        {
            return fsql.Update<FsQueryView>().Set(columns).Where(whereExpression).ExecuteAffrows();
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int Id)
        {
            return fsql.Update<FsQueryView>().Set(a => a.State, (int)EnumState.Delete).Where(a => a.Id == Id).ExecuteAffrows();
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FsQueryView GetModel(int Id)
        {
            return fsql.Select<FsQueryView>().Where(a => a.Id == Id).First();
        }
        public FsQueryView GetModel(Expression<Func<FsQueryView, bool>> whereExpression)
        {
            return fsql.Select<FsQueryView>().Where(whereExpression).First();
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FsQueryView> GetList(Expression<Func<FsQueryView, bool>> whereExpression, int? Top = null, string orderBy = "")
        {
            var temp = fsql.Select<FsQueryView>().Where(whereExpression);
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
