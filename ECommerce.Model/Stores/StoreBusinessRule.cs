using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECommerce.Infrastructure.Domain;


namespace ECommerce.Model.Stores
{
   public class StoreBusinessRule
    {
       public static readonly BusinessRule NameRequired=new BusinessRule("Name","every store should has a Name");
    }
}
