using EcommWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommWebAPI.Repository
{
    public interface IProduct
    {
        Task<List<Products>> GetAllProducts();
    }
}
