using ECommerce.Model.Stores;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public sealed class StoreMapping : ClassMap<Store>
    {
        public StoreMapping()
        {
            Table("Store");
            Not.LazyLoad();
            Id(s => s.Id).GeneratedBy.GuidComb();

            Map(s => s.Name).Not.Nullable().Length(30);
            Map(s => s.UrlName).Not.Nullable();


           // Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");


        }
    }
}
