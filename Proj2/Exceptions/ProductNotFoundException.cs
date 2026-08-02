namespace Proj2.Exceptions;

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(int id):base($"Product with {id} was not found")
    {
        
    }
}