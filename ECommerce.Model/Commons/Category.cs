using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Commons
{
    /// <summary>
    /// this is a base category
    /// category entity
    /// </summary>
    public class Category : ValueObjectBase
    {

        /// <summary>
        /// Name of the category
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Logical delete of the category
        /// </summary>
        public virtual bool IsDeleted { get; set; }

        /// <summary>
        /// number of news
        /// </summary>
        public virtual long Count { get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        public virtual DateTime CreationTime { get; set; }


        protected override void Validate()
        {
            if (Name == null)
            {
                //AddBrokenRule(CategoryBusineeRule.NameRequired);
            }
        }
    }
}
