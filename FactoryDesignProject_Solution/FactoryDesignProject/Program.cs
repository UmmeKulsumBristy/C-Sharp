using FactoryDesignProject.Factories;
using FactoryDesignProject.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEntityFactory f = new EntityFactory();
            FactoryTest t = new FactoryTest(f);
            t.Run();
            Console.ReadLine();
        }
    }
}
