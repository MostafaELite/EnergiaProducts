using EnergiaProducts.Domain.Entities;
using EnergiaProducts.Domain.RepositoryDefinitions;

namespace EnergiaProducts.Persistence.Repositories.Implementation;

public class OrderRepository : IOrderRepository
{
    private readonly EnergiaProductsContext context;

    public OrderRepository(EnergiaProductsContext context) => this.context = context;

    public void AddOrder(Order newOrder) => context.Add(newOrder);

    public async Task SaveChangesAsync() => await context.SaveChangesAsync();
}
