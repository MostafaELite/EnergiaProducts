using EnergiaProducts.Domain.Entities;

namespace EnergiaProducts.Domain.RepositoryDefinitions;

public interface IProductRepositroy
{
    Task<IEnumerable<Product>> GetProductsAsync(IEnumerable<Guid> orderedProductIds);
    Task<IEnumerable<Product>> GetProductsAsync();
    void Update(IEnumerable<Product> selectedProducts);
}
