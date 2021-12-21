using EnergiaProducts.Domain.Entities;
using EnergiaProducts.Persistence.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EnergiaProducts.Persistence
{
    public class EnergiaProductsContext : DbContext
    {
        private readonly IConfiguration configuration;
        public EnergiaProductsContext(IConfiguration config)
        {
            configuration = config;
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ProductEntityConfig.Configure(modelBuilder);
            OrderItemConfig.Configure(modelBuilder);
            ProductCategoryConfig.Configure(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = configuration.GetConnectionString("EnergiaProducts_Mostafa");
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}


