using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class ContactZip
    {
        public int ID { get; set; }
        public string ContactName { get; set; }
        public string ContactAddress { get; set; }
        public int ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public int ContactCVR { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
    }
}
