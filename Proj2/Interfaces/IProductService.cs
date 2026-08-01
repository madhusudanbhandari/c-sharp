using Proj2.Models;

namespace Proj2.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetAllProductsAsync();

    Task<Product?> GetProductByIdAsync(int id);

    Task<Product> CreateProductAsync(Product product);

    Task<bool> UpdateProductAsync(int id, Product product);

    Task<bool> DeleteProductAsync(int id);
}