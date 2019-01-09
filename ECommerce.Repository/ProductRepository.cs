using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Products;
using ECommerce.Repository.SessionStorage;

namespace ECommerce.Repository
{
    public class ProductRepository : Repository<Product, Guid>, IProductRepository
    {
        public ProductRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #region Product

        public IEnumerable<Product> GetAllProductsByCategoryQuery(string productCategoryName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProductsByTagQuery(string productTagName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// returns all products by brand name
        /// </summary>
        /// <param name="brandName"></param>
        /// <returns></returns>
        public IEnumerable<Product> GetAllProductsByBrandQuery(string brandName)
        {
            var query =
                SessionFactory.GetCurrentSession()
                              .QueryOver<Product>()
                              .Where(p => p.ProductBrand.Name == brandName);
            return query.List();
        }

        public IEnumerable<Product> GetAllBestSellingProductsQuery(int year, int month, int day)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProductsByProductManufacturerQuery(string productManufacturerName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProductsByProductColorQuery(string productColorName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProductsByProductSizeQuery(string productSizeName)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Product Tag

        public ProductTag GetProductTagQuery(string productTag)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<ProductTag> GetAllProductTagsQuery()
        {
            throw new NotImplementedException();
        }


        #endregion

        #region Product Category

        public ProductCategory GetProductCategoryQuery(string productCategory)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductCategory> GetAllProductCategoriesQuery()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Product Brand

        public IEnumerable<ProductBrand> GetAllProductBrandsQuery()
        {
            throw new NotImplementedException();
        }

        public ProductBrand GetProductBrandQuery(string productBrand)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<ProductBrand> GetAllProductBrandsQuery(string brandName)
        {
            throw new NotImplementedException();
        }


        #endregion

    }
}
