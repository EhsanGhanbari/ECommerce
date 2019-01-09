using ECommerce.Model.Baskets;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
 
    public sealed class BasketMapping :ClassMap<Basket>
    { 
        public BasketMapping()
        {
            Table("Basket");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();

            Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

        }
    }
}
