using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Factories;
using BogWebShop.ViewModels;

namespace BogWebShop.Controllers
{
    public class ProductController : Controller
    {
        ProductFactory pf = new ProductFactory();
        AuthorFactory af = new AuthorFactory();
        
        // GET: Product
        public ActionResult Index()
        {
            
            return View(pf.GetAll());
        }
        public ActionResult Details(int ID)
        {

            AuthorVM vm = new AuthorVM();

            vm.Products = pf.Get(ID);
            vm.Authors = af.Get(vm.Products.AuthorID);

            return View(vm);
        }
        
    }
}