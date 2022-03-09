using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class MongoContext : IMongodb
    {

        public string Server { get; set; }
        public string Database { get; set; }
    }
}
