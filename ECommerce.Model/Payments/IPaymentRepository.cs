using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Payments
{
    public interface IPaymentRepository : IRepository<Payment, Guid>
    {
    }
}
