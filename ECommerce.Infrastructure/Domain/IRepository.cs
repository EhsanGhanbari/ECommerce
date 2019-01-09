using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ECommerce.Infrastructure.Specification;

namespace ECommerce.Infrastructure.Domain
{
    /// <summary>
    /// Aggregation to retreive and persist
    /// every repository can be defined for an aggregate root
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TId"></typeparam>
    public interface IRepository<T, TId> where T : IAggregateRoot
    {
        void Add(T entity);
        void SaveOrUpdate(T entity);
        void Remove(T entity);
        void Remove(Func<T, Guid> predicate);
        T GetById(TId id);
        T GetByCondition(Func<T, Guid> where);
        T SingleBy(Expression<Func<T, bool>> query);
        IList<T> ListBy(Expression<Func<T, bool>> query);
        IEnumerable<T> GetAll();
        IQueryable<T> GetAll(Func<T, Boolean> where);
        IQueryable<T> GetAll(int index, int count);
        T FindFirstByExample<T>(object propertiesAndValues);
        IQueryable<T> QueryWith(ISpecification<T> specification);
        IQueryable<T> QueryWith(ISpecification<T> specification, int index, int count);
    }
}
