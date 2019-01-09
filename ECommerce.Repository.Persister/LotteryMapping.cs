using ECommerce.Model.Lotteries;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public class LotteryMapping :ClassMap<Lottery>
    {
        public LotteryMapping()
        {
            Table("Lottery");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();

           // Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

        } 
    }
}
