using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class OrderUsers
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
    }
}
