using ECommerce.Model.Newses;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public sealed class NewsMapping : ClassMap<News>
    {
        public NewsMapping()
        {
            Schema("Newses");
            Table("News");
            Not.LazyLoad();
            Id(n => n.Id).GeneratedBy.GuidComb();

            Map(n => n.Title).Length(150).Not.Nullable();
            Map(n => n.Body).Not.Nullable();
            Map(n => n.Summary).Length(500).Nullable();
            Map(n => n.NewsSlug).Not.Nullable();
            Map(n => n.CreationTime).Not.Nullable().CustomType("datetime2");
            Map(n => n.AllowComments).Not.Nullable();


            //HasManyToMany(n => n.NewsTags)
            //    .Schema("News")
            //    .Table("News_NewsTag")
            //    .ParentKeyColumn("NewsId")
            //    .ChildKeyColumn("NewsTagId")
            //    .Component(x=>x.Map(Reveal.Member<NewsTag>("_newsTag")).Column("newsTagId"));
            

            //HasManyToMany(n => n.NewsCategories)
            //    .Schema("News")
            //    .Table("News_NewsCategory")
            //    .ParentKeyColumn("CategoryId")
            //    .ChildKeyColumn("NewsCategoryId")
            //    .Component(x => x.Map(Reveal.Member<NewsCategory>("_newsCategory")).Column("newsCategoryId"));



        }
    }
}
