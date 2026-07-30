using Microsoft.AspNetCore.Mvc;

namespace Proj2.Controllers;
using Proj2.Interfaces;

[ApiController]
[Route("api/[controller]")]

public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService=productService;
    }


    [HttpGet]
    public IActionResult GetProducts()
    {
        var products=_productService.GetProducts();

        return Ok(products);
    }
}