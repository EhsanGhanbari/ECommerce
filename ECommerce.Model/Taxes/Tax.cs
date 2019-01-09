using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Taxes
{
    public class Tax : EntityBase<Guid>, IAggregateRoot
    {
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
