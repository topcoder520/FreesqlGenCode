using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class EnumExtendUtil
    {
        /// <summary>获取枚举属性描述</summary>
        public static string GetDescription(this Enum arg)
        {
            Type t = arg.GetType();
            string name = Enum.GetName(t, arg);
            FieldInfo fInfo = t.GetField(name);
            DescriptionAttribute attr = Attribute.GetCustomAttribute(fInfo, typeof(DescriptionAttribute), false) as DescriptionAttribute;
            if (attr != null)
            {
                return attr.Description;
            }
            return "";

        }
    }
}
