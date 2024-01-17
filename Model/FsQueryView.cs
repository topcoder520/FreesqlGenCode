using FreeSql.DataAnnotations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = false)]
    public class FsQueryView
    {
        [JsonProperty, Column(IsPrimary = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 查询名字
        /// </summary>
        [JsonProperty, Column(StringLength = -2)]
        public string QueryName { get; set; }
        /// <summary>
        /// 数据库连接的标识符
        /// </summary>
        [JsonProperty, Column(StringLength = -2)]
        public string DBKey { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty, Column(StringLength = -2)]
        public string DBName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty, Column(StringLength = -2)]
        public string Comment { get; set; }

        [JsonProperty]
        public int State { get; set; }

    }
}
