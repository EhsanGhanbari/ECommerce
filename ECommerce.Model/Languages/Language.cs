using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Languages
{
    public class Language : EntityBase<Guid>, IAggregateRoot
    {


        /// <summary>
        /// Name/Title of the language
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string LanguageCulture { get; set; }




        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
