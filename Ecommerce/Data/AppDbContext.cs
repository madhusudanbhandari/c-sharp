using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;

namespace Ecommerce.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
        
    }
    public DbSet<User> Users{get; set;}
    public DbSet<Category> Categories {get; set;}
}