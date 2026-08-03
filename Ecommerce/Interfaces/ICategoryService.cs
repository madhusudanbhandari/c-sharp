using Ecommerce.DTOs.Category;

namespace Ecommerce.Interfaces;

public interface ICategoryService
{
    Task <List<CategoryResponsedto>> GetAllAsync();

    Task <CategoryResponsedto?> GetByIdAsync(int id);

    Task<CategoryResponsedto> CreateAsync(CreateCategoryDto dto);

    Task<CategoryResponsedto?> UpdateAsync(int id,UpdateCategoryDto dto );

    Task<bool> DeleteAsync(int id);
}