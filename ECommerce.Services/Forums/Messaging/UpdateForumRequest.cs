namespace ECommerce.Services.Forums.Messaging
{
    public class UpdateForumRequest
    {
        internal ForumViewModel ForumViewModel { get; private set; }

        public UpdateForumRequest(ForumViewModel forumViewModel)
        {
            ForumViewModel = forumViewModel;
        }
    }
}
