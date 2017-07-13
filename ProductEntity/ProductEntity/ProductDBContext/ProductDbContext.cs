using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEntity.ProductDBContext
{
   public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }    
    }
}
