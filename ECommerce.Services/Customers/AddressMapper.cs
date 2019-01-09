using AutoMapper;

namespace ECommerce.Services.Customers
{
    public static class AddressMapper
    {
        public static AddressViewModel ConvertToAddressView(this Model.Customers.Address address)
        {
            return Mapper.Map<Model.Customers.Address, AddressViewModel>(address);
        }


        public static Model.Customers.Address ConvertToAddressModel(this AddressViewModel addressView)
        {
            return Mapper.Map<AddressViewModel, Model.Customers.Address>(addressView);
        }
    }
}
