using DI.Interface;

namespace DI.Service;

public class EmailService: IEmailService
{
    public void sendEmail(string to,string subject, string body)
    {
        Console.WriteLine($"Sent email to {to} with subject {subject} and body {body}");


    }
}


//Different types of the injections

//1.Constructor injection
// public class UserRegistration
// {
//     private readonly IEmailService _emailService;

//     public UserRegistration(IEmailService emailService)
//     {
//         _emailService=emailService;
//     }
//     public void RegisterUser(string email)
//     {
//         _emailService.sendEmail(email,"Registration successfull","User Registered");
//     }
// }


//2.Property or setter injection
// public class UserRegistration
// {
//     public IEmailService? EmailService{get;set;}

//     public void RegisterUser(string email)
//     {
//         if(EmailService is null)
//         throw new InvalidOperationException("Email service not set");

//         EmailService.sendEmail(email,"Registration Successfull","User Registered successfully");
//     }

// }


//3.Method injection

public class UserRegistration
{
    public void RegisterUser(string email, IEmailService emailService)
    {
        emailService.sendEmail(email,"Registration successfull","USer registerd");
    }
}
