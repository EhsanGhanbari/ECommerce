namespace ECommerce.Services.Reports.Messaging
{
    public class CreateReportRequest
    {
        internal ReportViewModel ReportViewModel { get; private set; }

        public CreateReportRequest(ReportViewModel reportViewModel)
        {
            ReportViewModel = reportViewModel;
        }
    }
}
