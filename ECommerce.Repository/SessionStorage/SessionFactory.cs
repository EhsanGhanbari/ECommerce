using System;
using System.Configuration;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using ECommerce.Repository.Persister.Products;

namespace ECommerce.Repository.SessionStorage
{
    public class SessionFactory
    {
        public static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["ECommerceConnectionString"].ToString(); }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var factory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                        .ConnectionString(c =>
                                c.FromConnectionStringWithKey("ECommerceConnectionString")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProductMapping>())
                .ExposeConfiguration(config =>
                {
                    var schemaExport = new SchemaExport(config);
                    schemaExport.Create(true, true);
                })
                .BuildSessionFactory();
                return factory;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            
        }

        private static ISession GetNewSession()
        {
            return CreateSessionFactory().OpenSession();
        }

        public static ISession GetCurrentSession()
        {
            var sessionStorageContainer = SessionStorageFactory.GetStorageContainer();

            var currentSession = sessionStorageContainer.GetCurrentSession();

            if (currentSession == null)
            {
                currentSession = GetNewSession();
                sessionStorageContainer.Store(currentSession);
            }

            return currentSession;
        }
    }
}
