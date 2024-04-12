using DesignPatterns.Abstract_Factory.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Factory
{
    internal class SangeethasMethuvadai:Vada
    {
        public void ServeVada()
        {
            Console.WriteLine("Methu vadai from Sangeethas.");
        }
    }
}
