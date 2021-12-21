using EnergiaProducts.Domain.Entities;
using EnergiaProducts.Domain.RepositoryDefinitions;
using Microsoft.EntityFrameworkCore;

namespace EnergiaProducts.Persistence.Repositories.Implementation
{
    public class ProductRepository : IProductRepositroy
    {
        private readonly EnergiaProductsContext context;

        public ProductRepository(EnergiaProductsContext context) => this.context = context;

        public async Task<IEnumerable<Product>> GetProductsAsync(IEnumerable<Guid> orderedProductIds)
        {
            //Can do a join too, but ain't nobody got time for that
            var products = await context.Products.Where(product => orderedProductIds.Contains(product.Id)).ToListAsync();
            return products;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync() => await context.Products.ToListAsync();

        public void Update(IEnumerable<Product> selectedProducts) => selectedProducts.Select(product => context.Update(product));
    }
}
