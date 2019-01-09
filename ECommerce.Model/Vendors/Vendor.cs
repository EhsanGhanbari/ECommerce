using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Vendors
{
    public class Vendor : EntityBase<Guid>, IAggregateRoot
    {

        ///// <summary>
        ///// Gets or sets the name
        ///// </summary>
        //public virtual string Name { get; set; }

        ///// <summary>
        ///// Gets or sets the email
        ///// </summary>
        //public virtual string Email { get; set; }

        ///// <summary>
        ///// Gets or sets the description
        ///// </summary>
        //public virtual string Description { get; set; }

        ///// <summary>
        ///// Gets or sets the admin comment
        ///// 
        ///// </summary>
        //public virtual string AdminComment { get; set; }

        ///// <summary>
        ///// Gets or sets a value indicating whether the entity is active
        ///// </summary>
        //public virtual bool Active { get; set; }

        ///// <summary>
        ///// Gets or sets a value indicating whether the entity has been deleted
        ///// </summary>
        //public virtual bool Deleted { get; set; }



        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
