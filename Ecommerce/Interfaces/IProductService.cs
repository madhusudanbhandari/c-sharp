using Ecommerce.DTOs.Product;

namespace Ecommerce.Interfaces;

public interface IProductService
{
    Task<List<ProductResponseDto>> GetAllAsync(string? search,int? categoryId,string? sortBy,int page, int pageSize);
    Task<ProductResponseDto?> GetByIdAsync(int id);
    Task<ProductResponseDto?> CreateAsync(CreateProductDto dto);

    Task<ProductResponseDto?> UpdateAsync(int id, UpdateProductDto dto);

    Task<bool> DeleteAsync(int id);


}