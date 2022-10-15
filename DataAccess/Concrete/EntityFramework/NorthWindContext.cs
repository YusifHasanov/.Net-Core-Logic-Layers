using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthWindContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WINDOWS-TC4OKAI\SQLEXPRESS;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=True");
        }
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
        
    }
}
