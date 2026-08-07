using Microsoft.EntityFrameworkCore;
using Ecommerce.Data;
using Ecommerce.Services;
using Ecommerce.Interfaces;
var builder=WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddDbContext<AppDbContext> (
    options=>options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICategoryService,CategoryService>();

builder.Services.AddScoped<IProductService,ProductService>();

var app=builder.Build();

app.UseHttpsRedirection();
app.UseAuthentication();
app.MapControllers();
app.Run();