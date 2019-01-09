using System;
using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Vendors;
using ECommerce.Services.Vendors.Messaging;

namespace ECommerce.Services.Vendors
{
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository _vendorRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public VendorService(IVendorRepository vendorRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _vendorRepository = vendorRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Create 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateVendorResponse CreateVendor(CreateVendorRequest request)
        {
            var response = new CreateVendorResponse();
            var vendor = request.VendorViewModel.ConvertToVendorModel();
            _vendorRepository.Add(vendor);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Returns all vendors of a ??
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllVendorsResponse GetAllVendors(GetAllVendorsRequest request)
        {
            var response = new GetAllVendorsResponse();
            var vendors = _vendorRepository.GetAll();
            response.VendorViewModels = vendors.ConvertToVendorViewModelList();
            return response;
        }

        /// <summary>
        /// Get vendor
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetVendorResponse GetVendor(GetVendorRequest request)
        {
            var response = new GetVendorResponse();
            var vendor = _vendorRepository.GetById(request.VendorViewModel.VendorId);
            response.VendorViewModel = vendor.ConvertToVendorViewModel();
            return response;
        }


        /// <summary>
        /// Remove vendor
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveVendorResponse RemoveVendor(RemoveVendorRequest request)
        {
            var response = new RemoveVendorResponse();
            var vendor = request.VendorViewModel.ConvertToVendorModel();
            _vendorRepository.Remove(vendor);
            _unitOfWork.Commit();
            return response;
        }



        /// <summary>
        /// Update the vendor
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateVendorResponse UpdateVendor(UpdateVendorRequest request)
        {
            var response = new UpdateVendorResponse();
            var vendor = request.VendorViewModel.ConvertToVendorModel();
            _vendorRepository.SaveOrUpdate(vendor);
            _unitOfWork.Commit();
            return response;
        }
    }
}
