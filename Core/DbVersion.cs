using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollection.Core
{
    [PrimaryKey("id", AutoIncrement = false)]
    public class DbVersion
    {
        public int? id { get; set; }
        public int? version { get; set; }
    }
}
