using EnergiaProducts.Domain.Entities;
using EnergiaProducts.Domain.Models;

namespace EnergiaProducts.Domain.Services.Abstract
{
    public interface IOrderService
    {       
        Task<Order> PlaceOrder(PlaceOrderRequest placeOrderRequest);
    }
}
