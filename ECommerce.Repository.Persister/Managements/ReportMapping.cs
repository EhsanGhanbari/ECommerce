using ECommerce.Model.Management;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister.Managements
{
    public class ReportMapping : ClassMap<Report>
    {
        public ReportMapping()
        {
           // Schema("Management");
            Table("Report");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();
           // Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

        }
    }
}
