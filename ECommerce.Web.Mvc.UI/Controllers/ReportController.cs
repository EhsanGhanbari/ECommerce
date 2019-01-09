using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Reports;
using ECommerce.Services.Reports.Messaging;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class ReportController : BaseController
    {
        private readonly IReportService _reportService;

        public ReportController(ICookieStorageService cookieStorageService,IReportService reportService) 
            : base(cookieStorageService)
        {
            _reportService = reportService;
        }


        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// List of News Reports made by Members
        /// it contains EmailAddress of the Reported Member
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            var reportViewModel = new ReportViewModel();
            var request = new GetAllReportRequest(reportViewModel);
            var reports = _reportService.GetAllReports(request);
            return View("List",reports.ReportViewModels);
        }
    }
}
