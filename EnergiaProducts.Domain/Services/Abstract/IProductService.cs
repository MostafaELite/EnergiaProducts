using EnergiaProducts.Domain.Entities;
using EnergiaProducts.Domain.Models;

namespace EnergiaProducts.Domain.Services.Abstract
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();

        Task<IEnumerable<Product>> GetProductsAsync(IEnumerable<Guid> orderedProductIds);

        void UpdateProducts(IEnumerable<Product> selectedProducts);
    }
}
