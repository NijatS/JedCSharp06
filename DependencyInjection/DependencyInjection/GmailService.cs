namespace DependencyInjection;

public class GmailService : IMailService
{
    public void Send(string to, string subject, string body)
    {
        Console.WriteLine("Gmail Service Work");
    }
}