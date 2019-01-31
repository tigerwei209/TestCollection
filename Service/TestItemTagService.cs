using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollection.Service
{
    public static class TestItemTagService
    {
        public static IEnumerable<string> GetAllTags()
        {
            return Core.DbContext.Instance.Query<string>("select distinct TagName from TestItemTag");
        }
    }
}
