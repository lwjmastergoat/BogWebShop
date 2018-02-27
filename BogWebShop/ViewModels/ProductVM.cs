using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Models;

namespace BogWebShop.ViewModels
{
    public class ProductVM
    {
        public ProductsTable Products { get; set; }

        public List<CategoryTable> Category { get; set; }

    }
}