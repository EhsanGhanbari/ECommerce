using System.Collections.Generic;

namespace ECommerce.Services.Groups.Messaging
{
    public class GetAllGroupsRespone : BaseResponse
    {
        public IEnumerable<GroupViewModel> GroupViewModels { get; set; } 
    }
}
