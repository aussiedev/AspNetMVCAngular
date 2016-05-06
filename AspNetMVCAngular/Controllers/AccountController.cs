﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCAngular.Controllers
{
    
        [Authorize]
        public class AccountController : Controller
        {
            [AllowAnonymous]
            public ActionResult Login()
            {
                return View();
            }
        }
    
}