namespace DependencyInjection;

public class MailSender
{
    //Dependency injection with constructor
   // public IMailService mailService { get; set; }
   //
   // public MailSender(IMailService mailService)
   // {
   //     this.mailService = mailService;
   // }
   public IMailService mailService { get; set; }

   
   //Dependency injection with method
    public void SendMessageToUser(/*IMailService mailService*/)
    {
        for (int i = 0; i < 10; i++)
        {
            mailService.Send("mail@gmail.com", $"Hi {i}", $"Hi {i}");
        }
    }
}