using ECommerce.Model.Shippings;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public class CourierMapping :ClassMap<Courier>
    {
        public CourierMapping()
        {
            Table("Courier");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();

           // Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");


        }
    }
}
