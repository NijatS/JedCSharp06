namespace DependencyInjection;

public class HotmailService : IMailService
{
    public void Send(string to, string subject, string content)
    {
        Console.WriteLine("Hotmail service work");
    }
    
}