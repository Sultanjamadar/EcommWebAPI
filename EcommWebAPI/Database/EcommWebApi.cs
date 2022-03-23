using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommWebAPI.Database
{
    public class EcommWebApi : DbContext
    {
        public EcommWebApi(DbContextOptions<EcommWebApi>options)
            :base(options)
        { 
        }

        public DbSet<Category> tblCategory { get; set; }
        public DbSet<Products> tblProducts { get; set; }
    }
}
