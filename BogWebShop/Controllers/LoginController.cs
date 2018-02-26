using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Factories;
using Repository.Models;

namespace BogWebShop.Controllers
{
    public class LoginController : Controller
    {
        AdminFactory af = new AdminFactory();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Username, string Password)
        {
            AdminTable user = af.Login(Username, Password);

            if (user.Username != null)
            {
                Session["id"] = user.ID;
                Session["role"] = user.Role;
                return Redirect("/CMS/");
            }
            else
            {
                ViewBag.Msg = "<b>Forkert login</b>";
                return View();
            }
        }

        public ActionResult Logout()
        {
            Session.Remove("id");
            Session.Remove("role");
            return Redirect("/Home/Index/");
        }
    }
}