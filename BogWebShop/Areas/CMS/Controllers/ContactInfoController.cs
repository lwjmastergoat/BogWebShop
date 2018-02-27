using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Factories;
using Repository.Models;

namespace BogWebShop.Areas.CMS.Controllers
{
    public class ContactInfoController : Controller
    {
        ContactInformationFactory cf = new ContactInformationFactory();
        // GET: CMS/ContactInfo
        public ActionResult Index()
        {
            return View(cf.GetByJoined());
        }
        public ActionResult Edit()
        {
            return View(cf.GetAll()[0]);
        }
        [HttpPost]
        public ActionResult Edit(ContactInformationTable input)
        {
            cf.Update(input);
            return Redirect("/CMS/ContactInfo/");
        }
    }
}