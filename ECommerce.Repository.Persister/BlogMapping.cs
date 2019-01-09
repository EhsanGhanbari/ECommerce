using ECommerce.Model.Blogs;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public sealed class BlogMapping : ClassMap<Blog>
    {
        public BlogMapping()
        {
            Schema("Blogs");
            Table("Blog");
            Not.LazyLoad();
            Id(b => b.Id).GeneratedBy.GuidComb();

            Map(b => b.Title).Length(150).Not.Nullable();
            Map(b => b.Body).Not.Nullable();
            Map(b => b.Summary).Length(500).Nullable();
            Map(b => b.PostSlug).Not.Nullable();
            Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");
            Map(b => b.AllowComments).Not.Nullable();

            HasManyToMany(n => n.BlogTag)
                .Schema("Blogs")
                .Table("Blog_BlogTag")
                .ParentKeyColumn("Id")
                .ChildKeyColumn("Name");
                //.Component(x => x.Map(Reveal.Member<BlogTag>("_newsTag")).Column("newsTagId"));


        }
    }
}
