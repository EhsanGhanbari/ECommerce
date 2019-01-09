using System.Collections.Generic;

namespace ECommerce.Services.Groups.Messaging
{
    public class GetAllGroupsByProductBrandResponse
    {
        public IEnumerable<GroupViewModel> GroupViewModels { get; set; } 
    }
}
