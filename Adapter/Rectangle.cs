using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    internal class Rectangle
    {
        public int _length {  get; set; }
        public int _breadth { get; set; }

        public Rectangle(int length, int breadth)
        {
            this._length = length;
            this._breadth = breadth;
        }
        
        public override string ToString()
        {
            return ("Length:" + _length + " Breadth:" + _breadth);
        }
    }
}
