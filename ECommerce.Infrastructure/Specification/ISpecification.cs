using System;
using System.Linq.Expressions;

namespace ECommerce.Infrastructure.Specification
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> IsSatisfied();
        bool IsSatisfiedBy(T entity);
    }
}
