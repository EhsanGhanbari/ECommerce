using System;
using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Newses;
using ECommerce.Services.Newses.Messaging;
using ECommerce.Services.Newses.ViewModels;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class NewsController : BaseController
    {

        #region Fields
        private readonly INewsService _newsService;
        #endregion

        #region Constructor
        public NewsController(ICookieStorageService cookieStorageService, INewsService newsService)
            : base(cookieStorageService)
        {
            _newsService = newsService;
        }

        #endregion

        #region News

        /// <summary>
        /// List of the news
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            var newsViewModel = new NewsViewModel();
            var allNewsRequest = new GetAllNewsRequest(newsViewModel);
            var news = _newsService.GetAllNews(allNewsRequest);
            return View("List", news.NewsViewModels);
        }


        /// <summary>
        /// returns the news post by Id
        /// </summary>
        /// <returns></returns>
        public ActionResult Post(Guid newsId, string newsSlug)
        {
            var newsViewModel = new NewsViewModel { NewsId = newsId };
            var request = new GetNewsRequest(newsViewModel);
            var news = _newsService.GetNews(request);
            return View(news.NewsViewModel);
        }


        /// <summary>
        /// returns the post by year + month + day + postSlug 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="postSlug"></param>
        /// <returns></returns>
        public ActionResult Post(int year, int month, int day, string postSlug)
        {
            return View();
        }



        /// <summary>
        /// Returns the post by year and month
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public ActionResult Archive(int year, int month)
        {
            return View();
        }



        /// <summary>
        /// Create news
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(NewsViewModel newsViewModel)
        {
            var createNewsRequest = new CreateNewsRequest(newsViewModel);
            if (ModelState.IsValid)
            {
                _newsService.CreateNews(createNewsRequest);
            }
            return View("Create");
        }



        /// <summary>
        /// Update News action 
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit(Guid newsId)
        {
            var newsViewModel = new NewsViewModel { NewsId = newsId };
            var getNewsRequest = new GetNewsRequest(newsViewModel);
            var news = _newsService.GetNews(getNewsRequest);
            return View("Edit", news.NewsViewModel);
        }

        [HttpPost]
        public ActionResult Edit(NewsViewModel newsViewModel)
        {
            var updateNewsRequest = new UpdateNewsRequest(newsViewModel);
            if (ModelState.IsValid)
            {
                _newsService.UpdateNews(updateNewsRequest);
            }
            return View("Edit");
        }


        /// <summary>
        /// returns all the news by tag
        /// </summary>
        /// <returns></returns>
        public ActionResult PostByTag(string tag)
        {
            //var post=_newsService.get
            return View();
        }


        /// <summary>
        /// Returns all the news by catogory
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public ActionResult PostByCategory(string category)
        {
            return View();
        }



        [HttpPost]
        public ActionResult Remove(Guid newsId)
        {
            var newsViewModel = new NewsViewModel { NewsId = newsId };
            var removeNewsRequest = new RemoveNewsRequest(newsViewModel);
            if (ModelState.IsValid)
            {
                _newsService.RemoveNews(removeNewsRequest);
            }
            return View();
        }

        #endregion


        #region NewsCategory


        /// <summary>
        /// list of news categories 
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        public PartialViewResult NewsCategories()
        {
            return PartialView();
        }


        /// <summary>
        /// remove the news 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult RemoveCategory()
        {
            return View();
        }

        #endregion



        #region NewsTags

        #endregion
    }
}
