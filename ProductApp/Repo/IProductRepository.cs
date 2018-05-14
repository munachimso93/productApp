using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductApp
{
    interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}