using System;
using System.Collections.Generic;

namespace ECommerce.Model.Accounts.Profiles
{
    public class Profile 
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public  ICollection<ProfilePicture> ProfilePicture { get; set; }
       



        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    
    }
}
