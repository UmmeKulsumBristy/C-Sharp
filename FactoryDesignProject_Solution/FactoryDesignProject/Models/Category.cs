using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignProject.Models
{
    public class ProductCategory :EntityBase
    {
        public ProductCategory() { }
        public ProductCategory(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Id}-{Name}";
        }

    }
}
