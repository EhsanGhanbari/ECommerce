namespace ECommerce.Services.Forums.Messaging
{
    public class CreateForumRequest
    {
        internal ForumViewModel ForumViewModel { get; private set; }

        public CreateForumRequest(ForumViewModel forumViewModel)
        {
            ForumViewModel = forumViewModel;
        }

    }
}
