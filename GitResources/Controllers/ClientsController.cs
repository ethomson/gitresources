using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GitResources.Controllers
{
    [AllowAnonymous]
    public class ClientsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
