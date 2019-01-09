using System;
using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.Helpers;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Blogs;
using ECommerce.Services.Blogs.Messaging;

namespace ECommerce.Services.Blogs
{
    public class BlogService : IBlogService
    {

        #region Constructure

        private readonly IBlogRepository _blogRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public BlogService(
            IBlogRepository blogRepository,
            IUnitOfWork unitOfWork,
            ILogger logger)
        {
            _blogRepository = blogRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        #endregion

        #region Blog Post

        /// <summary>
        /// Create Post for blog based on selected category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateBlogPostResponse CreateBlogPost(CreateBlogPostRequest request)
        {
            var response = new CreateBlogPostResponse();
            try
            {
                
                //List of blog tag and blog category
                var blogTag = new BlogTag(request.BlogTags);
                var blogCategory = new BlogCategory(request.BlogCategories);

                var blog = new Blog(
                    request.BlogViewModel.Title,
                    request.BlogViewModel.Body,
                    request.BlogViewModel.Summary,
                    request.BlogViewModel.PostSlug.GenerateSlug(),
                    request.BlogViewModel.AllowComment,
                    blogTag.BlogTags,
                    blogCategory.BlogCategories);


                _blogRepository.Add(blog);
                _unitOfWork.Commit();
                response.Success = true;
                response.MessageType = MessageType.Success;
                response.Message = ServiceMessages.GeneralServiceSuccessMessageOnCreation;
                _logger.Log(string.Format(response.Message));
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// Gets a blog post requested by Admin 
        /// Get the post by it's Id 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetBlogPostResponse GetBlogPost(GetBlogPostRequest request)
        {
            var response = new GetBlogPostResponse();
            try
            {
                var blogPost = _blogRepository.GetById(request.BlogViewModel.PostId);
                if (blogPost != null)
                {
                    response.BlogViewModel = blogPost.ConvertToPostViewModel();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnRetrieveInformation;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// returns all of the blog post of the requested User, User is Admin or StoreOwner
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllBlogPostResponse GetAllBlogPost(GetAllBlogPostRequest request)
        {
            var response = new GetAllBlogPostResponse();
            try
            {
                var blogPosts = _blogRepository.GetAll();
                if (blogPosts != null)
                {
                    response.BlogPostViewModel = blogPosts.ConvertToPostListViewModel();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
                else
                {
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                _logger.Log(string.Format(response.Message));
                _logger.Log(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// Update the blog post content
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateBlogPostResponse UpdateBlogPost(UpdateBlogPostRequest request)
        {
            var response = new UpdateBlogPostResponse();
            try
            {
                var requestedPost = _blogRepository.GetById(request.BlogViewModel.PostId);
                if (requestedPost != null)
                {
                    var blogPost = request.BlogViewModel.ConvertToPostModel();
                    _blogRepository.SaveOrUpdate(blogPost);
                    _unitOfWork.Commit();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Warning;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnEdition;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// Remove BlogPost by it's category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveBlogPostResponse RemoveBlogPost(RemoveBlogPostRequest request)
        {
            var response = new RemoveBlogPostResponse();
            var post = request.BlogViewModel.ConvertToPostModel();
            try
            {
                var requestedPost = _blogRepository.GetById(request.BlogViewModel.PostId);
                if (requestedPost != null)
                {
                    _blogRepository.Remove(post);
                    _unitOfWork.Commit();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnDeletion;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnDeletion;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// Get All Blog Post by tag 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllBlogPostByTagResponse GetAllBlogPostByTag(GetAllBlogPostByTagRequest request)
        {
            var response = new GetAllBlogPostByTagResponse();
            try
            {
                var posts = _blogRepository.GetAllBlogPostsByTagQuery(request.TagName);
                if (posts != null)
                {
                    response.BlogViewModel = posts.ConvertToPostListViewModel();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                }

            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnRetrieveInformation;
                _logger.Log(response.Message);
                _logger.Error(exception.Message);
            }
            return response;
        }



        /// <summary>
        /// returns the post by date
        /// year + month + day
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetBlogPostResponse GetBlogPostByDate(GetBlogPostRequest request)
        {
            var response = new GetBlogPostResponse();
            try
            {
                var post = _blogRepository.GetPostByDateQuery(request.Year, request.Month, request.Day, request.PostSlug);
                if (post != null)
                {
                    response.BlogViewModel = post.ConvertToPostViewModel();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnRetrieveInformation;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// returns the Archived post by Date
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllBlogPostResponse GetArchivedBlogPostsByDate(GetAllBlogPostRequest request)
        {
            var response = new GetAllBlogPostResponse();
            try
            {
                var posts = _blogRepository.GetAllArchivedPostsByDateQuery(request.Year, request.Month);
                if (posts != null)
                {
                    response.BlogPostViewModel = posts.ConvertToPostListViewModel();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnRetrieveInformation;
                _logger.Error(exception.Message);
                _logger.Log(response.Message);
            }
            return response;
        }


        /// <summary>
        /// Get All blog post by cateory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllBlogPostsByCategoryResponse GetAllBlogPostsByCategory(GetAllBlogPostsByCategoryRequest request)
        {
            var response = new GetAllBlogPostsByCategoryResponse();

            try
            {
                var posts = _blogRepository.GetAllBlogPostsByCategoryQuery(request.CategorName); //Doubt!
                if (posts != null)
                {
                    response.BlogViewModels = posts.ConvertToPostListViewModel();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnRetrieveInformation;
                _logger.Error(exception.Message);
                _logger.Log(response.Message);
            }

            return response;
        }

        #endregion

        #region Blog Tag

        /// <summary>
        /// Get All Blog Tag
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllBlogTagsResponse GetAllBlogTags(GetAllBlogTagsRequest request)
        {
            var response = new GetAllBlogTagsResponse();
            try
            {
                var blogTags = _blogRepository.GetAllBlogTagsQuery(request.BlogTagViewModel.BlogTagName);
                if (blogTags != null)
                {
                    response.BlogTagViewModels = blogTags.ConvertToBlogTagViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnRetrieveInformation;
                _logger.Log(response.Message);
                _logger.Error(exception.Message);
            }
            return response;
        }

        /// <summary>
        /// Remove Blog tag
        /// Remove from data base, used only by management
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveBlogTagResponse RemoveBlogTag(RemoveBlogTagRequest request)
        {
            var response = new RemoveBlogTagResponse();

            try
            {
                var requestedPost = _blogRepository.GetBlogTagQuery(request.BlogTagViewModel.BlogTagName);
                if (requestedPost != null)
                {
                   
                    
                   // blog.RemoveBlogTag(requestedPost);
                    //_blogRepository.Remove(blog);
                    _unitOfWork.Commit();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnDeletion;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnDeletion;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }

        #endregion

        #region blog Category

        /// <summary>
        /// Get all blog category 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllBlogCategoriesResponse GetAllBlogCategories(GetAllBlogCategoriesRequest request)
        {
            var response = new GetAllBlogCategoriesResponse();
            try
            {

                var blogCategories =
                    _blogRepository.GetAllBlogCategoriesQuery(request.BlogCategoryViewModel.BlogCategoryName);
                if (blogCategories != null)
                {
                    response.BlogCategoryViewModels = blogCategories.ConvertToBlogCategoryViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }

        /// <summary>
        /// Remove blog category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveBlogCategoryResponse RemoveBlogCategory(RemoveBlogCategoryRequest request)
        {
            var response = new RemoveBlogCategoryResponse();
            try
            {
                var requestedPost = _blogRepository.GetBlogCategoryQuery(request.BlogCategoryViewModel.BlogCategoryName);
                if (requestedPost != null)
                {
                    //var blog = new Blog();
                    //blog.RemoveBlogCategory(requestedPost);
                    //_blogRepository.Remove(blog);
                    _unitOfWork.Commit();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnDeletion;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnDeletion;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);
            }

            return response;
        }

        #endregion

        #region Blog Comment

        /// <summary>
        /// Remove blog comments 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveBlogCommentResponse RemoveBlogComment(RemoveBlogCommentRequest request)
        {
            var response = new RemoveBlogCommentResponse();
            try
            {
                //  var blog = new Blog();
                //  var blogComment = request.BlogViewModel.ConvertToBlogCommentModel();
                //  blog.RemoveBlogComment(blogComment); //TODO
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// Get all blog comments
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllBlogCommentsResponse GetAllBlogComments(GetAllBlogCommentsRequest request)
        {
            var response = new GetAllBlogCommentsResponse();
            try
            {
                var blogComments = _blogRepository.GetAllBlogCommentsQuery(request.BlogViewModel.PostId);
                if (blogComments != null)
                {
                    response.BlogViewModels = blogComments.ConvertToBlogCommentViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }

            }
            catch (Exception exception)
            {

                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }

            return response;
        }


        #endregion
    }
}
