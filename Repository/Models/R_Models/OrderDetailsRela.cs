using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class OrderDetailsRela
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
    }
}
