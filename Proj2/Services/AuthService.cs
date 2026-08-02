using Microsoft.EntityFrameworkCore;
using Proj.DTOs;
using Proj2.Data;
using Proj2.DTOs;
using Proj2.Interfaces;
using Proj2.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Proj2.Services;



public class AuthService : IAuthService
{
    private readonly AppDbContext _context;

    private readonly IConfiguration _configuration;

    public AuthService(AppDbContext context, IConfiguration configuration)
    {
        _context=context;

        _configuration=configuration;
    }

    private string GenerateJwtToken(User user)
    {
        var claims=new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.FullName),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Role, user.Role)
        };

        var key=new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!)
        );

        var credentials=new SigningCredentials(
            key,
            SecurityAlgorithms.HmacSha256
        );

        var token=new JwtSecurityToken(
            issuer:_configuration["Jwt:Issuer"],
            audience:_configuration["Jwt:Audience"],
            claims:claims,
            expires:DateTime.UtcNow.AddMinutes(
                Convert.ToDouble(_configuration["Jwt:ExpireMinutes"])
            ),
            signingCredentials:credentials

        );

        return new JwtSecurityTokenHandler().WriteToken(token);



    }
    public async Task<AuthResponseDto> RegisterAsync(RegisterDto dto)
    {
        bool emailExists=await _context.users
        .AnyAsync(x=>x.Email==dto.Email);

        if (emailExists)
        {
            throw new Exception("email already exists.");
        }

        string hashedPassword=BCrypt.Net.BCrypt.HashPassword(dto.Password);

        User user=new User
        {
            FullName=dto.FullName,
            Email=dto.Email,
            PasswordHash=hashedPassword,
            Role="User"
        };

        _context.users.Add(user);

        await _context.SaveChangesAsync();

        return new AuthResponseDto
        {
            FullName=user.FullName,
            Email=user.Email,
            Token=""
        };

    }
    public async Task<AuthResponseDto> LoginAsync(LoginDto dto)
    {
        User? user=await _context.users
        .FirstOrDefaultAsync(x=>x.Email==dto.Email);

        if (user == null)
        {
            throw new Exception("Invalid email or password");
        }

        bool isPasswordCorrect=BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash);

        if (!isPasswordCorrect)
        {
            throw new Exception("Password did not match");
        }

        string token=GenerateJwtToken(user);

        return new AuthResponseDto
        {
            FullName=user.FullName,
            Email=user.Email,
            Token=token,
        };
    }
}