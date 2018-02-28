using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Models;

namespace BogWebShop.ViewModels
{
    public class AuthorVM
    {
        public ProductsTable Products { get; set; }
        public AuthorTable Authors { get; set; }
    }
}