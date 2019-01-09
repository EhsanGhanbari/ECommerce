using ECommerce.Services.Newses.Messaging;

namespace ECommerce.Services.Newses
{
    public interface INewsService
    {

        #region News Post

        /// <summary>
        /// Create News 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateNewsResponse CreateNews(CreateNewsRequest request);

        /// <summary>
        /// Get News By Id 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetNewsResponse GetNews(GetNewsRequest request);

        /// <summary>
        /// Get All News 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllNewsResponse GetAllNews(GetAllNewsRequest request);

        /// <summary>
        /// Updates News 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateNewsResponse UpdateNews(UpdateNewsRequest request);

        /// <summary>
        /// Remove News
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveNewsResponse RemoveNews(RemoveNewsRequest request);

        /// <summary>
        /// Get News By Date
        /// year + month + day 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetNewsResponse GetNewsByDate(GetNewsRequest request);

        /// <summary>
        /// archived News By Date
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllNewsResponse GetAllArchivedNewsByDate(GetAllNewsRequest request);


        /// <summary>
        /// Returns all the post by category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllNewsPostsByCategoryResponse GetAllNewsPostByCategory(GetAllNewsPostsByCategoryRequest request);

        /// <summary>
        /// Returns all the posts by tags
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllNewsPostsByTagResponse GetAllNewsPostsByTag(GetAllNewsPostsByTagRequest request);

        #endregion

        #region News Tag

        /// <summary>
        /// Get all news tag
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllNewsTagResponse GetAllNewsTags(GetAllNewsTagRequest request);


        /// <summary>
        /// Remove news tag
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveNewsTagResponse RemoveNewsTag(RemoveNewsTagRequest request);


        #endregion


        #region News Category

        /// <summary>
        /// Get all news category 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllNewsCategoriesResponse GetAllNewsCategories(GetAllNewsCategoriesRequest request);


        /// <summary>
        /// Remove news category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveNewsCategoryResponse RemoveNewsCategory(RemoveNewsCategoryRequest request);

        #endregion
    }
}
