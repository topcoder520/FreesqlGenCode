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
    public class FsTableNode
    {
        [JsonProperty, Column(IsPrimary = true, IsIdentity = true)]
        public int Id { get; set; }
        /// <summary>
        /// 父节点
        /// </summary>
        [JsonProperty]
        public int ParentId { get; set; }

        [JsonProperty, Column(StringLength = -2)]
        public string NodeName { get; set; }


        [JsonProperty, Column(StringLength = -2)]
        public string TableName { get; set; }

        [JsonProperty, Column(StringLength = -2)]
        public string TableNameAlias { get; set; }

        [JsonProperty, Column(StringLength = -2)]
        public string TableColumn { get; set; }


        [JsonProperty, Column(StringLength = -2)]
        public string ParentTableName { get; set; }

        [JsonProperty, Column(StringLength = -2)]
        public string ParentTableNameAlias { get; set; }

        [JsonProperty, Column(StringLength = -2)]
        public string ParentTableColumn { get; set; }

        /// <summary>
        /// EnumJoinType
        /// </summary>
        [JsonProperty]
        public int JoinType { get; set; }


        /// <summary>
        /// 查询Id
        /// </summary>
        [JsonProperty]
        public int QueryViewId { get; set; }

        [JsonProperty]
        public int Col { get; set; }

        [JsonProperty]
        public int LocationX { get; set; }

        [JsonProperty]
        public int LocationY { get; set; }

        /// <summary>
        /// 要查询的字段的拼接
        /// </summary>
        [JsonProperty, Column(StringLength = -2)]
        public string QueryFields { get; set; }

        [JsonProperty]
        public int State { get; set; }
    }
}
