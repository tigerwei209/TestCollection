using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollection.Core
{
    [PrimaryKey("TagId", AutoIncrement = true)]
    public class TestItemTag
    {
        public int? TagId { get; set; }
        public string TagName { get; set; }
        public int? ItemId { get; set; }
    }
}
