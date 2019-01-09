using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Accounts;
using ECommerce.Services.Accounts.ViewModel;

namespace ECommerce.Services.Accounts
{
    public static class AccountMapper
    {

        /// <summary>
        /// Convert Register to View Model
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static RegisterViewModel ConvertToRegisterViewModel(this Account account)
        {
            return Mapper.Map<Account, RegisterViewModel>(account);
        }

        /// <summary>
        /// User in the 
        /// </summary>
        /// <param name="registerViewModel"></param>
        /// <returns></returns>
        public static Account ConvertToAccoutFromRegisterViewModel(this RegisterViewModel registerViewModel)
        {
            return Mapper.Map<RegisterViewModel, Account>(registerViewModel);
        }




        /// <summary>
        /// Convert the AccountViewModel to Model
        /// </summary>
        /// <param name="accountViewModel"></param>
        /// <returns></returns>
        public static Account ConvertToAccount(this AccountViewModel accountViewModel)
        {
            return Mapper.Map<AccountViewModel, Account>(accountViewModel);
        }

        /// <summary>
        /// Convert to AccountViewModel Method
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static AccountViewModel ConvertToAccountViewModel(this Account account)
        {
            return Mapper.Map<Account, AccountViewModel>(account);
        }


        /// <summary>
        /// returns all account of the system
        /// </summary>
        /// <param name="accounts"></param>
        /// <returns></returns>
        public static IEnumerable<AccountViewModel> ConvertToAccountViewModelList(this IEnumerable<Account> accounts)
        {
            return Mapper.Map<IEnumerable<Account>, IEnumerable<AccountViewModel>>(accounts);
        }





    }
}
