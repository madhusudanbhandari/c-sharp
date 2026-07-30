using Proj2.Interfaces;
using Proj2.Models;
using Proj2.Services;

var builder=WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddScoped<IProductService, ProductService>();

var app=builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.MapControllers();

app.Run();