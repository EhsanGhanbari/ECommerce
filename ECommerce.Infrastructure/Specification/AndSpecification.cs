﻿using System;
using System.Linq.Expressions;

namespace ECommerce.Infrastructure.Specification
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> _leftSpecification;
        private readonly ISpecification<T> _rightSpecification;

        public AndSpecification(ISpecification<T> leftSpecification, ISpecification<T> rightSpecification)
        {
            _leftSpecification = leftSpecification;
            _rightSpecification = rightSpecification;
        }

        public override Expression<Func<T, bool>> IsSatisfied()
        {            
            return _leftSpecification.IsSatisfied().And(_rightSpecification.IsSatisfied());                         
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return _leftSpecification.IsSatisfiedBy(candidate) && _rightSpecification.IsSatisfiedBy(candidate);
        }
    }
}
