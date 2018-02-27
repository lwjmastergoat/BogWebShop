using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Factories;

namespace BogWebShop.Controllers
{
    public class ContactController : Controller
    {
        ContactInformationFactory cf = new ContactInformationFactory();
        // GET: Contact
        public ActionResult Index()
        {
            return View(cf.GetAll());
        }
    }
}