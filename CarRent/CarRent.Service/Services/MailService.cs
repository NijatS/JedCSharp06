using System.Net;
using System.Net.Mail;
using CarRent.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace CarRent.Services;

public class MailService(IConfiguration configuration) : IMailService
{
    public void SendMail(string to, string subject, string body)
    { 
       string from = configuration.GetSection("MailSettings:From").Value;
       MailMessage mail = new MailMessage();
       mail.To.Add(to);
       mail.Subject = subject;
       mail.Body = body;
       mail.From = new MailAddress(from);
       
       SmtpClient smtpClient = new SmtpClient();
       smtpClient.Host = configuration.GetSection("MailSettings:Host").Value;
       smtpClient.Port = int.Parse(configuration.GetSection("MailSettings:Port").Value);
       smtpClient.UseDefaultCredentials = false;
       smtpClient.Credentials = new NetworkCredential(from, configuration.GetSection("MailSettings:Password").Value);
       smtpClient.EnableSsl = true;
       
       smtpClient.Send(mail);
       
    }
}