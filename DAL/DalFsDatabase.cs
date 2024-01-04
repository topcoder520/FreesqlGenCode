using Common;
using Context;
using DataDefine;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalFsDatabase : SqlBase
    {
        public DalFsDatabase()
        {

        }


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            return fsql.Select<FsDatabase>().Where(a => a.Id == Id).Any();
        }

        public bool Exists(System.Linq.Expressions.Expression<Func<FsDatabase, bool>> whereExpression)
        {
            return fsql.Select<FsDatabase>().Where(whereExpression).Any();
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FsDatabase model)
        {
            return (int)fsql.Insert<FsDatabase>().AppendData(model).ExecuteIdentity();
        }
        public int BatchInsert(List<FsDatabase> listModel)
        {
            return fsql.Insert<FsDatabase>().AppendData(listModel).ExecuteAffrows();
        }

        public int Update(Expression<Func<FsDatabase, FsDatabase>> columns, Expression<Func<FsDatabase, bool>> whereExpression)
        {
            return fsql.Update<FsDatabase>().Set(columns).Where(whereExpression).ExecuteAffrows();
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int Id)
        {
            return fsql.Update<FsDatabase>().Set(a => a.State, (int)EnumState.Delete).Where(a => a.Id == Id).ExecuteAffrows();
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public int DeleteList(List<int> Idlist)
        {
            return fsql.Update<FsDatabase>().Set(a => a.State, (int)EnumState.Delete).Where(a => Idlist.Contains(a.Id)).ExecuteAffrows();
        }
        public int Delete(Expression<Func<FsDatabase, bool>> whereExpression)
        {
            return fsql.Update<FsDatabase>().Set(a => a.State, (int)EnumState.Delete).Where(whereExpression).ExecuteAffrows();
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FsDatabase GetModel(int Id)
        {
            return fsql.Select<FsDatabase>().Where(a => a.Id == Id).First();
        }
        public FsDatabase GetModel(Expression<Func<FsDatabase, bool>> whereExpression)
        {
            return fsql.Select<FsDatabase>().Where(whereExpression).First();
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FsDatabase> GetList(Expression<Func<FsDatabase, bool>> whereExpression, int? Top = null, string orderBy = "")
        {
            var temp = fsql.Select<FsDatabase>().Where(whereExpression);
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
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(Expression<Func<FsDatabase, bool>> whereExpression)
        {
            return (int)fsql.Select<FsDatabase>().Where(whereExpression).Count();
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        public PagedResult<FsDatabase> GetListByPage(Expression<Func<FsDatabase, bool>> whereExpression, int pageIndex, int pageSize)
        {
            var list = fsql.Select<FsDatabase>().Where(whereExpression).Count(out var total).Page(pageIndex, pageSize).ToList();
            return new PagedResult<FsDatabase>(pageSize, pageIndex, (int)total, list);
        }



    }
}
