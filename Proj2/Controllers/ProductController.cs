using Microsoft.AspNetCore.Mvc;
using Proj2.Interfaces;
using Proj2.Models;

namespace Proj2.Controllers;

[ApiController]
[Route("api/[controller]")]


public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]

    public async Task<ActionResult<List<Product>>> GetAllProducts()
    {
        var products=await _productService.GetAllProductsAsync();

        return products;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProductById(int id)
    {
        var product=await _productService.GetProductByIdAsync(id);

        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct(Product product)
    {
        var createdProduct=await _productService.CreateProductAsync(product);

        return CreatedAtAction(
            nameof(GetProductById),
            new{id=createdProduct.id},
            createdProduct
        );
    }

    [HttpPut("{id}")]

    public async Task<IActionResult> UpdateProduct(int id, Product product)
    {
        var updated=await _productService.UpdateProductAsync(id,product);

        if (!updated)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var deleted=await _productService.DeleteProductAsync(id);

        if (!deleted)
        {
            return NotFound();
        }
        return NoContent();
    }


}