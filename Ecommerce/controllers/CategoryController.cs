using Ecommerce.DTOs.Category;
using Ecommerce.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService=categoryService;
    }


    [HttpGet]
    public async Task<ActionResult<List<CategoryResponsedto>>> GetAll()
    {
        var categories=await _categoryService.GetAllAsync();

        return Ok(categories);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CategoryResponsedto>> GetById(int id)
    {
        var category=await _categoryService.GetByIdAsync(id);

        if (category == null)
        return NotFound();

        return Ok(category);
    }

    [HttpPost]
    public async Task<ActionResult<CategoryResponsedto>> Create(CreateCategoryDto dto)
    {
        var category=await _categoryService.CreateAsync(dto);

        return CreatedAtAction(
            nameof(GetById),
            new{id=category.Id},
            category);
        
    }

    [HttpPut("{id}")]

    public async Task<ActionResult<CategoryResponsedto>> Update(int id, UpdateCategoryDto dto)
    {
        var category=await _categoryService.UpdateAsync(id,dto);

        if(category==null)
        return NotFound();

        return Ok(category);
    }

    [HttpDelete("{id}")]

    public async Task<IActionResult>Delete(int id)
    {
        var deleted=await _categoryService.DeleteAsync(id);

        if(!deleted)
        return NotFound();

        return NoContent();
    }
}