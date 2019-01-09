using ECommerce.Model.Groups;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public class GroupMapping : ClassMap<Group>
    {
        public GroupMapping()
        {
           // Schema("Group");
            Table("Groups");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();

            Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

        }
    }
}
