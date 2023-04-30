using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignProject.Models
{
    public class Product : EntityBase
    {
        public Product()
        {

        }
        public Product(int id, string name, decimal listPrice, string size)
        {
            this.Id = id;
            this.Name = name;
            this.ListPrice = listPrice;
            this.Size = size;
        }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Size: {Size} Price: {ListPrice:0.00}";
        }
    }
}
