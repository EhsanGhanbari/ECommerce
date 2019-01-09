
using ECommerce.Services.Accounts.Messaging;

namespace ECommerce.Services.Accounts
{
    public interface IAccountService
    {

        /// <summary>
        /// Create Account Service
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateAccountResponse CreateAccount(CreateAccountRequest request);

        /// <summary>
        /// Get Account details by Id 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAccountResponse GetAccount(GetAccountRequest request);


        /// <summary>
        /// Get All Accounts of the System 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllAccountResponse GetAllAccount(GetAllAccountRequest request);


        /// <summary>
        /// Remove an Account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveAccountResponse RemoveAccount(RemoveAccountRequest request);


        /// <summary>
        /// change password 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        ChangePasswordResponse ChangePassword(ChangePasswordRequest request);


        /// <summary>
        /// Update account 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateAccountResponse UpdateAccount(UpdateAccountRequest request);
    }
}
