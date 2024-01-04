using FreeSql.Sqlite;
using NetTopologySuite.GeometriesGraph;
using System;
using System.Data.SQLite;
using System.IO;

namespace Context
{
    public class SqlBase
    {
        public SqlBase() {
        }

        //static string path = Path.Combine(Directory.GetCurrentDirectory(), "freesqlgcodedb.db");
        static string path = Path.Combine("C:\\Users\\Administrator\\Desktop", "freesqlgcodedb.db");

        public static IFreeSql fsql
            = new FreeSql.FreeSqlBuilder()
        .UseConnectionString(FreeSql.DataType.Sqlite, $"Data Source={path}")
        //.UseMonitorCommand(cmd => Console.WriteLine($"Sql：{cmd.CommandText}"))//监听SQL语句
        // .UseAutoSyncStructure(true) //自动同步实体结构到数据库，FreeSql不会扫描程序集，只有CRUD时才会生成表。
        .Build()
            ;

        static SqlBase()
        {
            //输出调用SQL到控制台 开发调式用
            fsql.Aop.CurdAfter += (s, e) =>
            {
                System.Diagnostics.Debug.WriteLine("\n\t"+e.Sql + "\n\t");
            };
        }
    }
}
