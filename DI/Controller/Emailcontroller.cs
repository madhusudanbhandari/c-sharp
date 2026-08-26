using DI.Interface;
using DI.Service;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class EmailController : ControllerBase
{
    private readonly UserRegistration _user;

    public  EmailController(UserRegistration user)
    {
        _user=user;
    }


    [HttpGet]
    public IActionResult RegisterUser(string email, [FromServices] IEmailService emailService)
    {
        _user.RegisterUser(email,emailService);
        return Ok($"User {email} registerd");
    }
}