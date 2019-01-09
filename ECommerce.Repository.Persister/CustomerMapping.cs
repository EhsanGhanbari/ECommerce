using ECommerce.Model.Customers;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public sealed class CustomerMapping :ClassMap<Customer>
    {
        public CustomerMapping()
        {
            Table("Customer");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();

            Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

        }
    }
}
