using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BogWebShop.Areas.CMS.Controllers
{
    public class HomeController : Controller
    {

        int Admin = 2;
        int Writer = 1;
        // GET: CMS/Home
        public ActionResult Index()
        {

            if (Session["role"] == null || (int)Session["role"] < Writer)
            {
                return Redirect("/Login");
            }
            return View();
        }
    }
}