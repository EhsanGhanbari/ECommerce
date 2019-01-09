using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Products
{
    public interface IProductRepository : IRepository<Product, Guid>
    {

        #region Product

        /// <summary>
        /// Get All products by category Query
        /// </summary>
        /// <param name="productCategoryName"></param>
        /// <returns></returns>
        IEnumerable<Product> GetAllProductsByCategoryQuery(string productCategoryName);


        /// <summary>
        /// Get all products by tag Id
        /// </summary>
        /// <param name="productTagName"></param>
        /// <returns></returns>
        IEnumerable<Product> GetAllProductsByTagQuery(string productTagName);


        /// <summary>
        /// Product by brand 
        /// </summary>
        /// <param name="productBrandName"></param>
        /// <returns></returns>
        IEnumerable<Product> GetAllProductsByBrandQuery(string productBrandName);


        /// <summary>
        ///returns all best selling products 
        /// </summary>
        /// <returns></returns>
        IEnumerable<Product> GetAllBestSellingProductsQuery(int year, int month, int day);


        /// <summary>
        /// returns all products by product manufacturer
        /// </summary>
        /// <param name="productManufacturerName"></param>
        /// <returns></returns>
        IEnumerable<Product> GetAllProductsByProductManufacturerQuery(string productManufacturerName);


        /// <summary>
        /// returns all products by product color query
        /// </summary>
        /// <param name="productColorName"></param>
        /// <returns></returns>
        IEnumerable<Product> GetAllProductsByProductColorQuery(string productColorName);


        /// <summary>
        /// returns all products by product's size
        /// </summary>
        /// <param name="productSizeName"></param>
        /// <returns></returns>
        IEnumerable<Product> GetAllProductsByProductSizeQuery(string productSizeName);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="brandName"></param>
        /// <returns></returns>
        IEnumerable<ProductBrand> GetAllProductBrandsQuery(string brandName);


        #endregion

        #region Product Tag

        /// <summary>
        /// Product tag
        /// </summary>
        /// <returns></returns>
        ProductTag GetProductTagQuery(string productTag);

        /// <summary>
        /// returns all product tags in the system
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductTag> GetAllProductTagsQuery();


        #endregion

        #region Prooduct category


        /// <summary>
        /// product category
        /// </summary>
        /// <param name="productCategory"></param>
        /// <returns></returns>
        ProductCategory GetProductCategoryQuery(string productCategory);


        /// <summary>
        /// Get all product Categores in the system 
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductCategory> GetAllProductCategoriesQuery();

        #endregion

        #region Product Brand

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productBrand"></param>
        /// <returns></returns>
        ProductBrand GetProductBrandQuery(string productBrand);

        /// <summary>
        /// returns all product brands in the system
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductBrand> GetAllProductBrandsQuery();


        #endregion

    }
}
