using DI.Interface;
using DI.Service;

var builder=WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<UserRegistration>();

//property injection
// builder.Services.AddScoped<UserRegistration>(ServiceProvider=>
// {
//     var registration=new UserRegistration();
//     registration.EmailService=ServiceProvider.GetRequiredService<IEmailService>();
//         return registration;
    
// });

builder.Services.AddSingleton<VisitorCounter>();

// builder.Services.AddScoped<RequestTracker>();

builder.Services.AddTransient<RequestTracker>();
builder.Services.AddScoped<ServiceA>();
builder.Services.AddScoped<ServiceB>();
builder.Services.AddScoped<ServiceC>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app=builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.MapControllers();
app.Run();