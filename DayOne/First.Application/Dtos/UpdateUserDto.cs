using First.Domain.Entities.Enum;

namespace First.Application.Dtos;

public class UpdateUserDto
{
    public string Name{get;set;}=string.Empty;
    public string Email{get;set;}=string.Empty;
    public string Password{get;set;}=string.Empty;
    public int Age{get;set;}
  
}