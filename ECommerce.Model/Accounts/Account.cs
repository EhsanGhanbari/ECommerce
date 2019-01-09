using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Accounts
{
    public class Account :EntityBase<Guid> , IAggregateRoot
    {
        public virtual string Email { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }

        //public virtual IProfile Profile { get; set; }

        public virtual DateTime CreationTime { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
