using System.Text.RegularExpressions;

namespace ECommerce.Infrastructure.Validation
{
    public class EmailValidationSpecification
    {
        private static readonly Regex EmailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

        public bool IsSatisfyBy(string email)
        {
            return EmailRegex.IsMatch(email);
        }
    }
}
