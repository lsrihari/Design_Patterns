using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    internal class RectangleAdapter
    {
        public static Rectangle adapt(Square square)
        {
            return new Rectangle(square._side,square._side);
        }
    }
}
