namespace ECommerce.Services.Groups.Messaging
{
    public class GetAllGroupsRequest
    {
       internal GroupViewModel GroupViewModel { get; set; }

       public GetAllGroupsRequest(GroupViewModel groupViewModel)
       {
           GroupViewModel = groupViewModel;
       }
    }
}
