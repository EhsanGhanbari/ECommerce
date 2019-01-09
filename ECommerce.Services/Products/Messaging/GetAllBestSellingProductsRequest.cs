using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class GetAllBestSellingProductsRequest
    {
        internal ProductViewModel ProductViewModel { get; private set; }

        public GetAllBestSellingProductsRequest(ProductViewModel productViewModel)
        {
            ProductViewModel = productViewModel;
        }


        /// <summary>
        /// best seller product by year
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// best seller ny month
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// best sellet by day
        /// </summary>
        public int Day { get; set; }
    }
}
