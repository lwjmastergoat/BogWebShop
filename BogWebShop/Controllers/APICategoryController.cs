using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repository.Factories;

namespace BogWebShop.Controllers
{
    public class APICategoryController : ApiController
    {
        CategoryFactory CF = new CategoryFactory();

        [HttpGet]
        public IHttpActionResult GetCategorys()
        {
            return Json(CF.GetAll());
        }
    }
}
