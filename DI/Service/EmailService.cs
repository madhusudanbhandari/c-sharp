using DI.Interface;

namespace DI.Service;

public class EmailService: IEmailService
{
    public void sendEmail(string to,string subject, string body)
    {
        Console.WriteLine($"Sent email to {to} with subject {subject} and body {body}");


    }
}

public class UserRegistration(IEmailService emailService)
{
    public void RegisterUser(string email)
    {
        emailService.sendEmail(email,"Registration successfull","User Registered");
    }
}