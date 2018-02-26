using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class OrderDetailsTable
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductsID { get; set; }
        public int Quantity { get; set; }
    }
}
