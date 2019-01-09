using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Model.Taxes;
using FluentNHibernate.Mapping;

namespace ECommerce.Repository.Persister
{
    public class TaxMapping : ClassMap<Tax>
    {
        public TaxMapping()
        {
            Table("Store");
            Not.LazyLoad();
            Id(s => s.Id).GeneratedBy.GuidComb();

           // Map(t => t.CreationTime).Not.Nullable().CustomType("datetime2");

        }
    }
}
