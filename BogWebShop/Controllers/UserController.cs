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
        UsersFactory uf = new UsersFactory();
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string email, string password)
        {
            
            UsersTable ut = new UsersTable();
            ut = uf.LogIn(email.Trim(), password.Trim());
            Session["UserID"] = ut.ID;
            Session["Rolle"] = ut.Role;
            
            return Redirect("/Home/");
        }
        public ActionResult LogOut()
        {


            Session.Remove("UserID");
            Session.Remove("Rolle");

            return Redirect("/Home/");
        }

        public ActionResult UserPanel(int id)
        {
            
            return View(uf.Get(id));
        }
        public ActionResult EditUser(int id)
        {
            
            return View(uf.Get(id));
        }
        [HttpPost]
        public ActionResult EditUser(UsersTable input)
        {
            uf.Update(input);
            return Redirect("/Users/UserPanel/");
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNew(UsersTable input)
        {
            input.Role = 1;
            uf.Insert(input);
            return Redirect("/Users/");
        }

    } 
}