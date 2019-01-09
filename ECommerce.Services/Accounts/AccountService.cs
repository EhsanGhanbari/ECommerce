using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Accounts;
using ECommerce.Services.Accounts.Messaging;

namespace ECommerce.Services.Accounts
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public AccountService(IAccountRepository accountRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _accountRepository = accountRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Create account service class
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateAccountResponse CreateAccount(CreateAccountRequest request)
        {
            var response = new CreateAccountResponse();
            var account = response.AccountViewModel.ConvertToAccount();
            _accountRepository.Add(account);
            _unitOfWork.Commit();
            return response;
        }



        /// <summary>
        /// Get account details to show the user
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAccountResponse GetAccount(GetAccountRequest request)
        {
            var response = new GetAccountResponse();
            var account = _accountRepository.GetById(request.AccountId);
            response.AccountViewModel = account.ConvertToAccountViewModel();
            return response;
        }



        /// <summary>
        /// GetAll accounts of the system 
        /// Returns 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllAccountResponse GetAllAccount(GetAllAccountRequest request)
        {
            var response = new GetAllAccountResponse();
            var account = _accountRepository.GetAll();
            response.AccountViewModels = account.ConvertToAccountViewModelList();
            return response;
        }


        /// <summary>
        /// remove an account by Admin
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveAccountResponse RemoveAccount(RemoveAccountRequest request)
        {
            var response = new RemoveAccountResponse();
            var account = new Account { Id = request.UserId };
            _accountRepository.Remove(account);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// change password by user(admin or user of the system)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            var response = new ChangePasswordResponse();
            var account = new Account { Id = request.UserId };
            _accountRepository.SaveOrUpdate(account);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateAccountResponse UpdateAccount(UpdateAccountRequest request)
        {
            var response = new UpdateAccountResponse();

            return response;
        }
    }

}
