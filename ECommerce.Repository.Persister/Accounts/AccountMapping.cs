using ECommerce.Model.Accounts;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister.Accounts
{
    public class AccountMapping : ClassMap<Account>
    {
        public AccountMapping()
        {
          //  Schema("Accounting");
            Table("Account");
            Not.LazyLoad();
            Id(a => a.Id).GeneratedBy.GuidComb();
            Map(a => a.UserName).Not.Nullable().Length(30);
            Map(a => a.Password).Not.Nullable().Length(18);
            Map(a => a.Email).Not.Nullable();
            Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");


        }
    }
}
