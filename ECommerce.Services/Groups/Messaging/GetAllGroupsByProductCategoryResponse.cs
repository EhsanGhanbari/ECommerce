using System.Collections.Generic;

namespace ECommerce.Services.Groups.Messaging
{
    public class GetAllGroupsByCategoryResponse
    {
        public IEnumerable<GroupViewModel> GroupViewModels { get; set; }
    }
}
