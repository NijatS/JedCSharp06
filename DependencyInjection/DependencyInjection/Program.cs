namespace DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
       // GmailService gmailService = new GmailService();
       //
       // gmailService.Send();
       //
       // HotmailService hotmailService = new HotmailService();
       //
       // hotmailService.Send("https://hotmail.com", "hotmail"," asda");


       // IMailService mailService = new HotmailService();
       // mailService.Send("mail@gmail.com","mail@gmail.com","mail@gmail.com");

       // GmailService gmailService = new GmailService();
       // HotmailService hotmailService = new HotmailService();
       // OutlookService outlookService = new OutlookService();

       MailSender sender = new MailSender();
       // IMailService
       // sender.mailService = new OutlookService();
       
       sender.SendMessageToUser();
    }
}