using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollection.Service
{
    public static class TestItemService
    {
        public static IEnumerable<Core.TestItem> GetTestItems()
        {
            return Core.DbContext.Instance.Query<Core.TestItem>("select * from testitem");
        }

        public static void Save(Core.TestItem item)
        {
            var tags = item.Tags?.Split(',');
            using (var trans = Core.DbContext.Instance.GetTransaction())
            {
                if (item.ItemId == null)
                {
                    var a = Core.DbContext.Instance.Insert(item);
                }
                else
                {
                    //更新
                    Core.DbContext.Instance.Update(item);
                    //删除所有标签
                    Core.DbContext.Instance.Delete<Core.TestItemTag>("where ItemId=@0", item.ItemId);
                }

                if (tags != null)
                {
                    foreach (var tag in tags)
                    {
                        Core.DbContext.Instance.Execute("insert into TestItemTag (TagName,ItemId) values (@0,@1)", tag, item.ItemId);
                    }
                }
                trans.Complete();
            }
            
        }

        public static void Delete(int itemId)
        {
            Core.DbContext.Instance.Delete<Core.TestItem>("where ItemId=@0", itemId);
        }
    }
}
