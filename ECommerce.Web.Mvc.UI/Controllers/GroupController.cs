using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class GroupController : BaseController
    {
        public GroupController(ICookieStorageService cookieStorageService)
            : base(cookieStorageService)
        {
        }
    }
}
