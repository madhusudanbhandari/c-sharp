using Ecommerce.DTOs.Category;
using Ecommerce.Data;
using Ecommerce.Interfaces;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;


namespace Ecommerce.Services;

public class CategoryService : ICategoryService
{
    private readonly AppDbContext _context;

    public CategoryService(AppDbContext context)
    {
        _context=context;
    }

    public async Task<List<CategoryResponsedto>> GetAllAsync()
    {
        return await _context.Categories
        .Select(c=>new CategoryResponsedto
        {
            Id=c.Id,
            Name=c.Name,
            Description=c.Description
        })
        .ToListAsync();
    }

    public async Task<CategoryResponsedto?> GetByIdAsync(int id)
    {
        var category=await _context.Categories
        .Where(c=>c.Id==id)
        .Select(c=> new CategoryResponsedto{
            Id=c.Id,
            Name=c.Name,
            Description=c.Description
            
        })
        .FirstOrDefaultAsync();

        return category;
    }

    public async Task<CategoryResponsedto> CreateAsync(CreateCategoryDto dto)
    {
        var category=new Category
        {
            Name=dto.Name,
            Description=dto.Description
        };

        _context.Categories.Add(category);

        await _context.SaveChangesAsync();

        return new CategoryResponsedto
        {
            Id=category.Id,
            Name=category.Name,
            Description=category.Description
        };
    }

    public async Task<CategoryResponsedto?> UpdateAsync(int id, UpdateCategoryDto dto)
    {
        var category=await _context.Categories.FindAsync(id);

        if (category == null)
        {
            return null;
        }

        category.Name=dto.Name;
        category.Description=dto.Description;

        await _context.SaveChangesAsync();

        return new CategoryResponsedto
        {
            Id=category.Id,
            Name=category.Name,
            Description=category.Description
        };
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var category=await _context.Categories.FindAsync(id);

        if(category==null)
            return false;

        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();

        return true;
    }
}