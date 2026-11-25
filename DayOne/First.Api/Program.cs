using System.Text;
using First.Application.Interface;
using First.Application.Services;
using First.Infrastructure.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using Serilog;

var builder=WebApplication.CreateBuilder(args);


builder.Host.UseSerilog((context, configuration) =>
{
    configuration
        .MinimumLevel.Information()
        .Enrich.FromLogContext()
        .WriteTo.Console()
        .WriteTo.File("Logs/log.txt",rollingInterval:RollingInterval.Day);
});

builder.Services.AddEndpointsApiExplorer();


builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer",new OpenApiSecurityScheme
    {
        Name="Authorization",
        Type=SecuritySchemeType.Http,
        Scheme="Bearer",
        BearerFormat="JWT",
        In=ParameterLocation.Header,
        Description="Enter your token here"

    });

    options.AddSecurityRequirement(document=>new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecuritySchemeReference("Bearer",document),
            new List<string>()
        }
    });
});

builder.Services.AddAuthorization();

// builder.Services.AddDbContext<AppDbContext>(Options =>
// {
//     Options.UseNpgsql(
//         builder.Configuration.GetConnectionString("DefaultConnection")
//     );
// });

var key=builder.Configuration["Jwt:Key"]!;

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme=JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme;

})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters=new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer=true,
        ValidateAudience=true,
        ValidateIssuerSigningKey=true,
        ValidateLifetime=true,

        ValidIssuer=builder.Configuration["Jwt:Issuer"],
        ValidAudience=builder.Configuration["Jwt:Audience"],

        IssuerSigningKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))

    };
});

var connectionString=builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddScoped(_=>new SqlConnection(connectionString));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<ITaskService,TaskService>();
builder.Services.AddScoped<ITokenRepository,TokenRepository>();
builder.Services.AddHostedService<TokenCleanupService>();


builder.Services.AddControllers();


var app=builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSerilogRequestLogging();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();


app.Run();