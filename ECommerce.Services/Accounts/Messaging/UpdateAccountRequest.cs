﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Services.Accounts.ViewModel;

namespace ECommerce.Services.Accounts.Messaging
{
    public class UpdateAccountRequest
    {
        internal AccountViewModel AccountViewModel { get; private set; }

        public UpdateAccountRequest(AccountViewModel accountViewModel)
        {
            AccountViewModel = accountViewModel;
        }
    }
}
