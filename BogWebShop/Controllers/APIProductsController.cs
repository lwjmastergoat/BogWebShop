using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repository.Factories;

namespace BogWebShop.Controllers
{
    public class APIProductsController : ApiController
    {
        ProductFactory PF = new ProductFactory();

        [HttpGet]
        public IHttpActionResult GetAll() {
            return Json(PF.GetAll());
        }
    }
}
