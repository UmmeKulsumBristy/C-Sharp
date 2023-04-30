using FactoryDesignProject.Factories;
using FactoryDesignProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignProject.Tests
{
    public class FactoryTest
    {
        private readonly IEntityFactory ef;
        public FactoryTest(IEntityFactory ef)
        {
            this.ef = ef;
        }
        public void Run()
        {
            List<ProductCategory> categories = new List<ProductCategory>
            {
                ef.Create<ProductCategory>(1, "T-Shirt"),
                ef.Create<ProductCategory>(2, "Jacket"),
                ef.Create<ProductCategory>(3, "Denim")
            };

            Console.WriteLine("Categories");
            categories
                .ForEach(c => Console.WriteLine(c.ToString()));
            Console.WriteLine();
            List<Product> products = new List<Product>
            {
                ef.Create<Product>(1, "Back Printed T-Shirt", 299.00M, "XL"),
                ef.Create<Product>(2, "Jeans Jacket", 2399.00M, "XXL"),
                ef.Create<Product>(3, "Denim long sleeve", 1299.99M, "XXL")
            };
            Console.WriteLine("Products");
            products
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
