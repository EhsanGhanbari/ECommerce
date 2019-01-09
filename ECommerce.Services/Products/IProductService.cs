using ECommerce.Services.Products.Messaging;

namespace ECommerce.Services.Products
{
    public interface IProductService
    {

        #region Product

        /// <summary>
        /// Create Product 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateProductResponse CreateProduct(CreateProductRequest request);


        /// <summary>
        /// returns all best selling products of the last week 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllBestSellingProductsResponse GetAllBestSellingProducts(GetAllBestSellingProductsRequest request);



        /// <summary>
        /// Get Product by Id 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetProductResponse GetProduct(GetProductRequest request);

        /// <summary>
        /// Get All Products 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllProductResponse GetAllProducts(GetAllProductRequest request);


        /// <summary>
        ///  Get All Products by Category 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllProductsByCategoryResponse GetAllProductsByCategory(GetAllProductsByCategoryRequest request);



        /// <summary>
        /// Returns All Products by brand
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllProductsByBrandResponse GetAllProductsByBrand(GetAllProductsByBrandRequest request);

        /// <summary>
        /// Remove Product by Id 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveProductResponse RemoveProduct(RemoveProductRequest request);


        /// <summary>
        /// Update Product Content
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateProductResponse UpdateProduct(UpdateProductRequest request);


        /// <summary>
        /// Get All Products by tagId
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllProductsByTagResponse GetAllProductsByTag(GetAllProductsByTagRequest request);
        #endregion

        #region ProductTag
       
        /// <summary>
        /// Get all product tag
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllProductTagResponse GetAllProductTags(GetAllProductTagRequest request);


        /// <summary>
        /// Remove product tag
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveProductTagResponse RemoveProductTag(RemoveProductTagRequest request);
            

        #endregion

        #region ProductCategory

        /// <summary>
        /// Get all product categories
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllProductCategoriesResponse GetAllProductCategories(GetAllProductCategoriesRequest request);


        /// <summary>
        /// Remove product cateogry
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveProductCategoryResponse RemoveProductCategory(RemoveProductCategoryRequest request);
        #endregion

        #region ProductBrand

        /// <summary>
        /// Remove product brand
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveProductBrandResponse RemoveProductBrand(RemoveProductBrandRequest request);

        /// <summary>
        /// Get All Product Brand
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllProductBrandsResponse GetAllProductBrands(GetAllProductBrandsRequest request);



        #endregion

        #region ProductCatalog

        #endregion

        #region ProductComment

        #endregion

    }
}
