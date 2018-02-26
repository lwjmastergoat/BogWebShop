using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class OrderTable
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
    }
}
