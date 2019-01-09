using System;
using ECommerce.Infrastructure.Domain;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Repository.SessionStorage;
using NHibernate;

namespace ECommerce.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public void RegisterAmended(IAggregateRoot entity,
                                    IUnitOfWorkRepository unitofWorkRepository)
        {
            SessionFactory.GetCurrentSession().SaveOrUpdate(entity);
        }

        public void RegisterNew(IAggregateRoot entity,
                                IUnitOfWorkRepository unitofWorkRepository)
        {
            SessionFactory.GetCurrentSession().Save(entity);
        }

        public void RegisterRemoved(IAggregateRoot entity,
                                    IUnitOfWorkRepository unitofWorkRepository)
        {
            SessionFactory.GetCurrentSession().Delete(entity);
        }

        public void Commit()
        {
            using (var transaction = SessionFactory.GetCurrentSession().BeginTransaction())
            {
                try
                {
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
