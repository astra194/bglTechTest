using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bglTechTest.Web.Controllers
{
    public partial class HomeController : ControllerBase
    {
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}