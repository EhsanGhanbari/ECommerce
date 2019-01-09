using ECommerce.Services.Accounts.Validation;
using FluentValidation.Attributes;

namespace ECommerce.Services.Accounts.ViewModel
{
    [Validator(typeof(LogOnValidation))]
    public class ChangePassowrdViewModel
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
    }
}
