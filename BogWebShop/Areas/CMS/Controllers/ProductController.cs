using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Models;
using Repository.Factories;
using BogWebShop.Helpers;
using BogWebShop.ViewModels;

namespace BogWebShop.Areas.CMS.Controllers
{
    public class ProductController : Controller
    {

        int Admin = 2;
        int Editor = 1;

        CategoryFactory cf = new CategoryFactory();
        ProductFactory pf = new ProductFactory();
        FileTools ft = new FileTools();

        // GET: CMS/Product
        public ActionResult Index()
        {

            if (Session["role"] == null || (int)Session["role"] < Editor)
            {
                return Redirect("/Login");
            }

            return View(pf.GetAll());
        }

        public ActionResult AddNew()
        {
            if (Session["role"] == null || (int)Session["role"] < Editor)
            {
                return Redirect("/CMS");
            }
            return View();
        }

        [HttpPost]
        public ActionResult AddNew(ProductsTable input, HttpPostedFileBase Photo)
        {
            if (Session["role"] == null || (int)Session["role"] < Editor)
            {
                return Redirect("/CMS");
            }


            input.Image = null;

            if (Photo != null)
            {
                string imagePath = Request.PhysicalApplicationPath + "/Images/Products/";
                input.Image = ft.UploadFile(Photo, imagePath);
            }


            pf.Insert(input);

            return Redirect("/CMS/Produkt");
        }
    }
}