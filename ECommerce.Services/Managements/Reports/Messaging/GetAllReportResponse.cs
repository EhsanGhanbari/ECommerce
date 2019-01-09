using System.Collections.Generic;



namespace ECommerce.Services.Reports.Messaging
{
    public class GetAllReportResponse :BaseResponse
    {
        public IEnumerable<ReportViewModel> ReportViewModels { get; set; } 
    }
}
