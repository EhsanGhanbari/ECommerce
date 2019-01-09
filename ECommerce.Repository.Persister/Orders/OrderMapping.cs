using ECommerce.Model.Orders;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister.Orders
{
    public sealed class OrderMapping :ClassMap<Order>
    {
        public OrderMapping()
        {
           // Schema("Ordering");
            Table("Orders");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();

            Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

        }
    }
}
