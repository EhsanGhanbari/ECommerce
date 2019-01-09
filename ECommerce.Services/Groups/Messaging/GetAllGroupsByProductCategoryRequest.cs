namespace ECommerce.Services.Groups.Messaging
{
    public class GetAllGroupsByCategoryRequest
    {
        public GroupViewModel GroupViewModel { get; set; }

        public GetAllGroupsByCategoryRequest(GroupViewModel groupViewModel)
        {
            GroupViewModel = groupViewModel;
        }
    }
}
