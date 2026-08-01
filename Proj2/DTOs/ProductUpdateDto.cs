using System.ComponentModel.DataAnnotations;

namespace Proj2.DTOs;

public class ProductUpdateDto
{
    [Required(ErrorMessage ="Product name cant be empty")]
    [StringLength(100,MinimumLength =3,ErrorMessage ="Name must be between 3 and 100")]
    public string Name{set; get;}="";
    
    [Range(1,100000,ErrorMessage ="price must be between 1 to 100000")]
    public decimal Price{set; get;}
}