using ECommerce.Model.Forums;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public class ForumMapping : ClassMap<Forum>
    {
        public ForumMapping()
        {
            Table("Forum");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();

            Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

        }
    }
}
