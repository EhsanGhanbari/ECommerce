using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Customers
{
    public class CustomerBusinessRules
    {
        public static readonly BusinessRule FirstNameRequired = new BusinessRule(
                                      "FirstName", "A customer must have a first name.");
        public static readonly BusinessRule SecondNameRequired = new BusinessRule(
                                    "SecondName", "A customer must have a second name.");
        public static readonly BusinessRule EmailRequired = new BusinessRule(
                                 "Email", "A customer must have a valid email address.");
        
    }
}
