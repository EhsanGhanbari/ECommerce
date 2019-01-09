using ECommerce.Model.Languages;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public class LanguageMapping : ClassMap<Language>
    {
        public LanguageMapping()
        {
            Table("Language");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();

            //Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

        }
    }
}
