using System.Net;
using System.Net.Mail;
using CarRent.Services.Interfaces;

namespace CarRent.Services;

public class MailService : IMailService
{
    public void SendMail(string to, string subject, string body)
    { 
       string from = "nicatsoltanli03@gmail.com";
       MailMessage mail = new MailMessage();
       mail.To.Add(to);
       mail.Subject = subject;
       mail.Body = body;
       mail.From = new MailAddress(from);
       
       SmtpClient smtpClient = new SmtpClient();
       smtpClient.Host = "smtp.gmail.com";
       smtpClient.Port = 587;
       smtpClient.UseDefaultCredentials = false;
       smtpClient.Credentials = new NetworkCredential(from, "oyfw xvtt tvnv ocpt");
       smtpClient.EnableSsl = true;
       
       smtpClient.Send(mail);
       
    }
}