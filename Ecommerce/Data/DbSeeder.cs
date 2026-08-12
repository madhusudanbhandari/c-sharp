using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;


namespace Ecommerce.Data;

public static class DbSeeder
{
    public static async Task SeedAdminAsync(AppDbContext context)
    {
        var adminExists=await context.Users
        .AnyAsync(u=>u.Role=="Async");

        if(adminExists)
        return;

        var admin=new User
        {
            Name="Admin",
            Email="admin@ecommerce.com",
            PasswordHash=BCrypt.Net.BCrypt.HashPassword("Admin@123"),
            Role="Admin",
            createdAt=DateTime.UtcNow
        };

        context.Users.Add(admin);

        await context.SaveChangesAsync();
    }
}