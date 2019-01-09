using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Stores;

namespace ECommerce.Services.Stores
{
    public static class StoreMapper
    {
        /// <summary>
        /// Convert to Store ViewModel method 
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public static StoreViewModel ConvertToStoreViewModel(this Store store)
        {
            return Mapper.Map<Store, StoreViewModel>(store);
        }

        /// <summary>
        /// Convert to Store Model
        /// </summary>
        /// <param name="storeView"></param>
        /// <returns></returns>
        public static Store ConvertToStoreModel(this StoreViewModel storeView)
        {
            return Mapper.Map<StoreViewModel, Store>(storeView);
        }


        /// <summary>
        /// Convert to Store View Model List
        /// </summary>
        /// <param name="stores"></param>
        /// <returns></returns>
        public static IEnumerable<StoreViewModel> ConvertToStoreViewModelList(this IEnumerable<Store> stores )
        {
            return Mapper.Map<IEnumerable<Store>, IEnumerable<StoreViewModel>>(stores);
        }
    }

}
