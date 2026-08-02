using Microsoft.EntityFrameworkCore;

using Proj2.Models;

namespace Proj2.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
        
    }

    public DbSet<Product> products{get;set;}
    public DbSet<User> users{get; set;}
}