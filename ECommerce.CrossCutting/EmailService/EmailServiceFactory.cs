using ECommerce.CrossCutting.EmailService;

namespace ECommerce.CrossCutting.EmailService
{
    public class EmailServiceFactory
    {
        private static IEmailService _emailService;

        private static void InitializeEmailServiceFactory(IEmailService emailService)
        {
            _emailService = emailService;
        }
        public static IEmailService GetEmailService()
        {
            return _emailService;
        }
    }
}
