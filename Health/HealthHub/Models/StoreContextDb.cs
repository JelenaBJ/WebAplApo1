using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HealthHub.Models
{
    public class StoreContextDb : DbContext
    {
        public StoreContextDb(DbContextOptions<StoreContextDb> options) : base(options) {}
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Order> Orders => Set<Order>();
     }
}
