using EnergiaProducts.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnergiaProducts.Persistence.Config
{
    public class OrderItemConfig
    {
        public static void Configure(ModelBuilder builder)
        {
            var entity = builder.Entity<OrderItem>();
            entity.HasKey(item => new { item.ProductId, item.OrderId });
        }
    }
}
