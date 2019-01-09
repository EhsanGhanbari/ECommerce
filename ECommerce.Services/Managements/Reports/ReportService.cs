using System;
using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Management;
using ECommerce.Services.Reports.Messaging;

namespace ECommerce.Services.Reports
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _reportRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;


        public ReportService(IReportRepository reportRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _reportRepository = reportRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Report a user as a bad guy!
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateReportResponse CreateReport(CreateReportRequest request)
        {
            var response = new CreateReportResponse();
            var report = request.ReportViewModel.ConvertToReportModel();
            _reportRepository.Add(report);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Get All reports 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllReportResponse GetAllReports(GetAllReportRequest request)
        {
            var response = new GetAllReportResponse();
            var report = _reportRepository.GetAll();
            response.ReportViewModels = report.ConvertToReportViewModelList();
            return response;
        }


        /// <summary>
        ///  Get report detail
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetReportResponse GetReport(GetReportRequest request)
        {
            var response = new GetReportResponse();
            var report = _reportRepository.GetById(request.ReportViewModel.ReportId);
            response.ReportViewModel = report.ConvertToReportViewModel();
            return response;
        }


        /// <summary>
        /// Remove the Report 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveReportResponse RemoveReport(RemoveReportRequest request)
        {
            var response = new RemoveReportResponse();
            
           // _reportRepository.Delete();

            return response;
        }
    }
}

