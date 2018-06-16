using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Api
{
    class Config : DbContext
    {
        public Config() : base() { }
    }
}
