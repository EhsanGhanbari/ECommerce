using AutoMapper;
using ECommerce.Model.Affiliates;
using ECommerce.Model.Baskets;
using ECommerce.Model.Blogs;
using ECommerce.Model.Commons;
using ECommerce.Model.Customers;
using ECommerce.Model.Discounts;
using ECommerce.Model.Forums;
using ECommerce.Model.Languages;
using ECommerce.Model.Management;
using ECommerce.Model.Messages;
using ECommerce.Model.Newses;
using ECommerce.Model.Orders;
using ECommerce.Model.Payments;
using ECommerce.Model.Products;
using ECommerce.Model.Shippings;
using ECommerce.Model.Stores;
using ECommerce.Services.Affiliates;
using ECommerce.Services.Baskets;
using ECommerce.Services.Blogs;
using ECommerce.Services.Blogs.ViewModels;
using ECommerce.Services.Contacts;
using ECommerce.Services.Customers;
using ECommerce.Services.Discounts;
using ECommerce.Services.Forums;
using ECommerce.Services.Languages;
using ECommerce.Services.Messages;
using ECommerce.Services.Newses;
using ECommerce.Services.Newses.ViewModels;
using ECommerce.Services.Orders;
using ECommerce.Services.Payments;
using ECommerce.Services.Products.VeiwModels;
using ECommerce.Services.Reports;
using ECommerce.Services.Shippings;
using ECommerce.Services.Stores;


namespace ECommerce.Services
{
    /// <summary>
    /// Define a mapping between domain entities and ViewModel
    /// </summary>
    public class AutoMapperBootStrapper
    {
        public static void ConfigureAutoMapper()
        {

            //Affilite
            Mapper.CreateMap<Affiliate, AffiliateViewModel>();
            Mapper.CreateMap<AffiliateViewModel, Affiliate>();


            //Basket
            Mapper.CreateMap<Basket, BasketViewModel>();
            Mapper.CreateMap<BasketViewModel, Basket>();

            //Blog
            Mapper.CreateMap<Blog, BlogViewModel>();
            Mapper.CreateMap<BlogViewModel, Blog>();


            //Contact
            Mapper.CreateMap<Contact, ContactViewModel>();
            Mapper.CreateMap<ContactViewModel, Contact>();


            //Customer
            Mapper.CreateMap<Customer, CustomerViewModel>();
            Mapper.CreateMap<CustomerViewModel, Customer>();


            //Discount
            Mapper.CreateMap<Discount, DiscountViewModel>();
            Mapper.CreateMap<DiscountViewModel, Discount>();


            //Forum 
            Mapper.CreateMap<Forum, ForumViewModel>();
            Mapper.CreateMap<ForumViewModel, Forum>();

            //Language
            Mapper.CreateMap<Language, LanguageViewModel>();
            Mapper.CreateMap<LanguageViewModel, Language>();


            //Message
            Mapper.CreateMap<Message, MessageViewModel>();
            Mapper.CreateMap<MessageViewModel, Message>();


            //News
            Mapper.CreateMap<News, NewsViewModel>();
            Mapper.CreateMap<NewsViewModel, News>();

            
            //Order
            Mapper.CreateMap<Order, OrderViewModel>();
            Mapper.CreateMap<OrderViewModel, Order>();


            //Payment
            Mapper.CreateMap<Payment, PaymentViewModel>();
            Mapper.CreateMap<PaymentViewModel, Payment>();


            //Product 
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<ProductViewModel, Product>();


            //Report
            Mapper.CreateMap<Report, ReportViewModel>();
            Mapper.CreateMap<ReportViewModel, Report>();


            //Shipping
            Mapper.CreateMap<Shipping, ShippingViewModel>();
            Mapper.CreateMap<ShippingViewModel, Shipping>();

          
            //Store
            Mapper.CreateMap<Store, StoreViewModel>();
            Mapper.CreateMap<StoreViewModel, Store>();

            //Votes
            Mapper.CreateMap<Store, StoreViewModel>();
            Mapper.CreateMap<StoreViewModel, Store>();
        
        }
    }
}
