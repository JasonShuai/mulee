using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
[RoutePrefix("api/products")]
    public class ProductController : ApiController
    {
       
        [HttpGet, Route("product/get")]
        public Product GetProduct(Guid productId)
        {
            throw new NotImplementedException();
        }
        [HttpPost, Route("product/add")]
        public Guid AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        [HttpPost,Route("product/update")]
        public void UpdateProduct(Guid productId, Product product)
        {
            throw new NotImplementedException();
        }

        [HttpDelete, Route("product/delete")]
        public void DeleteProduct(Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}
