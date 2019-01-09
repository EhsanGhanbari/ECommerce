namespace ECommerce.Services.Reports.Messaging
{
    public class GetReportRequest
    {
        internal ReportViewModel ReportViewModel { get; private set; }

        public GetReportRequest(ReportViewModel reportViewModel)
        {
            ReportViewModel = reportViewModel;
        }
    }
}
