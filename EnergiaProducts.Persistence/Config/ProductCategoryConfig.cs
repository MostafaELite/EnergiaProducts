using EnergiaProducts.Domain.Entities;
using EnergiaProducts.Persistence.Constance;
using Microsoft.EntityFrameworkCore;

namespace EnergiaProducts.Persistence.Config
{
    public class ProductCategoryConfig
    {
        public static void Configure(ModelBuilder builder)
        {
            var entity = builder.Entity<ProductCategory>();
            entity.HasKey(cat => cat.CategoryId);

            entity.HasData(new[]
            {
                new ProductCategory{ CategoryId = Guid.Parse(CateogryIds.BakeryCategoryId), CategoryName = "Bakery"},
                new ProductCategory{ CategoryId = Guid.Parse(CateogryIds.OtherShitCategoryId ), CategoryName = "Other Shit"} 
            });
        }
}
}
