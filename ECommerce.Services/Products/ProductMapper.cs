using System.Collections.Generic;
using System.Security.Permissions;
using AutoMapper;
using ECommerce.Model.Products;
using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products
{
    public static class ProductMapper
    {

        /// <summary>
        /// Convert to product View method
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static ProductViewModel ConvertToProductViewModel(this Product product)
        {
            return Mapper.Map<Product, ProductViewModel>(product);
        }


        /// <summary>
        /// Convert to product Model
        /// </summary>
        /// <param name="productView"></param>
        /// <returns></returns>
        public static Product ConvertToProductModel(this ProductViewModel productView)
        {
            return Mapper.Map<ProductViewModel, Product>(productView);
        }


        /// <summary>
        /// Convert to Product List View
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static IEnumerable<ProductViewModel> ConvertToProductViewModelList(this IEnumerable<Product> product)
        {
            return Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(product);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tags"></param>
        /// <returns></returns>
        public static IEnumerable<ProductTagViewModel> ConvertToProductTagViewModelList(
            this IEnumerable<ProductTag> tags)
        {
            return Mapper.Map<IEnumerable<ProductTag>, IEnumerable<ProductTagViewModel>>(tags);
        }

        /// <summary>
        /// Convert to product category 
        /// </summary>
        /// <param name="categories"></param>
        /// <returns></returns>
        public static IEnumerable<ProductCategoryViewModel> ConvertToProductCategoryViewModelList(
           this IEnumerable<ProductCategory> categories)
        {
            return Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(categories);
        }


        /// <summary>
        /// Convert to product brand view model
        /// </summary>
        /// <param name="brands"></param>
        /// <returns></returns>
        public static IEnumerable<ProductBrandViewModel> ConvertToProductBrandViewModelList(
           this IEnumerable<ProductBrand> brands)
        {
            return Mapper.Map<IEnumerable<ProductBrand>, IEnumerable<ProductBrandViewModel>>(brands);
        }

    }
}