using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    using System.Data.Entity;
    using Models;
    public class ProductDBContext:DbContext
    {
        public ProductDBContext() : base("name=ProductDBContext")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ClothSize> ClothSizes { get; set; }
        public DbSet<ColthType> ColthTypes { get; set; }
        public DbSet<ColthColor> ColthColors { get; set; }
        public DbSet<PriceRamdom> PriceRamdoms { get; set; }
    }
}