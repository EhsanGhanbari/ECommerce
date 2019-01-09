using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services.Exceptions
{
    public class CustomerInvalidException : Exception
    {
        public CustomerInvalidException(string message)
            : base(message)
        {
        }
    }
}
