using ECommerce.Model.Discounts;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public class DiscountMapping:ClassMap<Discount>
    {
        public DiscountMapping()
        {
            Table("Discount");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();

            Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

        }
    }
}
