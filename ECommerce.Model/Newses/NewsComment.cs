using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Commons;

namespace ECommerce.Model.Newses
{
    public sealed class NewsComment : Comment
    {
        public NewsComment(string name, string email, string body)
        {
            Body = body;
            Email = email;
            Name = name;
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
