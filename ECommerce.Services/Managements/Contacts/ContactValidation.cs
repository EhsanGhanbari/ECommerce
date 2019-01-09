using FluentValidation;

namespace ECommerce.Services.Contacts
{
    public class ContactValidation :AbstractValidator<ContactViewModel>
    {
        public ContactValidation()
        {
            RuleFor(c => c.Title).NotNull().WithMessage("Title is Empty").WithName("Title");
            RuleFor(c => c.Body).NotNull().WithMessage("Body is Empty").WithName("Body");
            RuleFor(c => c.Email).NotNull().WithMessage("Enter your Email Address").WithName("Email");
        }
    }
}
