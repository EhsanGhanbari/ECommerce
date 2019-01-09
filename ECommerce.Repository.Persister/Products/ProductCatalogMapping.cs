using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Model.Products;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister.Products
{
    public class ProductCatalogMapping : ClassMap<ProductCatalog>
    {
        public ProductCatalogMapping()
        {
           // Schema("Producing");
            Table("ProductCatalog");
            LazyLoad();
            Id(p => p.Id).GeneratedBy.GuidComb();
            
            Map(p => p.Name).Not.Nullable().Length(70);
            //Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");


            //HasManyToMany(x => x.Products)//.Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore)
            //       .Schema("Product").Table("Product_ProductCatalog").ParentKeyColumn("ProductId").ChildKeyColumn("ProductCatalogId");
            
        }
    }
}
