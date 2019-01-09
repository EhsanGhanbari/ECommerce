using System.Net.Mail;
using ECommerce.CrossCutting.EmailService;

namespace ECommerce.CrossCutting.EmailService
{
    public class SmtpService : IEmailService
    {   
        public void SendMail(string from, string to, string subject, string body)
        {
            var message = new MailMessage {Subject = subject, Body = body};
            var smtp = new SmtpClient();
            smtp.Send(message);
        }
    }
}
