using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Commons;

namespace ECommerce.Model.Products
{
    public class Product : EntityBase<Guid>, IAggregateRoot
    {

        #region Constructor

        private readonly string _name;
        private readonly decimal _price;
        private readonly string _shortDescription;
        private readonly string _fullDescription;
        private readonly bool _allowComment;
        private readonly ProductSize _productSize;
        private readonly ProductColor _productColor;
        private readonly ProductBrand _productBrand;
        private readonly ProductManufacturer _productManufacturer;
        private readonly IList<ProductCategory> _productCategories;
        private readonly IList<ProductTag> _productTags;
        private readonly IList<ProductPicture> _productPictures;
        private readonly ProductComment _productComments;

        public Product()
        {
        }

        public Product(ProductComment productComment)
        {
            _productComments = productComment;
        }

        public Product(
            string name,
            decimal price,
            bool allowComment,
            ProductSize productSize,
            ProductColor productColor,
            ProductBrand productBrand,
            ProductManufacturer productManufacturer,
            IEnumerable<ProductCategory> productCategory,
            IEnumerable<ProductTag> productTag,
            IEnumerable<ProductPicture> productPicture)
        {
            _name = name;
            _price = price;
            _allowComment = allowComment;
            _productSize = productSize;
            _productColor = productColor;
            _productBrand = productBrand;
            _productManufacturer = productManufacturer;
            _productCategories = new List<ProductCategory>(productCategory);
            _productTags = new List<ProductTag>(productTag);
            _productPictures = new List<ProductPicture>(productPicture);
        }

        #endregion

        #region Domain Properties

        /// <summary>
        /// Product Name
        /// </summary>
        public virtual string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Product Price
        /// </summary>
        public virtual decimal Price
        {
            get { return _price; }
        }


        /// <summary>
        /// 
        /// </summary>
        public virtual string ShortDescription
        {
            get { return _shortDescription; }
        }


        /// <summary>
        /// 
        /// </summary>
        public virtual string FullDescription
        {
            get { return _fullDescription; }
        }

        /// <summary>
        /// Product Size
        /// </summary>
        public virtual ProductSize ProductSize
        {
            get { return _productSize; }
        }

        /// <summary>
        /// Product Color
        /// </summary>
        public virtual ProductColor ProductColor
        {
            get { return _productColor; }
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime CreationTime
        {
            get;
            set;
        }

        /// <summary>
        /// Product Brand
        /// </summary>
        public virtual ProductBrand ProductBrand
        {
            get { return _productBrand; }
        }


        /// <summary>
        /// Product Manufacturer
        /// a product could be made by several manufacture
        /// </summary>
        public virtual ProductManufacturer ProductManufacturer
        {
            get { return _productManufacturer; }
        }


        /// <summary>
        /// Product Category
        /// </summary>
        public virtual IList<ProductCategory> ProductCategory
        {
            get { return _productCategories; }
        }


        /// <summary>
        /// Product tags
        /// </summary>
        public virtual IList<ProductTag> ProductTags
        {
            get { return _productTags; }
        }


        /// <summary>
        /// Product Pictures
        /// </summary>
        public virtual IList<ProductPicture> ProductPictures
        {
            get { return _productPictures; }
        }


        /// <summary>
        /// Allow Comment or Not!
        /// </summary>
        public virtual bool AllowComment
        {
            get { return _allowComment; }
        }

        #endregion

        #region Domain methods

        /// <summary>
        /// Add Product Tag
        /// </summary>
        /// <param name="productTag"></param>
        protected void AddProductTag(ProductTag productTag)
        {
            _productTags.Add(productTag);
        }

        #endregion


        public virtual decimal DiscountPrice
        {
            get { return Price; }
            set { throw new NotImplementedException(); }
        }


        protected override void Validate()
        {
            if (Name == null)
            {
                AddBrokenRule(ProductBusinnessRule.NameRequired);
            }
        }
    }
}
