using MinApi1.Users;

var builder=WebApplication.CreateBuilder(args);

var app=builder.Build();
app.MapGet("/",()=>"Hello world");

var users=new List<User>();

app.MapPost("/api/users",(User user) =>
{
    users.Add(user);

    return Results.Created($"/api/users/{user.Id}",user);

});

app.Run();