namespace ECommerce.Services.Groups.Messaging
{
    public class GetGroupRequest
    {
        public GroupViewModel GroupViewModel { get; set; }

        public GetGroupRequest(GroupViewModel groupViewModel)
        {
            GroupViewModel = groupViewModel;
        }
    }
}
