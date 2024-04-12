using DesignPatterns.Abstract_Factory.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Factory
{
    internal class Application
    {
        private readonly Hotel _hotel;

        public Application(Hotel hotel)
        {
            this._hotel=hotel;
        }

        public void GetVada()
        {
            _hotel.CreateVada().ServeVada();
        }
    }
}
