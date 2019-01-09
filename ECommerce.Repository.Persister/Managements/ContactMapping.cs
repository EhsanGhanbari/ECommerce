using ECommerce.Model.Management;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister.Managements
{
    public class ContactMapping : ClassMap<Contact>
    {
        public ContactMapping()
        {
           // Schema("Management");
            Table("Contact");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();
           
            Map(c => c.Name).Nullable().Length(30);
            Map(c => c.Title).Nullable().Length(100);
            Map(c => c.Email).Not.Nullable().Length(50);
            Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");
            Map(c => c.Body).Not.Nullable().Length(500);
            Map(c => c.IsRead);
            Map(c => c.IsReplied);
            Map(c => c.ReplyDate).Nullable().CustomType("datetime2");
            Map(c => c.ReplyMessage).Nullable().CustomType("datetime2");
        }
    }
}
