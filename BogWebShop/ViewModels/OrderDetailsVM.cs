using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Models;

namespace BogWebShop.ViewModels
{
    public class OrderDetailsVM
    {

        public ProductsTable products { get; set; }
        public OrderTable orders { get; set; }
        public OrderDetailsTable details { get; set; }

    }
}