using ECommerce.Model.Media;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public class DownloadMapping : ClassMap<Download>
    {
       public DownloadMapping()
       {
           Table("Download");
           Not.LazyLoad();
           Id(c => c.Id).GeneratedBy.GuidComb();
           
          // Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

       }
    }
}
