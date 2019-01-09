using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.CrossCutting.StorageService;

namespace ECommerce.Web.Core.Controllers
{
    public class BaseAccountController : BaseController
    {
        public BaseAccountController(ICookieStorageService cookieStorageService)
            : base(cookieStorageService)
        {

        }
    }
}
