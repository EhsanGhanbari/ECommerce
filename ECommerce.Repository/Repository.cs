using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ECommerce.Infrastructure.Domain;
using ECommerce.Infrastructure.Specification;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Repository.SessionStorage;
using NHibernate;
using NHibernate.Linq;

namespace ECommerce.Repository
{
    public abstract class Repository<T, TEntityKey> where T : class, IAggregateRoot
    {
        private IUnitOfWork _unitOfWork;
        protected Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// General add repository of the system
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            SessionFactory.GetCurrentSession().Save(entity);
        }

        /// <summary>
        /// General Update repository of the system
        /// </summary>
        /// <param name="entity"></param>
        public void SaveOrUpdate(T entity)
        {
            SessionFactory.GetCurrentSession().SaveOrUpdate(entity);
        }

        /// <summary>
        /// General Update repository of the system
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(T entity)
        {
            SessionFactory.GetCurrentSession().Delete(entity);
        }

        /// <summary>
        /// Remove an object by predication
        /// </summary>
        /// <param name="predicate"></param>
        public void Remove(Func<T, Guid> predicate)
        {
            SessionFactory.GetCurrentSession().Delete(predicate);
        }

        /// <summary>
        /// General Get repository by Idenity of the system
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(TEntityKey id)
        {
            return SessionFactory.GetCurrentSession().Get<T>(id);
        }


        /// <summary>
        /// returns an object predication  
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public T GetByCondition(Func<T, Guid> where)
        {
            return SessionFactory.GetCurrentSession().Get<T>(where);
        }


        /// <summary>
        /// General Get All repository of the system
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll()
        {
            ICriteria criteriaQuery =
                   SessionFactory.GetCurrentSession().CreateCriteria(typeof(T));

            return criteriaQuery.List<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IQueryable<T> GetAll(Func<T, Boolean> where)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public IQueryable<T> GetAll(int index, int count)
        {
            ICriteria criteriaQuery = SessionFactory.GetCurrentSession().CreateCriteria(typeof(T));

            return (IQueryable<T>)criteriaQuery.SetFetchSize(count).SetFirstResult(index).List<T>();

            //throw new NotImplementedException();

        }


        public T SingleBy(Expression<Func<T, bool>> query)
        {
            return SessionFactory.GetCurrentSession().QueryOver<T>().Where(query).SingleOrDefault();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public virtual IList<T> ListBy(Expression<Func<T, bool>> query)
        {
            return SessionFactory.GetCurrentSession().QueryOver<T>().Where(query).List();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertiesAndValues"></param>
        /// <returns></returns>
        public T FindFirstByExample<T>(object propertiesAndValues)
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="specification"></param>
        /// <returns></returns>
        public IQueryable<T> QueryWith(ISpecification<T> specification)
        {
            return SessionFactory.GetCurrentSession().Query<T>().Where(specification.IsSatisfied());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="specification"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public IQueryable<T> QueryWith(ISpecification<T> specification, int index, int count)
        {
            return SessionFactory.GetCurrentSession().Query<T>().Where(specification.IsSatisfied()); 
        }
    }
}