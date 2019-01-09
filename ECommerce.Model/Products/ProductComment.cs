using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Commons;

namespace ECommerce.Model.Products
{
    public class ProductComment : Comment
    {
        private readonly string _name;
        private readonly string _email;
        private readonly string _body;


        public ProductComment(string name, string email, string body)
        {
            _name = name;
            _email = email;
            _body = body;
        }


        public virtual new string Name
        {
            get { return _name; }
        }

        public virtual new string Email
        {
            get { return _email; }
        }

        public virtual new  string Body
        {
        get { return _body; }
        }

        public virtual new DateTime CreationTime
        {
            get { return DateTime.Now; }
        }
        


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
