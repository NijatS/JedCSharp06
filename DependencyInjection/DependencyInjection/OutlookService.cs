namespace DependencyInjection;

public class OutlookService : IMailService
{
    //IOC
    public void Send(string to, string subject, string body)
    {
        Console.WriteLine($"outlook service isledi bro");
    }
}