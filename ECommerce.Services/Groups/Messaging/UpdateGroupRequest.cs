namespace ECommerce.Services.Groups.Messaging
{
    public class UpdateGroupRequest
    {
        internal GroupViewModel GroupViewModel { get; private set; }

        public UpdateGroupRequest(GroupViewModel groupViewModel)
        {
            GroupViewModel = groupViewModel;
        }
    }
}
