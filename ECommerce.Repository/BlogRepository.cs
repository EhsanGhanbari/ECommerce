using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Blogs;
using ECommerce.Repository.SessionStorage;

namespace ECommerce.Repository
{
    public class BlogRepository : Repository<Blog, Guid>, IBlogRepository
    {
        public BlogRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #region Blog Post


        /// <summary>
        /// returns the post by publish date
        /// only returns one post 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="postSlug"></param>
        /// <returns></returns>
        public Blog GetPostByDateQuery(int year, int month, int day, string postSlug)
        {

            var query =
                SessionFactory.GetCurrentSession()
                              .QueryOver<Blog>()
                              .Where(
                                  b =>
                                  b.CreationTime.Year == year && b.CreationTime.Month == month &&
                                  b.CreationTime.Day == day && b.PostSlug == postSlug).SingleOrDefault();
            return query;
        }


        /// <summary>
        /// Post By Archive Query
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<Blog> GetAllArchivedPostsByDateQuery(int year, int month)
        {

            var query = SessionFactory.GetCurrentSession().QueryOver<Blog>()
                                      .Where(b => b.CreationTime.Year == year && b.CreationTime.Month == month).List();
            return query;
        }


        /// <summary>
        /// Returns the blog post by tag
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public IEnumerable<Blog> GetAllBlogPostsByTagQuery(string tag)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the 
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public IEnumerable<Blog> GetAllBlogPostsByCategoryQuery(string categoryName)
        {
            throw new NotImplementedException();
        }

        #endregion 

        #region Blog Tag

        /// <summary>
        /// Returns the blog tag by it's value
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public BlogTag GetBlogTagQuery(string tag)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public IEnumerable<BlogTag> GetAllBlogTagsQuery(string tagName)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Blog Category

        /// <summary>
        /// Get Blog Cateogry
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public BlogCategory GetBlogCategoryQuery(string category)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all blog category 
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public IEnumerable<BlogCategory> GetAllBlogCategoriesQuery(string categoryName)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region Blog Comment


        /// <summary>
        /// 
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public IEnumerable<BlogComment> GetAllBlogCommentsQuery(Guid postId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
