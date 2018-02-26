using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BogWebShop.Controllers
{
    public class UserController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string email, string password)
        {

            return Redirect("/Home/");
        }

    }
}