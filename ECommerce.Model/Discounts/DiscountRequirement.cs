using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Discounts
{
    /// <summary>
    /// Represents a discount requirement
    /// </summary>
    public class DiscountRequirement : EntityBase<Guid>
    {
        /// <summary>
        /// Gets or sets the discount identifier
        /// </summary>
        public virtual  int DiscountId { get; set; }

        /// <summary>
        /// Gets or sets the discount requirement rule system name
        /// </summary>
        public virtual string DiscountRequirementRuleSystemName { get; set; }

        /// <summary>
        /// Gets or sets the discount
        /// </summary>
        public virtual Discount Discount { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
