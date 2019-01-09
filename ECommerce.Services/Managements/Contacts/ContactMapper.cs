using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Management;
using ECommerce.Services.Contacts;

namespace ECommerce.Services.Managements.Contacts
{
    public static class ContactMapper
    {

        /// <summary>
        /// Convert Cotact to ContactViewModel
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public static ContactViewModel ConvertToContactViewModel(this Contact contact)
        {
            return Mapper.Map<Contact, ContactViewModel>(contact);
        }


        /// <summary>
        /// Convert ContactVeiwModel to Contact
        /// </summary>
        /// <param name="contactViewModel"></param>
        /// <returns></returns>
        public static Contact ConvertToContactModel(this ContactViewModel contactViewModel)
        {
            Mapper.CreateMap<ContactViewModel, Contact>()
                  .ForMember(con => con.Id, co => co.MapFrom(c => c.ContactId));
            return Mapper.Map<ContactViewModel, Contact>(contactViewModel);
        }


        /// <summary>
        /// Convert to ContactViewList
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public static IEnumerable<ContactViewModel> ConvertToContactViewModelList(this IEnumerable<Contact> contact)
        {
            return Mapper.Map<IEnumerable<Contact>, IEnumerable<ContactViewModel>>(contact);
        }


    }
}
