using BCrypt.Net;
using Ecommerce.Data;
using Ecommerce.DTOs.Auth;
using Ecommerce.Interfaces;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;


namespace Ecommerce.Services;

public  class AuthService : IAuthService
{
    private readonly AppDbContext _context;

    public AuthService(AppDbContext context)
    {
        _context=context;
    }

    public async Task<AuthResponseDto?> RegisterAsync(RegisterDto dto)
    {
        var existingUser=await _context.Users
        .FirstOrDefaultAsync(u=>u.Email==dto.Email);

        if(existingUser!=null)
        return null;

        var hashedPassword=BCrypt.Net.BCrypt.HashPassword(dto.Password);

        var user=new User
        {
            Name=dto.Name,
            Email=dto.Email,
            PasswordHash=hashedPassword,
            Role="Customer",
        };
        
        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return new AuthResponseDto
        {
            Token="",
            Name=user.Name,
            Email=user.Email,
        };

    }
    public async Task<AuthResponseDto?> LoginAsync(LoginDto dto)
    {
        var user=await _context.Users
        .FirstOrDefaultAsync(u=>u.Email==dto.Email);

        if(user==null)
        return null;

        var isPasswordValid=BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash);

        if(!isPasswordValid)
        return null;

        return new AuthResponseDto
        {
            Token="",
            Name=user.Name,
            Email=user.Email
        };
    }
}