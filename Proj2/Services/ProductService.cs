using Microsoft.EntityFrameworkCore; 
using Proj2.Data;
using Proj2.Interfaces;
using Proj2.Models;

namespace Proj2.Services;

public class ProductService: IProductService
{
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context=context;
    }

    public async Task<List<Product>> GetAllProductsAsync()
    {
        return await _context.products.ToListAsync();
    }

     public async Task<Product?> GetProductByIdAsync(int id)
    {
        return await _context.products.FindAsync(id);
    }

    public async Task<Product> CreateProductAsync(Product product)
    {
        await _context.products.AddAsync(product);
        await _context.SaveChangesAsync();

        return product;
    }

    public async Task<bool> UpdateProductAsync(int id, Product product)
    {
        var existingProduct=await _context.products.FindAsync(id);

        if (existingProduct == null)
        {
            return false;
        }

        existingProduct.Name=product.Name;

        existingProduct.Price=product.Price;

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteProductAsync(int id)
    {
        var product=await _context.products.FindAsync(id);

        if (product == null)
        {
            return false;
        }

        _context.products.Remove(product);
        await _context.SaveChangesAsync();

        return true;
    }
}