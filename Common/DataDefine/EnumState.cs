using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDefine
{
    public enum EnumState
    {
        [Description("删除")]
        Delete = 0,
        [Description("正常")]
        Normal = 1,
    }
}
