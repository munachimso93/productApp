using ProductApp.Models;
using ProductApp.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ProductApp.Controllers.api
{
    [RoutePrefix("api/product")]
    public class ProductApiController : ApiController
    {
        private readonly ProductRepo repo;
        public ProductApiController()
        {
            repo = new ProductRepo();

        }
        [Route("list")]
        [HttpGet]
        public HttpResponseMessage GetProduct()
        {
            try
            {
                var repositoryproduct = repo.GetProducts();
                return Request.CreateResponse<IEnumerable<Product>>(HttpStatusCode.Created, repositoryproduct);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
