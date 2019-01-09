using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Lotteries
{
    public class Lottery : EntityBase<Guid>, IAggregateRoot
    {
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
