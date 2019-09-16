using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollection.Service
{
    public static class DbVersionService
    {
        public static Dictionary<int, List<string>> UpdateSql = new Dictionary<int, List<string>>()
        {
            { 1, new List<string>() { "ALTER TABLE TestItem ADD Score INT(10)" } }
        };
        public static void UpdateDb()
        {
            var count = Core.DbContext.Instance.ExecuteScalar<int>("SELECT COUNT(*) FROM sqlite_master where type='table' and name='DbVersion'");
            if (count == 0)
            {
                Core.DbContext.Instance.Execute(@"CREATE TABLE [DbVersion](
  [id] INTEGER PRIMARY KEY,
  [version] INTEGER)");
            }
            var dbVersion = Core.DbContext.Instance.SingleOrDefault<Core.DbVersion>(1);
            if (dbVersion == null)
            {
                dbVersion = new Core.DbVersion() { id = 1, version = 0 };
                Core.DbContext.Instance.Insert(dbVersion);
            }
            var updates = UpdateSql.Where(kv => kv.Key > dbVersion.version).ToList();
            if (updates.Count == 0)
            {
                return;
            }
            foreach (var kv in updates)
            {
                foreach (var sql in kv.Value)
                {
                    try
                    {
                        Core.DbContext.Instance.Execute(sql);
                    }
                    catch (Exception)
                    {
                        //todo
                    }
                }
                dbVersion.version = kv.Key;
            }
            Core.DbContext.Instance.Update(dbVersion);
        }
    }
}
