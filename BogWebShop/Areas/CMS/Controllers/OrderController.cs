using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Factories;

namespace BogWebShop.Areas.CMS.Controllers
{
    public class OrderController : Controller
    {
        OrderFactory ofac = new OrderFactory();
        // GET: CMS/Order
        public ActionResult Index()
        {


            return View(ofac.GetAllJoined());
        }
    }
}