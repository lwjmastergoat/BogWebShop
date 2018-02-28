using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Factories;
using BogWebShop.ViewModels;
using Repository.Models;

namespace BogWebShop.Areas.CMS.Controllers
{
    public class OrderController : Controller
    {

        ProductFactory pf = new ProductFactory();
        OrderFactory of = new OrderFactory();
        OrderDetailsFactory odf = new OrderDetailsFactory();
        OrderFactory ofac = new OrderFactory();
        // GET: CMS/Order
        public ActionResult Index()
        {


            return View(ofac.GetAllJoined());
        }

        public ActionResult Details(int ID)
        {


            
            return View(odf.GetByOrderID(ID));
        }
    }
}