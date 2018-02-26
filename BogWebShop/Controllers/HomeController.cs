using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BogWebShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
    public ActionResult _footer()
    {
        FooterFactory footerFac = new FooterFactory();

        Footer footer = footerFac.GetAll();

        return PartialView(footer);
    }

    public ActionResult _header()
    {
        return PartialView();
    }
}