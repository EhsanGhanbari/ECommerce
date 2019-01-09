using ECommerce.Model.Affiliates;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister.Marketings
{
    public class AffiliateMapping :ClassMap<Affiliate>
    {
        public AffiliateMapping()
        {
            Table("Affiliate");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();
            Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

        }
    }
}
