namespace ProductApp.Migrations
{
    using ProductApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductApp.Context.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductApp.Context.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var Products = Product2.products();
            context.Set<Product>().AddRange(Products);
            context.SaveChanges();
        }
    }
}
