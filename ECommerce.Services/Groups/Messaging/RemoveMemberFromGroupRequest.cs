namespace ECommerce.Services.Groups.Messaging
{
    public class RemoveMemberFromGroupRequest
    {
        internal GroupViewModel GroupViewModel { get; set; }

        public RemoveMemberFromGroupRequest(GroupViewModel groupViewModel)
        {
            GroupViewModel = groupViewModel;
        }
    }
}
