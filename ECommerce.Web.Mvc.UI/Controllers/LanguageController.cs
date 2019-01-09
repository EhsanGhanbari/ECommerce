using System;
using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Languages;
using ECommerce.Services.Languages.Messaging;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class LanguageController : BaseController
    {
        private readonly ILanguageService _languageService;

        public LanguageController(ICookieStorageService cookieStorageService, ILanguageService languageService)
            : base(cookieStorageService)
        {
            _languageService = languageService;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// Returns the list of all languages in the system
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            var languageViewModel = new LanguageViewModel();
            var request = new GetAllLanguageRequest(languageViewModel);
            var languages = _languageService.GetAllLangauge(request);
            return View("List", languages.LanguageViewModels);
        }


        /// <summary>
        /// Adds a langaue to the system 
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(LanguageViewModel languageViewModel)
        {
            var request = new CreateLanguageRequest(languageViewModel);

            if (ModelState.IsValid)
            {
                _languageService.CreateLanguage(request);
            }
            return View("Create");
        }



        /// <summary>
        /// Updates the languages details
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit(Guid languageId)
        {
            var languageViewModel = new LanguageViewModel {LanguageId = languageId};
            var request = new GetLanguageRequest(languageViewModel);
            var language = _languageService.GetLanguage(request);
            return View("Edit", language);
        }

        [HttpPost]
        public ActionResult Edit(LanguageViewModel languageViewModel)
        {
            var request=new UpdateLanguageRequest(languageViewModel);
            if (ModelState.IsValid)
            {
                _languageService.UpdateLanguage(request);
            }
            return View("Edit");
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Remove()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Remove(LanguageViewModel languageViewModel)
        {
            return View();
        }
    }
}
