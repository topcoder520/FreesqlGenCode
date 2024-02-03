using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public  class FileUtil
    {
        public static FileInfo[] loadTemplates(string dirName)
        {
            string path = Path.Combine(Environment.CurrentDirectory, dirName);
            DirectoryInfo fdir = new DirectoryInfo(path);
            FileInfo[] files = fdir.GetFiles("*.cshtml");
            return files;
        }
    }
}
