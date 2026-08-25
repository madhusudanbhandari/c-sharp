namespace DI.Interface;

public interface IEmailService
{
    public void sendEmail(string to,string subject,string body);
}