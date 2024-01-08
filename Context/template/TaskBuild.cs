using FreeSql.DataAnnotations;
using FreeSql.DatabaseModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class TaskBuild
    {

        public string GeneratePath { get; set; }
        public string FileName { get; set; }
        public string DbName { get; set; }
        public IFreeSql Fsql { get; set; }
        public string FilterTableChar { get; set; }
        public string NamespaceName { get; set; }
        /// <summary>
        /// 首字母大写
        /// </summary>
        public bool FirstUpper { get; set; } = false;
        /// <summary>
        /// 全部小写
        /// </summary>
        public bool AllLower { get; set; } = false;
        /// <summary>
        /// 下划线转驼峰
        /// </summary>
        public bool UnderLineTranser { get; set; } = false;
        /// <summary>
        /// 覆盖重名文件
        /// </summary>
        public bool CoverExistFile { get; set; } = false;
        /// <summary>
        /// 跳过同名文件
        /// </summary>
        public bool skipSameNameFile { get; set; } = false;

        public ICollection<Template> Templates { get; set; }

        public string tableName { get; set; }

        public List<DbTableInfo> tableInfos { get; set; }   

    }

    public class Template
    {
        public string TemplateName { get; set; }
        public string TemplatePath { get; set; }

        public string TemplateText { get; set; }

        public bool IsChangeText { get; set; }
    }
}
