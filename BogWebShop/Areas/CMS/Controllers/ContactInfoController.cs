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
        public ActionResult EditContactInfo()
        {
            return View(cf.GetByJoined());
        }
        [HttpPost]
        public ActionResult EditContactInfo(ContactInformationTable input)
        {
            cf.Update(input);
            return Redirect("/CMS/ContactInfo/");
        }
    }
}