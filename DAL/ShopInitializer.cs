using example.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace example.DAL
{
    public class ShopInitializer : DropCreateDatabaseAlways<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var products = new List<Product>
            {
            new Product { Name = "Пиво", Price = 100 },
            new Product { Name = "Виски", Price = 500 },
            new Product { Name = "Коньяк", Price = 1000 },
            };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}