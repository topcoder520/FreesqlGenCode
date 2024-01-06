using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class TableInfo
    {
        public TableInfo() { }

        public string Name { get; set; }

        public string Comment { get; set; }

        public string Schema { get; set; }

        public string DbTableType { get; set; }

        public int Columns { get; set; }

        public int Indexes { get; set; }

        public List<ColInfo> colInfos { get; set; }
        
    }

    public class ColInfo
    {
        public ColInfo() { }

        public string Name { get; set; }

        public string? CsType { get; set; }
        public int DbType { get; set; }

        public string DbTypeText { get; set; }

        public string DbTypeTextFull { get; set; }

        public int MaxLength { get; set; }

        public string IsPrimary { get; set; }

        public string IsIdentity { get; set; }

        public string IsNullable { get; set; }

        public string Coment { get; set; }
    }

}
