using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Common
{
    [DataContract]
    [Serializable]
    public class PagedResultBase
    {
        /// <summary>
        /// 获取或设置总记录数。
        /// </summary>
        [DataMember(IsRequired = false)]
        public int TotalItemCount { get; set; }
        /// <summary>
        /// 获取或设置页面大小。
        /// </summary>
        [DataMember(IsRequired = false)]
        public int PageSize { get; set; }
        /// <summary>
        /// 当前页码
        /// </summary>
        [DataMember(IsRequired = false)]
        public int CurrentPageIndex { get; set; }
        /// <summary>
        /// 获取页数。
        /// </summary>
        [DataMember(IsRequired = false)]
        public int TotalPageCount
        {
            get
            {
                if (TotalItemCount > 0 && PageSize > 0)
                {
                    var remainder = TotalItemCount % PageSize;
                    var ceil = TotalItemCount / PageSize;

                    return remainder == 0 ? ceil : ceil + 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public PagedResultBase()
        {
        }

        public PagedResultBase(int pageSize, int pageIndex)
        {
            this.PageSize = pageSize;
            this.CurrentPageIndex = pageIndex;
        }

        public PagedResultBase(int pageSize, int pageIndex, int totalItemCount) :
            this(pageSize, pageIndex)
        {
            this.TotalItemCount = totalItemCount;
        }

    }

    [DataContract]
    [Serializable]
    public class PagedResult<T> : PagedResultBase
    {
        /// <summary>
        /// 初始化一个新的<c>PagedResult{T}</c>类型的实例。
        /// </summary>
        public PagedResult()
        {
            this.Data = new List<T>();
        }

        public PagedResult(int pageSize, int pageIndex)
            : this()
        {
            this.PageSize = pageSize;
            this.CurrentPageIndex = pageIndex;
        }

        public PagedResult(int pageSize, int pageIndex, int totalItemCount)
            : this(pageSize, pageIndex)
        {
            this.TotalItemCount = totalItemCount;
        }


        public PagedResult(int pageSize, int pageIndex, int totalItemCount, List<T> pageData)
            : this(pageSize, pageIndex, totalItemCount)
        {
            this.PageSize = pageSize;
            this.CurrentPageIndex = pageIndex;
            this.TotalItemCount = totalItemCount;
            this.Data = pageData;
        }

        #region Public Properties

        /// <summary>
        /// 获取或设置当前页面的数据。
        /// </summary>
        [DataMember(IsRequired = false)]
        public List<T> Data { get; set; }
        #endregion        


        //public PagedResultDynamic ToDynamicResult(Func<T, dynamic> selector)
        //{
        //    PagedResultDynamic result = new PagedResultDynamic(this.PageSize, this.CurrentPageIndex, this.TotalItemCount);
        //    result.Data = JsonConvert.DeserializeObject(JsonConvert.SerializeObject(this.Data.Select(selector)));
        //    return result;
        //}
    }

    /// <summary>
    /// 对linq 的扩展，转换成PagedResult对象
    /// </summary>
    public static class PagedResultExtended
    {
        /// <summary>
        /// 对IQueryable 的扩展，转换成PagedResult对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="allItems"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public static PagedResult<T> ToPagedResult<T>(this IQueryable<T> allItems, int pageIndex, int pageSize)
        {
            if (pageIndex < 1)
                pageIndex = 1;
            var itemIndex = (pageIndex - 1) * pageSize;
            var totalItemCount = allItems.Count();
            while (totalItemCount <= itemIndex && pageIndex > 1)
            {
                itemIndex = (--pageIndex - 1) * pageSize;
            }
            var pageOfItems = allItems.Skip(itemIndex).Take(pageSize).ToList();
            return new PagedResult<T>(pageSize, pageIndex, totalItemCount, pageOfItems);
        }

        /// <summary>
        /// 对IEnumerable 的扩展，转换成PagedResult对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="allItems"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public static PagedResult<T> ToPagedResult<T>(this IEnumerable<T> allItems, int pageIndex, int pageSize)
        {
            if (pageIndex < 1)
                pageIndex = 1;
            var itemIndex = (pageIndex - 1) * pageSize;
            var totalItemCount = allItems.Count();
            while (totalItemCount <= itemIndex && pageIndex > 1)
            {
                itemIndex = (--pageIndex - 1) * pageSize;
            }
            var pageOfItems = allItems.Skip(itemIndex).Take(pageSize).ToList();
            return new PagedResult<T>(pageSize, pageIndex, totalItemCount, pageOfItems);
        }
    }
}