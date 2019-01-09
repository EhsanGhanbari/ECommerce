using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Customers;

namespace ECommerce.Services.Customers
{
    public static class CustomerMapper
    {
        /// <summary>
        /// Convert to Customer View Model
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static CustomerViewModel ConvertToCustomerViewModel(this Customer customer)
        {
            Mapper.CreateMap<Customer, CustomerViewModel>()
                  .ForMember(cus => cus.CustomerId, cu => cu.MapFrom(c => c.Id));
            return Mapper.Map<Customer, CustomerViewModel>(customer);
        }


        /// <summary>
        /// Converet to Customer Model
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static Customer ConvertToCustmerModel(this CustomerViewModel customer)
        {
            return Mapper.Map<CustomerViewModel, Customer>(customer);
        }


        /// <summary>
        /// Convert to Customer View Model List
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static IEnumerable<CustomerViewModel> ConvertToCustomerViewModelList(this IEnumerable<Customer> customer)
        {
            Mapper.CreateMap<Customer, CustomerViewModel>()
                 .ForMember(cus => cus.CustomerId, cu => cu.MapFrom(c => c.Id));
            return Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(customer);
        }

    }
}
