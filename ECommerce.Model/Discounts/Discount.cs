using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Products;

namespace ECommerce.Model.Discounts
{

    public class Discount : EntityBase<Guid>, IAggregateRoot
    {
        private ICollection<DiscountRequirement> _discountRequirements;
        private ICollection<ProductCategory> _appliedToCategories;
       
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public virtual string Name { get; set; }
        
        /// <summary>
        /// Creation time
        /// </summary>
        public virtual DateTime CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the discount type identifier
        /// </summary>
        public virtual int DiscountTypeId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use percentage
        /// </summary>
        public virtual bool UsePercentage { get; set; }

        /// <summary>
        /// Gets or sets the discount percentage
        /// </summary>
        public virtual decimal DiscountPercentage { get; set; }

        /// <summary>
        /// Gets or sets the discount amount
        /// </summary>
        public virtual decimal DiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets the discount start date and time
        /// </summary>
        public virtual DateTime? StartDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the discount end date and time
        /// </summary>
        public virtual DateTime? EndDateUtc { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether discount requires coupon code
        /// </summary>
        public virtual bool RequiresCouponCode { get; set; }

        /// <summary>
        /// Gets or sets the coupon code
        /// </summary>
        public virtual string CouponCode { get; set; }

        /// <summary>
        /// Gets or sets the discount limitation identifier
        /// </summary>
        public virtual int DiscountLimitationId { get; set; }

        /// <summary>
        /// Gets or sets the discount limitation times (used when Limitation is set to "N Times Only" or "N Times Per Customer")
        /// </summary>
        public virtual int LimitationTimes { get; set; }

        /// <summary>
        /// Gets or sets the discount type
        /// </summary>
        public virtual DiscountType DiscountType
        {
            get
            {
                return (DiscountType)this.DiscountTypeId;
            }
            set
            {
                this.DiscountTypeId = (int)value;
            }
        }

        /// <summary>
        /// Gets or sets the discount limitation
        /// </summary>
        public virtual DiscountLimitationType DiscountLimitation
        {
            get
            {
                return (DiscountLimitationType)DiscountLimitationId;
            }
            set
            {
                DiscountLimitationId = (int)value;
            }
        }

        /// <summary>
        /// Gets or sets the discount requirement
        /// </summary>
        public virtual ICollection<DiscountRequirement> DiscountRequirements
        {
            get { return _discountRequirements ?? (_discountRequirements = new List<DiscountRequirement>()); }
            protected set { _discountRequirements = value; }
        }

        ///// <summary>
        ///// Gets or sets the categories
        ///// </summary>
        //public virtual ICollection<ProductCategory> AppliedToCategories
        //{
        //    get { return _appliedToCategories ?? (_appliedToCategories = new List<ProductCategory>()); }
        //    protected set { _appliedToCategories = value; }
        //}

        ///// <summary>
        ///// Gets or sets the product variants 
        ///// </summary>
        //public virtual ICollection<ProductVariant> AppliedToProductVariants
        //{
        //    get { return _appliedToProductVariants ?? (_appliedToProductVariants = new List<ProductVariant>()); }
        //    protected set { _appliedToProductVariants = value; }
        //}


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
