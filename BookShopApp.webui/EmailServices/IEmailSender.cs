﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopApp.webui.EmailServices
{
     public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);

    }
}
