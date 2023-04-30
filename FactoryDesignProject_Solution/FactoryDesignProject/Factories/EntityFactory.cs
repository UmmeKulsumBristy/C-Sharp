using FactoryDesignProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignProject.Factories
{
    public class EntityFactory : IEntityFactory
    {
        public T Create<T>(params object[] args) where T : EntityBase
        {
            return Activator.CreateInstance(typeof(T), args) as T;
        }
    }
}
