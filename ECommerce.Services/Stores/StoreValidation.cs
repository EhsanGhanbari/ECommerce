using FluentValidation;

namespace ECommerce.Services.Stores
{
    public class StoreValidation : AbstractValidator<StoreViewModel>
    {
        public StoreValidation()
        {
            RuleFor(s => s.Name)
                .NotEmpty()
                .WithMessage("Store Name is Empty")
                .LessThanOrEqualTo("20")
                .WithMessage("Store Name Should be less than 20 character! ");

        }
    }
}
