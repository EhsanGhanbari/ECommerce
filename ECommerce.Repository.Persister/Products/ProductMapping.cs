using ECommerce.Model.Products;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister.Products
{
    public sealed class ProductMapping : ClassMap<Product>
    {
        public ProductMapping()
        {
           // Schema("Producing");
            Table("Product");
            LazyLoad();
            Id(p => p.Id).GeneratedBy.GuidComb();

            Map(p => p.Name).Not.Nullable().Length(70);
            Map(p => p.Price).Nullable();
            Map(p => p.AllowComment).Nullable();
            Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");


            //HasManyToMany(x => x.ProductCategory)//.Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore)
            //       .Schema("Product").Table("Product_ProductCategory").ParentKeyColumn("ProductId").ChildKeyColumn("ProductCategoryId");


            //HasManyToMany(x => x.ProductTags)//.Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore)
            //       .Schema("Product").Table("Product_ProductTag").ParentKeyColumn("ProductId").ChildKeyColumn("ProductTagId");


            //Component(p => p.ProductSize, m => m.Map(x => x.Name).Column("ProductSize").Length(50).Nullable());
            //Component(p => p.ProductColor, m => m.Map(x => x.Name).Column("ProductColor").Length(50).Nullable());
            //Component(p => p.ProductBrand, m => m.Map(x => x.Name).Column("ProductBrand").Length(50).Nullable());
            //Component(p => p.ProductManufacturer, m => m.Map(x => x.Name).Column("ProductManufacturer").Nullable());
            ////Component(p => p.ProductDetail, m => m.Map(x => x.Description).Column("ProductDetail").Length(50).Nullable());

        }
    }
}
