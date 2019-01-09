using System;
using System.Linq.Expressions;

namespace ECommerce.Infrastructure.Specification
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {        
        public abstract bool IsSatisfiedBy(T candidate);

        public abstract Expression<Func<T, bool>> IsSatisfied();

        public CompositeSpecification<T> And(ISpecification<T> other)
        {
            return new AndSpecification<T>(this, other);
        }

        public CompositeSpecification<T> Or(ISpecification<T> other)
        {
            return new OrSpecification<T>(this, other);
        }

        public CompositeSpecification<T> Not()
        {
            return new NotSpecification<T>(this);
        }
    }
}
