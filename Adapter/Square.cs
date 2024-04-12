using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    internal class Square
    {
        public int _side {  get; set; }
        public Square(int side)
        {
            this._side = side;
        }
    }
}
