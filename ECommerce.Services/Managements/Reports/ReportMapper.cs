using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Model.Management;

namespace ECommerce.Services.Reports
{
    public static class ReportMapper
    {

        /// <summary>
        /// Convert to Report ViewModel
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        public static ReportViewModel ConvertToReportViewModel(this Report report)
        {
            return Mapper.Map<Report, ReportViewModel>(report);
        }


        /// <summary>
        /// Convert to Report Model 
        /// </summary>
        /// <param name="reportViewModel"></param>
        /// <returns></returns>
        public static Report ConvertToReportModel(this ReportViewModel reportViewModel)
        {
            return Mapper.Map<ReportViewModel, Report>(reportViewModel);
        }


        /// <summary>
        /// Convert To View Model list 
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        public static IEnumerable<ReportViewModel> ConvertToReportViewModelList(this IEnumerable<Report> report)
        {
            return Mapper.Map<IEnumerable<Report>, IEnumerable<ReportViewModel>>(report);
        }
    }
}
