using Proj2.Interfaces;
using Proj2.Models;

namespace Proj2.Services;

public class ProductService : IProductService
{
    public List<Products> GetProducts()
    {
        return new List<Products>
        {
            new Products
            {
                id=1,
                Name="Laptop",
                Price=20000
            },
            new Products
            {
                id=2,
                Name="Mobile",
                Price=35000
            },
            new Products
            {
                id=3,
                Name="Charger",
                Price=5000
            }
        };
    }
}