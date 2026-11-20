using First.Domain.Entities.Enum;

namespace First.Application.Dtos;

public class ViewUserDto
{
    public int Id{get;set;}
    public string Name{get;set;}=string.Empty;
    public string Email{get;set;}=string.Empty;
    public int Age{get;set;}
    public UserRole Role{get;set;}

    public string Token{get;set;}=string.Empty;
}