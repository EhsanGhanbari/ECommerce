using ECommerce.Model.Messages;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public class MessageMapping :ClassMap<Message>
    {
        public MessageMapping()
        {
            Table("Message");
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.GuidComb();

            //Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

        }
    }
}
