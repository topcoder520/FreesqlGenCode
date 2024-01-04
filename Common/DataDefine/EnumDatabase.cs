using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDefine
{
    public enum EnumDatabase
    {
        [System.ComponentModel.Description("Sqlserver")]
        Sqlserver = 0,
        [System.ComponentModel.Description("Mysql")]
        Mysql = 1,
        [System.ComponentModel.Description("SqlLite")]
        SqlLite = 2,
    }
}
