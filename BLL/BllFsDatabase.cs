using Common;
using DAL;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllFsDatabase
    {
        public BllFsDatabase() { }

        private readonly DalFsDatabase dal = new DalFsDatabase();

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            return dal.Exists(Id);
        }
        public bool Exists(Expression<Func<FsDatabase, bool>> whereExpression)
        {
            return dal.Exists(whereExpression);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FsDatabase model) { 
            if (string.IsNullOrWhiteSpace(model.DBKey))
            {
                model.DBKey = Guid.NewGuid().ToString();
            }
            return dal.Add(model);
        }
        public int BatchInsert(List<FsDatabase> listModel)
        {
            foreach (FsDatabase fsDatabase in listModel)
            {
                if (string.IsNullOrWhiteSpace(fsDatabase.DBKey))
                {
                    fsDatabase.DBKey = Guid.NewGuid().ToString();
                }
            }
            return dal.BatchInsert(listModel);
        }
        public int Update(Expression<Func<FsDatabase, FsDatabase>> columns, Expression<Func<FsDatabase, bool>> whereExpression)
        {
            return dal.Update(columns, whereExpression);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(dynamic Id)
        {
            return dal.Delete(Id);
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public int DeleteList(List<int> Idlist)
        {
            return dal.DeleteList(Idlist);
        }

        public int Delete(Expression<Func<FsDatabase, bool>> whereExpression)
        {
            return dal.Delete(whereExpression);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FsDatabase GetModel(int Id)
        {
            return dal.GetModel(Id);
        }

        public FsDatabase GetModel(Expression<Func<FsDatabase, bool>> whereExpression)
        {
            return dal.GetModel(whereExpression);
        }
        /// <summary>
        /// 获取记录
        /// </summary>
        public List<FsDatabase> GetList(Expression<Func<FsDatabase, bool>> whereExpression, int? Top = null, string orderBy = "")
        {
            return dal.GetList(whereExpression, Top, orderBy);
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(Expression<Func<FsDatabase, bool>> whereExpression)
        {
            return dal.GetRecordCount(whereExpression);
        }
        public PagedResult<FsDatabase> GetListByPage(Expression<Func<FsDatabase, bool>> whereExpression, int pageIndex, int pageSize)
        {
            return dal.GetListByPage(whereExpression, pageIndex, pageSize);
        }

    }
}
