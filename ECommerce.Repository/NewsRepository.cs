using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Newses;
using ECommerce.Repository.SessionStorage;

namespace ECommerce.Repository
{
    public class NewsRepository : Repository<News, Guid>, INewsRepository
    {
        public NewsRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }


        /// <summary>
        /// returns news by date
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="newsSlug"></param>
        /// <returns></returns>
        public News GetNewsByDateQuery(int year, int month, int day, string newsSlug)
        {

            var query =
                SessionFactory.GetCurrentSession()
                              .QueryOver<News>()
                              .Where(
                                  b =>
                                  b.CreationTime.Year == year && b.CreationTime.Month == month &&
                                  b.CreationTime.Day == day && b.NewsSlug == newsSlug).SingleOrDefault();
            return query;
        }



        /// <summary>
        /// returns news archive
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<News> GetAllArchivedNewsByDateQuery(int year, int month)
        {
            var query =
                SessionFactory.GetCurrentSession()
                              .QueryOver<News>()
                              .Where(
                                  b =>
                                  b.CreationTime.Year == year && b.CreationTime.Month == month).List();
                               
            return query;

        }
       
        
        /// <summary>
        /// Get all news category
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public IEnumerable<NewsCategory> GetAllNewsCategoriesQuery(string tagName)
        {
            //SessionFactory.GetCurrentSession().QueryOver<NewsCategory>();

            throw new NotImplementedException();
        }


        /// <summary>
        /// get all news tag
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public IEnumerable<NewsTag> GetAllNewsTagsQuery(string tagName)
        {
            throw new NotImplementedException();
        }
    }
}
