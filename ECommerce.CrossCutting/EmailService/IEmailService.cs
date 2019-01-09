namespace ECommerce.CrossCutting.EmailService
{
    public interface IEmailService
    {
        void SendMail(string from, string to, string subject, string body);
    }
}
