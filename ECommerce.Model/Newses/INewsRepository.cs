using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Newses
{
    public interface INewsRepository : IRepository<News, Guid>
    {
        /// <summary>
        /// returns news by date 
        /// year+ month + day 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="newsSlug"></param>
        /// <returns></returns>
        News GetNewsByDateQuery(int year, int month, int day, string newsSlug);

        /// <summary>
        /// returns All news Archived by Date
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<News> GetAllArchivedNewsByDateQuery(int year, int month);
        
        /// <summary>
        /// Get All news categories  
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        IEnumerable<NewsCategory> GetAllNewsCategoriesQuery(string categoryName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        IEnumerable<NewsTag> GetAllNewsTagsQuery(string tagName);
    }
}
