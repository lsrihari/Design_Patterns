using DesignPatterns.Strategy.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    internal class Cat:Animal
    {
        public Cat()
        {
            setSound("Meow");
            flyingType = new ItCantFly();
        }
    }
}
