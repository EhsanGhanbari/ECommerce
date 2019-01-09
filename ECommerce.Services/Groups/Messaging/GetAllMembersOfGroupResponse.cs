using System.Collections.Generic;

namespace ECommerce.Services.Groups.Messaging
{
    public class GetAllMembersOfGroupResponse : BaseResponse
    {
        public IEnumerable<GroupViewModel> GroupViewModels { get; set; } 
    }
}
