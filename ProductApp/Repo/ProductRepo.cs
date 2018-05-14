using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductApp.Context;
using ProductApp.Models;

namespace ProductApp.Repo
{
    public class ProductRepo : IProductRepository
    {
        ProductContext _productcontext = new ProductContext();
        public IEnumerable<Product> GetProducts()
        {
            return _productcontext.Set<Product>().ToList();
        }
    }
}