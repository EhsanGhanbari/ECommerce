using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Identities
{
    public class Country : ValueObjectBase
    {
        private  Province _province;


        public string Name { get; set; }
        public  virtual Province Province
        {
            get { return _province; }
            set { _province = value; }
        }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
