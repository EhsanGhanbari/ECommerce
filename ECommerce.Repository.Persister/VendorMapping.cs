using ECommerce.Model.Vendors;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public class VendorMapping:ClassMap<Vendor>
    {
        public VendorMapping()
        {
            Table("Vendor");
            Not.LazyLoad();
            Id(s => s.Id).GeneratedBy.GuidComb();

          //  Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");


        }
    }
}
