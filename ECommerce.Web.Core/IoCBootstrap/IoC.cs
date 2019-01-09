// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IoC.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Web.Mvc;
using ECommerce.CrossCutting.Logging;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Accounts;
using ECommerce.Model.Baskets;
using ECommerce.Model.Blogs;
using ECommerce.Model.Customers;
using ECommerce.Model.Discounts;
using ECommerce.Model.Forums;
using ECommerce.Model.Groups;
using ECommerce.Model.Languages;
using ECommerce.Model.Management;
using ECommerce.Model.Messages;
using ECommerce.Model.Newses;
using ECommerce.Model.Orders;
using ECommerce.Model.Products;
using ECommerce.Model.Shippings;
using ECommerce.Model.Stores;
using ECommerce.Repository;
using ECommerce.Services.Accounts;
using ECommerce.Services.Baskets;
using ECommerce.Services.Blogs;
using ECommerce.Services.Contract.Customers;
using ECommerce.Services.Contract.Groups;
using ECommerce.Services.Customers;
using ECommerce.Services.Discounts;
using ECommerce.Services.Forums;
using ECommerce.Services.Groups;
using ECommerce.Services.Languages;
using ECommerce.Services.Managements.Contacts;
using ECommerce.Services.Messages;
using ECommerce.Services.Newses;
using ECommerce.Services.Orders;
using ECommerce.Services.Products;
using ECommerce.Services.Reports;
using ECommerce.Services.Shippings;
using ECommerce.Services.Stores;
using StructureMap;

namespace ECommerce.Web.Core.IoCBootstrap {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });

                            //Base
                            x.For<IControllerActivator>().Use<StructureMapControllerActivator>();
                            x.For<ICookieStorageService>().Use<CookieStorageService>();
                            x.For<IUnitOfWork>().Use<UnitOfWork>();
                            x.For<ILogger>().Use<Log4NetAdapter>();

                            //Account
                            x.For<IAccountService>().Use<AccountService>();
                            x.For<IAccountRepository>().Use<AccountRepository>();

                            //Basket
                            x.For<IBasketService>().Use<BasketService>();
                            x.For<IBasketRepository>().Use<BasketRepository>();

                            //Blog
                            x.For<IBlogService>().Use<BlogService>();
                            x.For<IBlogRepository>().Use<BlogRepository>();

                            //Common
                            x.For<IContactService>().Use<ContactService>();
                            x.For<IContactRepository>().Use<ContactRepository>();

                            //Customer
                            x.For<ICustomerService>().Use<CustomerService>();
                            x.For<ICustomerRepository>().Use<CustomerRepository>();

                            //Discount
                            x.For<IDiscountService>().Use<DiscountService>();
                            x.For<IDiscountRepository>().Use<DiscountRepository>();

                            //Forum
                            x.For<IForumService>().Use<ForumService>();
                            x.For<IForumRepository>().Use<ForumRepository>();

                            //Group
                            x.For<IGroupService>().Use<GroupService>();
                            x.For<IGroupRepository>().Use<GroupRepository>();

                            //Language
                            x.For<ILanguageService>().Use<LanguageService>();
                            x.For<ILanguageRepository>().Use<LanguageRepository>();

                            //Message
                            x.For<IMessageService>().Use<MessageService>();
                            x.For<IMessageRepository>().Use<MessageRepository>();

                            //Newses
                            x.For<INewsService>().Use<NewsService>();
                            x.For<INewsRepository>().Use<NewsRepository>();

                            //Order
                            x.For<IOrderService>().Use<OrderService>();
                            x.For<IOrderRepository>().Use<OrderRepository>();

                            //product
                            x.For<IProductService>().Use<ProductService>();
                            x.For<IProductRepository>().Use<ProductRepository>();

                            //reports
                            x.For<IReportService>().Use<ReportService>();
                            x.For<IReportRepository>().Use<ReportRepository>();

                            //Shipping 
                            x.For<IShippingService>().Use<ShippingService>();
                            x.For<IShippingRepository>().Use<ShippingRepository>();

                            //Store
                            x.For<IStoreService>().Use<StoreService>();
                            x.For<IStoreRepository>().Use<StoreRepository>();
                            
                        });
            return ObjectFactory.Container;
        }
    }
}