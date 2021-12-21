using EnergiaProducts.Domain.Entities;

namespace EnergiaProducts.Domain.RepositoryDefinitions
{
    public interface IOrderRepository
    {
        void AddOrder(Order newOrder);

        Task SaveChangesAsync();
    }
}