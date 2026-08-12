using Microsoft.EntityFrameworkCore;
using Ecommerce.Data;
using Ecommerce.Services;
using Ecommerce.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Ecommerce.Data;

var builder=WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddDbContext<AppDbContext> (
    options=>options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICategoryService,CategoryService>();

builder.Services.AddScoped<IProductService,ProductService>();

builder.Services.AddScoped<IAuthService,AuthService>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options =>
{
    var jwt=builder.Configuration.GetSection("Jwt");

    options.TokenValidationParameters=new TokenValidationParameters
    {
        ValidateIssuer=true,
        ValidateAudience=true,
        ValidateLifetime=true,
        ValidateIssuerSigningKey=true,

        ValidIssuer=jwt["Issuer"],
        ValidAudience=jwt["Audience"],

        IssuerSigningKey=new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(jwt["Key"]!)
        )
    };
    
});

builder.Services.AddAuthorization();

var app=builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context=scope.ServiceProvider
    .GetRequiredService<AppDbContext>();

    await DbSeeder.SeedAdminAsync(context);
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();