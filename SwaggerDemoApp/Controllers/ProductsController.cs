using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerDemoApp.Model;

namespace SwaggerDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [Route("products")]
        public List<Product> GetProducts()
        {
            var products = new List<Product>{
                
                new Product {Id=1,Name="Leptop", Price=12000 },
                new Product{Id=2, Name="Phone", Price=5000 }
            };
            return products;
        }

        [HttpGet]
        [Route("GetProductById")]
        public Product ReturnProduct(int Id)
        {
            var products = new List<Product>{

                new Product {Id=1,Name="Leptop", Price=12000 },
                new Product{Id=2, Name="Phone", Price=5000 }
            };
            var product = products.FirstOrDefault(p => p.Id == Id);
            return product;
        }
    }
}
