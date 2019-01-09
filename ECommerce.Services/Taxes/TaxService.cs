using System;
using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Taxes;
using ECommerce.Services.Taxes.Messaging;

namespace ECommerce.Services.Taxes
{
    public class TaxService : ITaxService
    {
        private readonly ITaxRepository _taxRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;


        public TaxService(ITaxRepository taxRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _taxRepository = taxRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Creates a tax method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateTaxResponse CreateTax(CreateTaxRequest request)
        {
            var response = new CreateTaxResponse();
            var tax = request.TaxViewModel.ConvertToTaxModel();
            _taxRepository.Add(tax);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Returns all tax defined
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllTaxesResponse GetAllTaxes(GetAllTaxesRequest request)
        {
            var response = new GetAllTaxesResponse();
            var taxes = _taxRepository.GetAll();
            var taxViewModel = taxes.ConvertToTaxViewModelList();
            response.TaxViewModels = taxViewModel;
            return response;
        }


        /// <summary>
        /// Get a tax details
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetTaxResponse GetTax(GetTaxRequest request)
        {
            var response = new GetTaxResponse();
            var tax = _taxRepository.GetById(request.TaxViewModel.TaxId);
            var taxViewModel = tax.ConvertToTaxViewModel();
            response.TaxViewModel = taxViewModel;
            return response;
        }


        /// <summary>
        /// Removes the tax
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveTaxResponse RemoveTax(RemoveTaxRequest request)
        {
            var response = new RemoveTaxResponse();
            var tax = _taxRepository.GetById(request.TaxViewModel.TaxId);
            _taxRepository.Remove(tax);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Update the tax
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateTaxResponse UpdateTax(UpdateTaxRequest request)
        {
            var response = new UpdateTaxResponse();
            var tax = request.TaxViewModel.ConvertToTaxModel();
            _taxRepository.SaveOrUpdate(tax);
            _unitOfWork.Commit();
            return response;
        }
    }
}
