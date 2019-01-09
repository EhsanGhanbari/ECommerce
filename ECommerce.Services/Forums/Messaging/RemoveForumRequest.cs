namespace ECommerce.Services.Forums.Messaging
{
    public class RemoveForumRequest
    {
        internal ForumViewModel ForumViewModel { get; private set; }

        public RemoveForumRequest(ForumViewModel forumViewModel)
        {
            ForumViewModel = forumViewModel;
        }
    }
}
