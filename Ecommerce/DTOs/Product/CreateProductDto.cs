using System.ComponentModel.DataAnnotations;

namespace Ecommerce.DTOs.Product;   

public class CreateProductDto
{
    [Required]
    [StringLength(100)]
    public string Name{get; set; }=string.Empty;

    [Required]
    [StringLength(500)]
    public string Description{set; get;}=string.Empty;

    [Range(0,int.MaxValue)]
    public decimal Price{get; set;}
    
    [Range(0,int.MaxValue)]
    public int Stock{get;set;}
    [Required]
    public string ImageUrl{get;set;}=string.Empty;
    public int CategoryId {get; set;}


}