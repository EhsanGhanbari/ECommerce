namespace ECommerce.Services.Groups.Messaging
{
    public class CreateGroupRequest
    {
        public GroupViewModel GroupViewModel { get; set; }

       public CreateGroupRequest(GroupViewModel groupViewModel)
       {
           GroupViewModel = groupViewModel;
       }
    }
}
