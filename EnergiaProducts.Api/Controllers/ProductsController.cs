using EnergiaProducts.Domain.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EnergiaProducts.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductsController(IProductService productService) => this.productService = productService;

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var allProducts = await productService.GetProductsAsync();
            return Ok(allProducts);
        }
    }
}
