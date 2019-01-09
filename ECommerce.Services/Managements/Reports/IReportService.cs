using ECommerce.Services.Reports.Messaging;

namespace ECommerce.Services.Reports
{
    public interface IReportService
    {
        /// <summary>
        /// Create Report by Members
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateReportResponse CreateReport(CreateReportRequest request);


        /// <summary>
        /// Get All Reports by Admin/Master
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllReportResponse GetAllReports(GetAllReportRequest request);


        /// <summary>
        /// Get Report by Detail 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetReportResponse GetReport(GetReportRequest request);


        /// <summary>
        /// Remove Report 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveReportResponse RemoveReport(RemoveReportRequest request);

    }
}
