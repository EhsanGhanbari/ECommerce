using System;
using System.Collections.Generic;
using ECommerce.Model.Media;

namespace ECommerce.Model.Products
{
    public class ProductPicture : Picture
    {
        
        private readonly IList<ProductPicture> _productPictures;

        public ProductPicture(IEnumerable<ProductPicture> productPictures)
        {
            _productPictures = new List<ProductPicture>(productPictures);
        }


        public IList<ProductPicture> ProductPictures
        {
            get { return _productPictures; }
        }


        public int DisplayOrder
        {
            get; set;
        }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }

}
