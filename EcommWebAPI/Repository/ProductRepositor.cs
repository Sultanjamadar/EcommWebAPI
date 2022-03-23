using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommWebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace EcommWebAPI.Repository
{
    public class ProductRepositor:IProduct
    {
        private readonly EcommWebApi _ecommWebApi;

        public ProductRepositor(EcommWebApi ecommWebApi)
        {
            _ecommWebApi = ecommWebApi;
        }

        public async Task<List<Products>> GetAllProducts()
        {
            return await _ecommWebApi.tblProducts.ToListAsync();

        }
    }
}
