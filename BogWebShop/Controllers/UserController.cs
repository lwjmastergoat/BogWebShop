using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Factories;
using Repository.Models;

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
            UsersFactory uf = new UsersFactory();
            UsersTable ut = new UsersTable();
            ut = uf.LogIn(email.Trim(), password.Trim());
            Session["Rolle"] = ut.Role;
            
            return Redirect("/Home/");
        }

    } 
}