namespace ECommerce.Services.Groups.Messaging
{
    public class GetAllMembersOfGroupRequest
    {
        internal GroupViewModel GroupViewModel { get; private set; }

        public GetAllMembersOfGroupRequest(GroupViewModel groupViewModel)
        {
            GroupViewModel = groupViewModel;
        }
    }
}
