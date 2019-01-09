using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Model.Taxes;

namespace ECommerce.Services.Taxes
{
    public static class TaxMapper
    {
        /// <summary>
        /// Convert to Tax View Model
        /// </summary>
        /// <param name="tax"></param>
        /// <returns></returns>
        public static TaxViewModel ConvertToTaxViewModel(this Tax tax)
        {
            return Mapper.Map<Tax, TaxViewModel>(tax);
        }


        /// <summary>
        /// Convert to taxViewModel
        /// </summary>
        /// <param name="taxViewModel"></param>
        /// <returns></returns>
        public static Tax ConvertToTaxModel(this TaxViewModel taxViewModel)
        {
            return Mapper.Map<TaxViewModel, Tax>(taxViewModel);
        }


        /// <summary>
        /// Converts to TaxViewModel list
        /// </summary>
        /// <param name="taxs"></param>
        /// <returns></returns>
        public static IEnumerable<TaxViewModel> ConvertToTaxViewModelList(this IEnumerable<Tax> taxs)
        {
            return Mapper.Map<IEnumerable<Tax>, IEnumerable<TaxViewModel>>(taxs);
        }
    }
}
