using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Commons
{
    public class Picture : EntityBase<Guid>
    {
        public string MetaData { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
