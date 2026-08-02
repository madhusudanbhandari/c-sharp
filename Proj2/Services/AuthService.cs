using Microsoft.EntityFrameworkCore;
using Proj.DTOs;
using Proj2.Data;
using Proj2.DTOs;
using Proj2.Interfaces;
using Proj2.Models;

namespace Proj2.Services;


public class AuthService : IAuthService
{
    private readonly AppDbContext _context;

    public AuthService(AppDbContext context)
    {
        _context=context;
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
        throw new NotImplementedException();
    }
}