using System.ComponentModel.DataAnnotations;

 namespace Proj2.Models;

 public class User
{
    public int Id{get; set;}

    [Required]
    public string FullName{get; set;}=string.Empty;

    [Required]
    [MaxLength(100)]
    public string Email{get; set;}=string.Empty;

    [Required]
    public string PasswordHash{get; set;}=string.Empty;

    [Required]
    public string Role {get; set;}="User";
}