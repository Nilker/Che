﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Che.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CheControllerBase
    {
        public ActionResult Index()
        {
            //return View("~/BeyondAdmin/Index.cshtml");
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}