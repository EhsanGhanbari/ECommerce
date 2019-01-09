namespace ECommerce.Services.Groups.Messaging
{
    public class RemoveGroupRequest
    {
        internal GroupViewModel GroupViewModel { get; private set; }

        public RemoveGroupRequest(GroupViewModel groupViewModel)
        {
            GroupViewModel = groupViewModel;
        }
    }
}
