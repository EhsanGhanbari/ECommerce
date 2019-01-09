using ECommerce.Services.Blogs.Messaging;

namespace ECommerce.Services.Blogs
{
    public interface IBlogService
    {

        #region Blog Post

        /// <summary>
        /// Create Blog post
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateBlogPostResponse CreateBlogPost(CreateBlogPostRequest request);

        /// <summary>
        /// Get Post By Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetBlogPostResponse GetBlogPost(GetBlogPostRequest request);

        /// <summary>
        /// returns all post
        /// all post of the website and all post of the a store 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllBlogPostResponse GetAllBlogPost(GetAllBlogPostRequest request);

        /// <summary>
        /// Update the post by it's Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateBlogPostResponse UpdateBlogPost(UpdateBlogPostRequest request);

        /// <summary>
        /// Remove the post By Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveBlogPostResponse RemoveBlogPost(RemoveBlogPostRequest request);

        /// <summary>
        /// returns the post by Date
        /// Year + month + day
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetBlogPostResponse GetBlogPostByDate(GetBlogPostRequest request);

        /// <summary>
        /// returns the archived post by Date
        /// Year + Month
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllBlogPostResponse GetArchivedBlogPostsByDate(GetAllBlogPostRequest request);


        /// <summary>
        /// Get All blog post by tag
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllBlogPostByTagResponse GetAllBlogPostByTag(GetAllBlogPostByTagRequest request);



        /// <summary>
        /// Get All blog post by category 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllBlogPostsByCategoryResponse GetAllBlogPostsByCategory(GetAllBlogPostsByCategoryRequest request);

      
        #endregion

        #region Blog Tag

        /// <summary>
        /// Get All tag of the blog
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllBlogTagsResponse GetAllBlogTags(GetAllBlogTagsRequest request);


        /// <summary>
        /// Remove blog tag
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveBlogTagResponse RemoveBlogTag(RemoveBlogTagRequest request);

        #endregion

        #region Blog Category
       
        /// <summary>
        /// Get all blog categories response
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllBlogCategoriesResponse GetAllBlogCategories(GetAllBlogCategoriesRequest request);


        /// <summary>
        /// Remove Blog Category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveBlogCategoryResponse RemoveBlogCategory(RemoveBlogCategoryRequest request);

        #endregion 

        #region Blog Comment

        /// <summary>
        /// Get All blog Comments 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllBlogCommentsResponse GetAllBlogComments(GetAllBlogCommentsRequest request);

        /// <summary>
        /// Remove blog comment
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveBlogCommentResponse RemoveBlogComment(RemoveBlogCommentRequest request);

        #endregion
      
    }
}
