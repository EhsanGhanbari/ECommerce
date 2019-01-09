using ECommerce.Model.Orders;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister.Orders
{
   public class OrderItemMapping: ClassMap<OrderItem>
   {
       public OrderItemMapping()
       {
           //Schema("Ordering");
           Table("OrderItem");
           Not.LazyLoad();
           Id(c => c.Id).GeneratedBy.GuidComb();

           //Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

       }
    }
}
