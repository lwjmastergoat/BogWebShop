using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Factories;


namespace BogWebShop.Controllers
{
    public class HomeController : Controller
    {
        ProductFactory pf = new ProductFactory();
        // GET: Home
        public ActionResult Index()
        {
            return View(pf.GetAll());
        }
    }
    
}