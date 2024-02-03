using Common;
using DataDefine;
using FreeSql;

namespace Context
{
    /// <summary>
    /// ConnectionStrings
    /// https://freesql.net/guide/getting-started.html#connectionstrings
    /// </summary>
    public class ContextUtils
    {
        private static Dictionary<string, IFreeSql> keyValueDataBase= new Dictionary<string, IFreeSql>();

        public static IFreeSql AddDataBase(EnumDatabase enumDatabase,Func<KeyValArgs> setConnectString)
        {
            IFreeSql fsql  = GetDataBase(enumDatabase,setConnectString);
            KeyValArgs keyValArgs = setConnectString();
            string Key = keyValArgs.Key;
            keyValueDataBase.Add(Key,fsql);
            return fsql;
        }

        public static IFreeSql GetDataBase(string Key)
        {
            IFreeSql fsql;
            keyValueDataBase.TryGetValue(Key, out fsql);
            return fsql;
        }


        public static void RemoveDataBase(string Key)
        {
            keyValueDataBase.Remove(Key);
        }

        public static IFreeSql GetDataBase(EnumDatabase enumDatabase, Func<KeyValArgs> setConnectString)
        {
            FreeSql.DataType dataType = FreeSql.DataType.Sqlite;
            switch ((int)enumDatabase)
            {
                case (int)EnumDatabase.Sqlserver:
                    dataType = FreeSql.DataType.SqlServer;
                    break;
                case (int)EnumDatabase.Mysql:
                    dataType = FreeSql.DataType.MySql;
                    break;
                case (int)EnumDatabase.SqlLite:
                    dataType = FreeSql.DataType.Sqlite;
                    break;
            }
            KeyValArgs keyValArgs = setConnectString();
            if (keyValArgs == null)
            {
                throw new ArgumentNullException(nameof(keyValArgs));
            }
            IFreeSql fsql = new FreeSql.FreeSqlBuilder()
            .UseConnectionString(dataType, keyValArgs.ConnectString)
            .Build();
            return fsql;
        }

        public static string GetMysqlConnectString(string host, string port, string username, string password)
        {
            return $"Data Source={host};Port={port};User ID={username};Password={password}; Charset=utf8;Min pool size=1";
        }

        public static string GetSqlserverConnectString(string host,string username,string password,string initDB)
        {
            return $"Data Source={host};User Id={username};Password={password};Initial Catalog={initDB};Encrypt=True;TrustServerCertificate=True;Pooling=true;Min Pool Size=1";
        }

        public static string GetSqliteConnectString(string path,string Password="")
        {
            return $"Data Source={path};Pooling=true;Min Pool Size=1";
        }

        public static string GetWindowsSqlserverConnectString(string host,string initDB)
        {
            return $"Data Source={host};Initial Catalog={initDB};Integrated Security=SSPI;Pooling=true;Min Pool Size=1";
        }

        public static TaskBuild CreateTaskBuild(string Key,params string[] DataBaseName)
        {
            TaskBuild task = new TaskBuild();
            task.Fsql = GetDataBase(Key);
            if (DataBaseName != null && DataBaseName.Length>0)
            {
                task.tableInfos =  task.Fsql.DbFirst.GetTablesByDatabase(DataBaseName);
            }
            return task;
        }

        public static bool TestConnectDB(EnumDatabase enumDatabase, string connectString, out string errMsg)
        {
            errMsg = "";
            try
            {
                IFreeSql freeSql = GetDataBase(enumDatabase, () =>
                {
                    KeyValArgs keyValArgs = new KeyValArgs("", connectString);
                    return keyValArgs;
                });
                List<string> lst = freeSql.DbFirst.GetDatabases();
            }
            catch (Exception e)
            {
                errMsg = e.ToString();
                return false;
            }
            return true;
        }

        public static DBConnect CreateConnectDB(EnumDatabase enumDatabase,string Key, string connectString)
        {
            try
            {
                //string Key = MD5Helper.EncryptString(connectString);
                IFreeSql? freeSql;
                if(!keyValueDataBase.TryGetValue(Key, out freeSql))
                {
                    freeSql = AddDataBase(enumDatabase, () =>
                    {
                        return new KeyValArgs(Key, connectString);
                    });
                }
                return new DBConnect(freeSql);
            }
            catch (Exception e)
            {
                return new DBConnect(null,null);
            }
        }

        public static DBConnect? GetDBConnect(string Key)
        {
            IFreeSql? freeSql;
            if (keyValueDataBase.TryGetValue(Key, out freeSql))
            {
                return new DBConnect(freeSql);
            }
            return null;
        }

        public static bool ExistDBConnect(string Key,out DBConnect? dBConnect)
        {
            dBConnect = GetDBConnect(Key);
            return !(dBConnect == null);
        }

        public static bool DelDBConnect(string Key)
        {
            return keyValueDataBase.Remove(Key);
        }

    }

    public class KeyValArgs
    {
        private string _Key { get; set; }

        private string _ConnectString { get; set; }

        public KeyValArgs(string Key,string ConnectString)
        {
            this._Key = Key;
            this._ConnectString = ConnectString;
        }

        public string Key { get { return _Key; } }

        public string ConnectString { get { return _ConnectString; } }

        public override string ToString()
        {
            return this._ConnectString;
        }
    }

}
