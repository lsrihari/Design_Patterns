using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Helpers
{
    internal class ItFlys:Flys
    {
        public string fly()
        {
            return "Flying high.";
        }
    }
}
