using System;
using FluentValidation.Attributes;

namespace ECommerce.Services.Reports
{
    [Validator(typeof(ReportValidation))]
    public class ReportViewModel
    {
        public Guid ReportId { get; set; }

        public string ReportedAccount { get; set; }

        public string ReporterAccount { get; set; }

        public string Description { get; set; }

    }
}
