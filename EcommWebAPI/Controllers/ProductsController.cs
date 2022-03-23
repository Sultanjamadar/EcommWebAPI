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

        public ProductsController(IProduct productRepositor)
        {
            this.product = productRepositor;
        }
        [HttpGet("GetProduct")]
        public async Task<List<Products>> GetProduct()
        {
            return await product.GetAllProducts();
        }
    }
}
