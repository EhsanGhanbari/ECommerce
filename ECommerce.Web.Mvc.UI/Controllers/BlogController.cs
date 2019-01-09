using System;
using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Blogs;
using ECommerce.Services.Blogs.Messaging;
using ECommerce.Services.Blogs.ViewModels;
using ECommerce.Web.Core.Controllers;


namespace ECommerce.Web.Mvc.UI.Controllers
{
    /// <summary>
    /// Blog Controller of the system 
    /// this is the Blog of the system not the users
    /// </summary>
    public class BlogController : BaseController
    {

        #region Fields
        private readonly IBlogService _blogService;
        #endregion

        #region Constructor
        public BlogController(ICookieStorageService cookieStorageService, IBlogService blogService)
            : base(cookieStorageService)
        {
            _blogService = blogService;
        }

        #endregion

        #region Posts

        /// <summary>
        /// returns the list of all posts
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            var blogViewModel = new BlogViewModel();
            var request = new GetAllBlogPostRequest(blogViewModel);
            var posts = _blogService.GetAllBlogPost(request);
            return View(posts.BlogPostViewModel);
        }



        /// <summary>
        /// Returns the post by Id
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="postSlug"></param>
        /// <returns></returns>
        public ActionResult Post(Guid postId, string postSlug)
        {
            var blogViewModel = new BlogViewModel();
            var request = new GetBlogPostRequest(blogViewModel);
            var posts = _blogService.GetBlogPost(request);
            return View("Post", posts.BlogViewModel);
        }

        /// <summary>
        /// Remove the blog post by Id
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public JsonResult RemovePost(Guid postId)
        {
            var blogViewModel = new BlogViewModel { PostId = postId };
            var request = new RemoveBlogPostRequest(blogViewModel);
            _blogService.RemoveBlogPost(request);
            return Json("");
        }

        /// <summary>
        /// returns post by publish date and Slug
        /// year + month + day + Slug
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="postSlug"></param>
        /// <returns></returns>
        public ActionResult Post(int year, int month, int day, string postSlug)
        {
            var request = new GetBlogPostRequest(year, month, day, postSlug);
            var post = _blogService.GetBlogPostByDate(request);
            return View("Post", post.BlogViewModel);
        }


        /// <summary>
        /// returns the Post for archive 
        /// year 
        /// </summary>
        /// <returns></returns>
        public ActionResult Archive(int year, int month)
        {
            var request = new GetAllBlogPostRequest(year, month);
            var posts = _blogService.GetArchivedBlogPostsByDate(request);
            return View("Archive", posts.BlogPostViewModel);
        }


        /// <summary>
        /// Create Blog Post
        /// this will be a post for the web site!
        /// </summary>
        /// <returns></returns>
        public ActionResult CreatePost()
        {
            var blogTagViewModel = new BlogTagViewModel();
            var request = new GetAllBlogTagsRequest(blogTagViewModel);
            ViewBag.tags = _blogService.GetAllBlogTags(request);
            return View("CreatePost");
        }

        [HttpPost]
        public ActionResult CreatePost(BlogViewModel blogViewModel)
        {
            var request = new CreateBlogPostRequest(blogViewModel);
            if (ModelState.IsValid)
            {
                _blogService.CreateBlogPost(request);
            }
            return View("CreatePost");
        }


        /// <summary>
        /// Edit Blog Post 
        /// </summary>
        /// <returns></returns>
        public ActionResult EditPost(Guid postId)
        {
            var blogViewModel = new BlogViewModel { PostId = postId };
            var request = new GetBlogPostRequest(blogViewModel);
            var post = _blogService.GetBlogPost(request);
            return View("EditPost", post.BlogViewModel);
        }

        [HttpPost]
        public ActionResult EditPost(BlogViewModel blogViewModel)
        {
            var request = new UpdateBlogPostRequest(blogViewModel);
            if (ModelState.IsValid)
            {
                _blogService.UpdateBlogPost(request);
            }
            return View("EditPost");
        }

        /// <summary>
        /// Return post by tag
        /// </summary>
        /// <returns></returns>
        public ActionResult PostByTag(string tag)
        {
            var blogViewModel = new BlogViewModel { TageName = tag };
            var request = new GetAllBlogPostByTagRequest(blogViewModel);
            var post = _blogService.GetAllBlogPostByTag(request);
            return View("PostByTag", post.BlogViewModel);
        }


        /// <summary>
        /// return post by category
        /// </summary>
        /// <returns></returns>
        public ActionResult PostByCategory(string category)
        {
            var blogViewModel = new BlogViewModel { CategoryName = category };
            var request = new GetAllBlogPostsByCategoryRequest(blogViewModel);
            var post = _blogService.GetAllBlogPostsByCategory(request);
            return View("PostByCategory", post.BlogViewModels);
        }

        #endregion

        #region Blog Tags

        /// <summary>
        /// returns all tags of the web site blog 
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        public PartialViewResult BlogTags()
        {
            var blogTagViewModel = new BlogTagViewModel();
            var request = new GetAllBlogTagsRequest(blogTagViewModel);
            var tags = _blogService.GetAllBlogTags(request);
            return PartialView("_BlogTags", tags.BlogTagViewModels);
        }

        /// <summary>
        /// Removes the blog tag
        /// only used by admin
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult RemoveBlogTag(string tagName)
        {
            var blogTagViewModel = new BlogTagViewModel() { BlogTagName = tagName };
            var request = new RemoveBlogTagRequest(blogTagViewModel);
            _blogService.RemoveBlogTag(request);
            return Json("");
        }

        #endregion

        #region Blog Categories

        /// <summary>
        /// returns partial view restul
        /// </summary>~
        /// <returns></returns>
        [ChildActionOnly]
        public PartialViewResult BlogCategories()
        {
            var blogCategoriesViewModel = new BlogCategoryViewModel();
            var request = new GetAllBlogCategoriesRequest(blogCategoriesViewModel);
            var categories = _blogService.GetAllBlogCategories(request);
            return PartialView("_BlogCategories", categories.BlogCategoryViewModels);
        }


        /// <summary>
        /// remove the blog category
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult RemoveBlogCategory(string categoryName)
        {
            var blogCategoryViewModel = new BlogCategoryViewModel { BlogCategoryName = categoryName };
            var request = new RemoveBlogCategoryRequest(blogCategoryViewModel);
            _blogService.RemoveBlogCategory(request);
            return Json("");
        }

        #endregion

    }
}
