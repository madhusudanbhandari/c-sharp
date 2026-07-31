using Proj2.Interfaces;
using Proj2.Models;

namespace Proj2.Services;

public class ProductService : IProductService
{
    public List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product
            {
                id=1,
                Name="Laptop",
                Price=20000
            },
            new Product
            {
                id=2,
                Name="Mobile",
                Price=35000
            },
            new Product
            {
                id=3,
                Name="Charger",
                Price=5000
            }
        };
    }
}