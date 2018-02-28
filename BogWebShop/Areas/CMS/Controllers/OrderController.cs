using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BogWebShop.Areas.CMS.Controllers
{
    public class OrderController : Controller
    {
        // GET: CMS/Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}