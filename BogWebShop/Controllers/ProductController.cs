using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Factories;

namespace BogWebShop.Controllers
{
    public class ProductController : Controller
    {
        ProductFactory pf = new ProductFactory();
        
        // GET: Product
        public ActionResult Index()
        {
            
            return View();
        }
    }
}