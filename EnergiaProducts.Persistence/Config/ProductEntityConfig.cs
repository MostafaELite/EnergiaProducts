using EnergiaProducts.Domain.Entities;
using EnergiaProducts.Persistence.Constance;
using Microsoft.EntityFrameworkCore;

namespace EnergiaProducts.Persistence.Config
{
    public class ProductEntityConfig
    {
        public static void Configure(ModelBuilder builder)
        {
            var entity = builder.Entity<Product>();
            entity.HasKey(product => product.Id);
            entity.HasOne(product => product.Category)
                .WithMany()
                .HasForeignKey(product => product.CategoryId);

            var bakeryCategoryId = Guid.Parse(CateogryIds.BakeryCategoryId);
            var OtherShitCategoryId = Guid.Parse(CateogryIds.OtherShitCategoryId);

            var seedData = new List<Product>
            {
                new Product("Muffin", UnitType.Tükki, 1.00m, bakeryCategoryId, 36),
                new Product("Cake Pop", UnitType.Tükki, 1.35m, bakeryCategoryId, 24),
                new Product("Apple Tart", UnitType.Tükki, 1.50m, bakeryCategoryId, 30),
                new Product("Water", UnitType.Tükki, 1.50m, bakeryCategoryId, 60),

                new Product("Shirt",UnitType.Tükki, 1.50m,OtherShitCategoryId, null),
                new Product("Pants",UnitType.Tükki, 1.50m, OtherShitCategoryId,null),
                new Product("Jacket",UnitType.Tükki, 1.50m, OtherShitCategoryId, null),
                new Product("Toy",UnitType.Tükki, 1, OtherShitCategoryId, null)
            };
            entity.HasData(seedData);
        }
    }
}
