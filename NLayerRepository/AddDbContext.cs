using Microsoft.EntityFrameworkCore;
using NLayerCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerRepository
{
    public class AddDbContext :DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
    }
}
