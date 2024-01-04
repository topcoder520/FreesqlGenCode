using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Console
    {
        public static void Log(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}
