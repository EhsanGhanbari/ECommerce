using System;
using System.Collections.Generic;
using System.Security.Policy;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Blogs
{
    public interface IBlogRepository : IRepository<Blog, Guid>
    {

        #region Blog post

        /// <summary>
        /// return post by Publish date
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="postSlug"></param>
        /// <returns></returns>
        Blog GetPostByDateQuery(int year, int month, int day, string postSlug);


        /// <summary>
        /// returns the archived post by Post and
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<Blog> GetAllArchivedPostsByDateQuery(int year, int month);

        /// <summary>
        /// Returns the posts by tag
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        IEnumerable<Blog> GetAllBlogPostsByTagQuery(string tag);


        /// <summary>
        /// Returns all blogs posts by a category 
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        IEnumerable<Blog> GetAllBlogPostsByCategoryQuery(string categoryName);

        #endregion

        #region  Blog Tag

        /// <summary>
        /// Returns the blog tag by it's value
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        BlogTag GetBlogTagQuery(string tag);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        IEnumerable<BlogTag> GetAllBlogTagsQuery(string tagName);


        #endregion

        #region Blog Category

        /// <summary>
        /// returns Blog Category by it's value
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        BlogCategory GetBlogCategoryQuery(string category);

        /// <summary>
        /// Returns all blog categiories
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        IEnumerable<BlogCategory> GetAllBlogCategoriesQuery(string categoryName);

        #endregion

        #region Blog Comment 

        /// <summary>
        /// Returns all blog Comments
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        IEnumerable<BlogComment> GetAllBlogCommentsQuery(Guid postId);


        #endregion
      
    }
}
