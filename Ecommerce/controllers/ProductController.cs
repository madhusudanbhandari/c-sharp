using Ecommerce.Interfaces;
using Ecommerce.DTOs.Product;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;
using Microsoft.AspNetCore.Authorization;

namespace Ecommerce.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService=productService;
    }

    [Authorize]
    [HttpGet]
    public async Task<ActionResult<List<ProductResponseDto>>> GetAll(
        string? search,
        int? categoryId,
        string? sortBy,
        int page=1,
        int pageSize=10

        )
    {
        var products=await _productService.GetAllAsync(search,categoryId,sortBy,page,pageSize);

        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductResponseDto>> GetById(int id)
    {
        var product=await _productService.GetByIdAsync(id);

        if(product==null)
        return NotFound();

        return Ok(product);
    }

    [Authorize(Roles ="Admin")]
    [HttpPost]
    public async Task<ActionResult<ProductResponseDto>> Create(CreateProductDto dto)
    {
        var product=await _productService.CreateAsync(dto);

        if(product==null)
        return BadRequest("Category Not Found");
        
        return CreatedAtAction(
            nameof(GetById),
            new{id=product.Id},
            product
        );
    }

    [Authorize(Roles ="Admin")]
    [HttpPut("{id}")]
    public async Task<ActionResult<ProductResponseDto>>Update(int id, UpdateProductDto dto)
    {
        var product=await _productService.UpdateAsync(id,dto);

        if(product==null)
        return NotFound();

        return Ok(product);
    }

    [Authorize(Roles ="Admin")]
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var deleted=await _productService.DeleteAsync(id);

        if(!deleted)
        return NotFound();

        return NoContent();

    }
}