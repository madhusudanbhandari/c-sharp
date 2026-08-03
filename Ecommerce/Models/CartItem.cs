namespace Ecommerce.Models;

public class CartItem
{
    public int Id {get; set;}

    //Foreign key to User
    public int UserId{get;set;}
    public User? User{get;set;}

    //Foreign Key to Product

    public int ProductId{get;set;}
    public Product? Product{get; set;}

    public int Quantity {get;set;}
}