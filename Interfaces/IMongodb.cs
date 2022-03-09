using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IMongodb
    {
        public string Server { get; set; }
        public string Database { get; set; }
    }
}
