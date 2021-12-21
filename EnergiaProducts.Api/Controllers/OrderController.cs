using AutoMapper;
using EnergiaProducts.Domain.Models;
using EnergiaProducts.Domain.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EnergiaProducts.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        private readonly IMapper mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            this.orderService = orderService;
            this.mapper = mapper;
        }


        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="orderPayload"></param>
        /// <returns>The newely created Order</returns>
        [HttpPost]
        public async Task<IActionResult> PlaceOrderAsync(ApiOrder orderPayload)
        {
            var placeOrderRequest = mapper.Map<PlaceOrderRequest>(orderPayload);
            var result = await orderService.PlaceOrder(placeOrderRequest);
            return Ok(result);
        }
    }
}
