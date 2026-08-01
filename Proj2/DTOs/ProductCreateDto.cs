using System.ComponentModel.DataAnnotations;

namespace Proj2.DTOS;

public class ProductCreateDto
{
    [Required(ErrorMessage ="Product cannot be empty")]
    [StringLength(100,MinimumLength =3,
    ErrorMessage="Product name must be between 3 and 100 characters.")]
    public string Name{get; set;}="";


    [Range(1,100000,
    ErrorMessage ="Price must be between 1 and 100000")]
    

    public decimal Price{get; set;}

}