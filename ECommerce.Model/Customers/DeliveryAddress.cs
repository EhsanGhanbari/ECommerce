using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model.Customers
{
    public class DeliveryAddress
    {
        public virtual string Name { get; set; }
        public virtual Customer Customer { get; set; }


        //protected override void Validate()
        //{

        //    //if (String.IsNullOrEmpty(Name))
        //    //    AddBrokenRule(DeliveryAddressBusinessRules.NameRequired);

        //    //if (Customer == null)
        //    //    base.AddBrokenRule(DeliveryAddressBusinessRules.CustomerRequired);
        //}
    }
}
