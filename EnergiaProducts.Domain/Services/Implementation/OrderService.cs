using EnergiaProducts.Domain.Entities;
using EnergiaProducts.Domain.Models;
using EnergiaProducts.Domain.RepositoryDefinitions;
using EnergiaProducts.Domain.Services.Abstract;

namespace EnergiaProducts.Services.Implementation;

public class OrderService : IOrderService
{
    private readonly IProductService productService;
    private readonly IOrderRepository orderRepository;


    public OrderService(IProductService productRepositroy, IOrderRepository orderRepository)
    {
        productService = productRepositroy;
        this.orderRepository = orderRepository;
    }

    public async Task<Order> PlaceOrder(PlaceOrderRequest placeOrderRequest)
    {                   
        var selectedProducts = await productService.GetProductsAsync(placeOrderRequest.OrderedProducts.Select(product => product.ProductId));
        var newOrder = Order.Place(placeOrderRequest, selectedProducts);
        orderRepository.AddOrder(newOrder);
        productService.UpdateProducts(selectedProducts);
        await orderRepository.SaveChangesAsync();
        return newOrder;
    }
}
