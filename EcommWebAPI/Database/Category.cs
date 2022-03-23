using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommWebAPI.Database
{
    public class Category
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
