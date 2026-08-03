namespace Ecommerce.Models;

public class Product
{
    public int Id{get; set;}
    public string Name{get; set;}=string.Empty;
    public string Descriptipn{get; set;}=string.Empty;
    public decimal Price{get;set;}
    public int Stock{get;set;}
    public string ImageUrl {get;set;}=string.Empty;

    //Foreign Keyy
    public int CategoryId{get;set;}

    //Navigation Property
    public Category? Category{get;set;}

    public List<CartItem> CartItems{get;set;}=new();
    public List<OrderItem> OrderItems{get;set;}=new();

}