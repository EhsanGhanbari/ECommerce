using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class GetAllBlogPostByTagRequest
    {
        internal BlogViewModel BlogViewModel {  get; private set; }

        public GetAllBlogPostByTagRequest(BlogViewModel blogViewModel)
        {
            BlogViewModel = blogViewModel;
        }

        public string TagName { get; set; }
    }
}
