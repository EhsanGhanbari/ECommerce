using ECommerce.Model.Shippings;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public class ShippingMapping : ClassMap<Shipping>
    {
        public ShippingMapping()
        {
            Table("Shipping");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();

          //  Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");


        }
    }
}
