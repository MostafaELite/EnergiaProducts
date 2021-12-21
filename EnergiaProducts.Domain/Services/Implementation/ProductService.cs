using EnergiaProducts.Domain.Entities;
using EnergiaProducts.Domain.RepositoryDefinitions;
using EnergiaProducts.Domain.Services.Abstract;

namespace EnergiaProducts.Services.Implementation;

public class ProductService : IProductService
{
    private readonly IProductRepositroy productRepositroy;

    public ProductService(IProductRepositroy productRepositroy) => this.productRepositroy = productRepositroy;

    public async Task<IEnumerable<Product>> GetProductsAsync() => await productRepositroy.GetProductsAsync();

    public async Task<IEnumerable<Product>> GetProductsAsync(IEnumerable<Guid> orderedProductIds) => await productRepositroy.GetProductsAsync(orderedProductIds);

    public void UpdateProducts(IEnumerable<Product> selectedProducts) => productRepositroy.Update(selectedProducts);
}
