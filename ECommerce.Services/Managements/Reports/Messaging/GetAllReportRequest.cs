namespace ECommerce.Services.Reports.Messaging
{
    public class GetAllReportRequest
    {
        internal ReportViewModel ReportViewModel { get; private set; }

        public GetAllReportRequest(ReportViewModel reportViewModel)
        {
            ReportViewModel = reportViewModel;
        }
    }
}
