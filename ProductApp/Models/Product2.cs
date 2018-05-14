using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductApp.Models
{
    public static class Product2
    {
        public static List<Product> products()
        {
            var category1 = new Category { Name = "Mobile Accessories" };



            List<Product> ProductList = new List<Product>() {
          new Product
            {
                Name = "Headphone",
                Category = category1,
                Description = "Samsung U level",
                Price = 15000

            },

            new Product
            {
                Name = "Charger",
                Category = category1,
                Description = "Samsung S8 Charger",
                Price = 5000

            },


            new Product
            {
                Name = "Screen Guard",
                Category = category1,
                Description = "Samsung Screen Guard",
                Price = 2000

            }};
            return ProductList;
        }
    }
}