namespace ECommerce.Services.Groups.Messaging
{
    public class GetAllGroupsByProductBrandRequest
    {
        public GroupViewModel GroupViewModel { get; private set; }

        public GetAllGroupsByProductBrandRequest(GroupViewModel groupViewModel)
        {
            GroupViewModel = groupViewModel;
        }
    }
}
