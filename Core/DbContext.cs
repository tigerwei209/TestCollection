using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollection.Core
{
    public class DbContext : Database
    {
        private DbContext()
            : base("DbConn")
        {
            KeepConnectionAlive = true;
        }

        public static DbContext Instance = new DbContext();

    }
}
