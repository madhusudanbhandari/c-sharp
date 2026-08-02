using Microsoft.AspNetCore.Mvc;
using Proj2.Interfaces;
using Proj2.Models;
using Proj2.DTOS;
using Proj2.DTOs;
using Microsoft.AspNetCore.Authorization;
namespace Proj2.Controllers;

[ApiController]
[Route("api/[controller]")]

[Authorize]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]

    public async Task<ActionResult<List<ProductResponseDto>>> GetAllProducts()
    {
        var products=await _productService.GetAllProductsAsync();

        var response=products.Select(Product=>
        new ProductResponseDto
        {
            Id=Product.Id,
            Name=Product.Name,
            Price=Product.Price
        }).ToList();

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductResponseDto>> GetProductById(int id)
    {
        var product=await _productService.GetProductByIdAsync(id);

        if (product == null)
        {
            return NotFound();
        }

        ProductResponseDto response=new ProductResponseDto
        {
            Id=product.Id,
            Name=product.Name,
            Price=product.Price
        };

        return Ok(response);
    }

    [HttpPost]
    
    public async Task<ActionResult<ProductResponseDto>> CreateProduct(ProductCreateDto dto)
    {
        Product product=new Product
        {
            Name=dto.Name,
            Price=dto.Price
        };
        var createdProduct=await _productService.CreateProductAsync(product);

        ProductResponseDto response= new ProductResponseDto
        {
            Id=createdProduct.Id,
            Name=createdProduct.Name,
            Price=createdProduct.Price
        };

        return CreatedAtAction(
            nameof(GetProductById),
            new{id=response.Id},
            response
        );

        
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, ProductUpdateDto dto)
    {
        Product product=new Product
        {
            Name=dto.Name,
            Price=dto.Price,
        };

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