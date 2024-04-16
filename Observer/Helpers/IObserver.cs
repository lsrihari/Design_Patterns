using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Helpers
{
    public interface IObserver
    {
        public void update(double ibmPrice, double applPrice, double gooPrice);
    }
}
