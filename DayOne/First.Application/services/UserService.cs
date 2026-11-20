using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using First.Application.Dtos;
using First.Application.Interface;
using First.Domain.Entities;
using First.Domain.Entities.Enum;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Logging;

namespace First.Application.Services;

public class UserService:IUserService
{
    private readonly IUserRepository _user;
    private readonly IConfiguration _configuration;
    private readonly ILogger<UserService> _logger;
    public UserService(IUserRepository userRepository,IConfiguration configuration,ILogger<UserService> logger)
    {
        _user=userRepository;
        _configuration=configuration;
        _logger=logger;
    }

    public async Task<ViewUserDto> RegisterUser(AddUserDto dto)
    {
        var user=new User
        {
            Name=dto.Name,
            Age=dto.Age,
            Email=dto.Email,
            Password=dto.Password
        };

        await _user.AddUser(user);

        return new ViewUserDto
        {
            Id=user.Id,
            Name=user.Name,
            Email=user.Email,
            Age=user.Age,

        };
    }
    public async Task<ViewUserDto> LoginUser(LoginUserDto dto)
    {
        _logger.LogInformation("LoginUser method called with email: {Email}", dto.Email);

        var user=await _user.GetUserByEmail(dto.Email);

        if (user == null)
        {
            _logger.LogWarning("User not found with email: {Email}", dto.Email);
            throw new Exception("User not found");
        }

        if (dto.Password != user.Password)
        {
            _logger.LogWarning("Incorrect password for user: {Email}", dto.Email);
            throw new Exception("Password is incorrect");
        }

        var role=await _user.GetUserRole(user.Id);



        return new ViewUserDto
        {
            Id=user.Id,
            Name=user.Name,
            Email=user.Email,
            Age=user.Age,
            Role=role,
            Token=GenerateToken(user,role),

        };
    }

    public async Task<ViewUserDto> UpdateUser(int id, UpdateUserDto dto)
    {
        var user=await _user.GetUserById(id);

        if (user == null)
        {
            throw new Exception("Cannot find the requested user");
        }

        var updatedUser=await _user.UpdateUser(id,dto);

        if(updatedUser==null)
            throw new Exception("Cannot update the user");

        return new ViewUserDto
        {
            Id=updatedUser.Id,
            Name=updatedUser.Name,
            Email=updatedUser.Email,
            Age=updatedUser.Age
        };

    }

    public async Task<ViewUserDto> UpdateRole(int id,UpdateRole dto)
    {
        
        var user=await _user.GetUserById(id);

        if (user == null)
        {
            throw new Exception("Cannot find the requested user");
        }

        var updatedUser=await _user.UpdateRole(id,dto);

        if(updatedUser==null)
            throw new Exception("Cannot update the user");

        return new ViewUserDto
        {
            Id=updatedUser.Id,
            Name=updatedUser.Name,
            Email=updatedUser.Email,
            Age=updatedUser.Age,
            Role=updatedUser.Role
        };
    }

    public async Task<string?> DeleteUser(int id)
    {
        var user=await _user.GetUserById(id);

        if (user == null)
        {
            throw new Exception("Cannot find the user");
        }

        await _user.DeleteUserById(user.Id);

        return "Deleted successfully";

    }

    public async Task<ViewUserDto?> AddRole(int UserId,UserRole RoleId)
    {
        var user=await _user.GetUserById(UserId);

        if (user == null)
        {
            throw new Exception("Cannot find the user");
        }

        await _user.AddRole(UserId,RoleId);

        return new ViewUserDto
        {
            Id=user.Id,
            Name=user.Name,
            Email=user.Email,
            Age=user.Age,
            Role=RoleId
        };

    }
    private string GenerateToken(User user,UserRole Role)
    {
        var claims=new Claim[]
        {
            new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Role,Role.ToString())
        };

        var key=_configuration["Jwt:Key"]!;

        var securityKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

        var credentials=new SigningCredentials(securityKey,algorithm:SecurityAlgorithms.HmacSha256);

        var token=new JwtSecurityToken(
            issuer:_configuration["Jwt:Issuer"],
            audience:_configuration["Jwt:Audience"],
            claims:claims,
            expires:DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["Jwt:ExpirationMinutes"])),
            signingCredentials:credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);


    }

}