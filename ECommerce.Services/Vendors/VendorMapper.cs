using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Model.Vendors;

namespace ECommerce.Services.Vendors
{
    public static class VendorMapper
    {

        /// <summary>
        /// Convert To Vendor View Model
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        public static VendorViewModel ConvertToVendorViewModel(this Vendor vendor)
        {
            return Mapper.Map<Vendor, VendorViewModel>(vendor);
        }


        /// <summary>
        /// Convert to vendor view model
        /// </summary>
        /// <param name="vendorViewModel"></param>
        /// <returns></returns>
        public static Vendor ConvertToVendorModel(this VendorViewModel vendorViewModel)
        {
            return Mapper.Map<VendorViewModel, Vendor>(vendorViewModel);
        }


        /// <summary>
        /// Convert To vendor view model list
        /// </summary>
        /// <param name="vendors"></param>
        /// <returns></returns>
        public static IEnumerable<VendorViewModel> ConvertToVendorViewModelList(this IEnumerable<Vendor> vendors)
        {
            return Mapper.Map<IEnumerable<Vendor>, IEnumerable<VendorViewModel>>(vendors);
        }

    }
}
