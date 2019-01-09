namespace ECommerce.Services.Reports.Messaging
{
    public class RemoveReportRequest 
    {
        internal ReportViewModel ReportViewModel { get; private set; }

        public RemoveReportRequest(ReportViewModel reportViewModel)
        {
            ReportViewModel = reportViewModel;
        }
    }
}
