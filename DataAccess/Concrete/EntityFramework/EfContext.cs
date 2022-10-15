using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfContext:DbContext
    {
       
           protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=127.0.0.1192.168.30.20;uid=root;pwd=12345;database=test";
            base.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
    }
}
