using FreeSql.DatabaseModel;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class DBConnect
    {
        private IFreeSql? freeSql { get; set; }

        private Exception? error { get; set; }

        public DBConnect(IFreeSql? freeSql) {
            this.freeSql = freeSql;
        }

        public DBConnect(IFreeSql? freeSql,Exception? e)
        {
            this.freeSql = freeSql;
            this.error = e;
        }

        public string GetException()
        {
            return error == null?"":error.ToString();
        }

        public bool TestConnect()
        {
            if(freeSql == null)
            {
                return false;
            }
            try
            {
                List<string> lst = freeSql.DbFirst.GetDatabases();
                Common.Console.Log("Success! Tables > "+string.Join(",",lst));
                return true;
            }
            catch (Exception e)
            {
                error = e;
                return false;
            }
        }

        //获取连接的数据库
        public List<string> GetDataBases() {
            if (!TestConnect())
            {
                return new List<string>();
            }
            List<string> lst = freeSql.DbFirst.GetDatabases();
            return lst;
        }
        /// <summary>
        /// 获取数据表
        /// </summary>
        /// <param name="database"></param>
        /// <returns></returns>
        public List<string> GetTableNamesBy(string database) {
            List<DbTableInfo> lst =  freeSql.DbFirst.GetTablesByDatabase(database);
            List<string> tables = lst.Select(t => string.IsNullOrWhiteSpace(t.Schema)? t.Name:(t.Schema+"."+t.Name)).ToList();
            return tables;
        }

        public List<TableInfo> GetTablesBy(string database)
        {
            List<DbTableInfo> lst = freeSql.DbFirst.GetTablesByDatabase(database);
            List<TableInfo> tables = new List<TableInfo>();
            foreach (var item in lst)
            {
                tables.Add(new TableInfo() { 
                    Name = string.IsNullOrWhiteSpace(item.Schema) ? item.Name : (item.Schema + "." + item.Name),
                    Comment = item.Comment,
                    Schema = item.Schema,
                    DbTableType = item.Type.ToString(),
                    Columns = item.Columns.Count,
                    Indexes = item.Indexes.Count
                });
            }
            return tables;
        }

        public TableInfo GetTableInfo(string tableName)
        {
            DbTableInfo dbTableInfo =  freeSql.DbFirst.GetTableByName(tableName);
            List<DbColumnInfo> listCol =  dbTableInfo.Columns;

            TableInfo info = new TableInfo();
            info.colInfos = new List<ColInfo>();
            foreach (var item in listCol)
            {
                ColInfo colInfo = new ColInfo();
                colInfo.Name = item.Name;
                colInfo.CsType = item.CsType.FullName;
                colInfo.DbType = item.DbType;
                colInfo.DbTypeText = item.DbTypeText;
                colInfo.DbTypeTextFull= item.DbTypeTextFull;
                colInfo.MaxLength = item.MaxLength;
                colInfo.IsPrimary = item.IsPrimary.ToString();
                colInfo.IsIdentity = item.IsIdentity.ToString();
                colInfo.IsNullable= item.IsNullable.ToString();
                colInfo.Coment = item.Comment;

                info.colInfos.Add(colInfo);
            }
            return info;
        }

        public List<string> GetColNameList(string tableName)
        {
            DbTableInfo dbTableInfo = freeSql.DbFirst.GetTableByName(tableName);
            List<DbColumnInfo> listCol = dbTableInfo.Columns;

            List<string> lists = new List<string>();
            foreach (var item in listCol)
            {
                lists.Add(item.Name);
            }
            return lists;
        }

        public List<List<string>> GetColInfos(string tableName)
        {
            DbTableInfo dbTableInfo = freeSql.DbFirst.GetTableByName(tableName); 
            List<DbColumnInfo> listCol = dbTableInfo.Columns;

            List<List<string>> lists = new List<List<string>>();
            foreach (var item in listCol)
            {
                List<string> strings = new List<string>
                {
                    item.Name,
                    item.CsType.FullName,
                    item.DbType.ToString(),
                    item.DbTypeText,
                    item.DbTypeTextFull,
                    item.MaxLength.ToString(),
                    item.IsPrimary.ToString(),
                    item.IsIdentity.ToString(),
                    item.IsNullable.ToString(),
                    item.Comment
                };
                lists.Add(strings);
            }
            return lists;
        }
    }
}
