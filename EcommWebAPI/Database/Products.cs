using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommWebAPI.Database
{
    public class Products
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }


    }
}
