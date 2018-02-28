using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Repository.Factories;
using Repository.Models;
namespace BogWebShop.Controllers
{
    public class CartController : Controller
    {
        OrderFactory OF = new OrderFactory();
        OrderDetailsFactory ODF = new OrderDetailsFactory();

        // GET: Cart
        public ActionResult Index()
        {
            if (Session["UserID"] == null)
                return Redirect("/User/Index");
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(string Cart)
        {
            if (Session["UserID"] == null)
                return Redirect("/User/Index");
            try
            {
                JObject cart = JObject.Parse(Cart);

                int orderId = OF.Insert(new OrderTable
                {
                    Date = DateTime.Now,
                    UsersID = int.Parse(Session["UserID"].ToString())
                });
                List<OrderDetailsTable> ODL = new List<OrderDetailsTable>();
                foreach (var p in cart) {
                    int id = int.Parse(p.Key);
                    int amount = int.Parse(p.Value.ToString());
                    ODL.Add(new OrderDetailsTable {
                        OrderID = orderId,
                        ProductsID = id,
                        Quantity = amount
                    });
                }

                foreach(OrderDetailsTable odl in ODL)
                    ODF.Insert(odl);

                ViewBag.msg = "Din ordre er sendt";
                return View();
            }
            catch {
                ViewBag.msg = "Der skete en fejl under dit køb prøv igen sener";
                return View();
            }
        }
    }
}