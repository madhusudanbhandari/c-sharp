using System.Security.Cryptography.X509Certificates;
using Ecommerce.Data;
using Ecommerce.DTOs.Product;
using Ecommerce.Interfaces;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Services;

public class ProductService : IProductService
{
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ProductResponseDto?> CreateAsync(CreateProductDto dto)
    {
        var category = await _context.Categories
        .FindAsync(dto.CategoryId);

        if (category == null)
            return null;


        var product = new Product
        {
            Name = dto.Name,
            Description = dto.Description,
            Price = dto.Price,
            Stock = dto.Stock,
            ImageUrl = dto.ImageUrl,
            CategoryId = dto.CategoryId
        };

        _context.Products.Add(product);

        await _context.SaveChangesAsync();

        return new ProductResponseDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            Stock = product.Stock,
            ImageUrl = product.ImageUrl,
            Category = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name

            }
        };
    }

    public async Task<List<ProductResponseDto>> GetAllAsync()
    {
        return await _context.Products
        .Include(p => p.Category)
        .Select(p => new ProductResponseDto
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Price = p.Price,
            Stock = p.Stock,
            ImageUrl = p.ImageUrl,

            Category = new CategoryDto
            {
                Id = p.Category.Id,
                Name = p.Category.Name
            }
        })
        .ToListAsync();
    }

    public async Task<ProductResponseDto?> GetByIdAsync(int id)
    {
        return await _context.Products
        .Include(p => p.Category)
        .Where(p => p.Id == id)
        .Select(p => new ProductResponseDto
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Price = p.Price,
            Stock = p.Stock,
            ImageUrl = p.ImageUrl,

            Category = new CategoryDto
            {
                Id = p.Category.Id,
                Name = p.Category.Name
            }
        })
        .FirstOrDefaultAsync();
    }
    public async Task<ProductResponseDto?> UpdateAsync(int id, UpdateProductDto dto)
    {
        var product = await _context.Products
        .FindAsync(id);

        if (product == null)
            return null;

        var category = await _context.Categories
        .FindAsync(dto.CategoryId);

        if (category == null)
            return null;

        product.Name = dto.Name;
        product.Description = dto.Description;
        product.Price = dto.Price;
        product.Stock = dto.Stock;
        product.ImageUrl = dto.ImageUrl;
        product.CategoryId = dto.CategoryId;

        await _context.SaveChangesAsync();

        return new ProductResponseDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            Stock = product.Stock,
            ImageUrl = product.ImageUrl,
            Category = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name
            }
        };
    }

public async Task<bool> DeleteAsync(int id)
    {
        var product=await _context.Products.FindAsync(id);

        if(product==null)
           return false;

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();

        return true;

    }
}