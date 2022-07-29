using EcommWebAPI.Database;
using EcommWebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //api/Products/GetProduct
    
    public class ProductsController : ControllerBase
    {
        private readonly IProduct product;

        /// <summary>
        /// added by sultan
        /// 
        /// </summary>
        /// <param name="productRepositor"></param>
        public ProductsController(IProduct productRepositor)
        {
            this.product = productRepositor;
        }

        /// <summary>
        /// Used to get all the products
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetProduct")]
        public async Task<List<Products>> GetProduct()
        {
            return await product.GetAllProducts();
        }
    }
}
