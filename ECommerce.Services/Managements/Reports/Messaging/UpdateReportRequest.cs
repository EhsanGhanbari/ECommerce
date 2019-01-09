namespace ECommerce.Services.Reports.Messaging
{
    public class UpdateReportRequest
    {
        internal ReportViewModel ReportViewModel { get; set; }

        public UpdateReportRequest(ReportViewModel reportViewModel)
        {
            ReportViewModel = reportViewModel;
        }
    }
}
