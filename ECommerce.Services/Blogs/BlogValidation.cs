using System;
using ECommerce.Services.Blogs.ViewModels;
using FluentValidation;

namespace ECommerce.Services.Blogs
{
    public class BlogValidation : AbstractValidator<BlogViewModel>
    {
        public BlogValidation()
        {
            //RuleFor(b => b.Body).NotEmpty().WithMessage("Post Body is Empty");
        }
    }
}
