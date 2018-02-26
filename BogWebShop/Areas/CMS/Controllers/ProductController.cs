using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BogWebShop.Areas.CMS.Controllers
{
    public class ProductController : Controller
    {

        int Admin = 2;
        int Editor = 1;
        // GET: CMS/Product
        public ActionResult Index()
        {
            return View();
        }
    }
}