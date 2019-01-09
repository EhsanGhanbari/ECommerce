using ECommerce.Repository.Persister.Products;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Dialect;

namespace ECommerce.Repository.SessionStorage
{
    public class DbConfigurtion
    {
        public static void CreateDatabaseObjects()
        {
            var config = Fluently.Configure().Database(
                MsSqlConfiguration.MsSql2008
                                  .ConnectionString(
                                      "Data Source=ECommerceConnectionString;Initial Catalog=ECommerce;Integrated Security=True")
                                  .ShowSql().Dialect<MsSql2008Dialect>());
       
            
            
            var persistenceModel = new PersistenceModel();
            persistenceModel.AddMappingsFromAssembly(typeof(ProductMapping).Assembly);
            var sessionSource = new SessionSource(config.BuildConfiguration().Properties, persistenceModel);
            var session = sessionSource.CreateSession();
            sessionSource.BuildSchema(session, true);
        }
    }
}
