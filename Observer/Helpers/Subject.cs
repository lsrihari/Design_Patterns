using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Helpers
{
    internal interface Subject
    {
        public void register(IObserver o);
        public void unregister(IObserver o);
        public void notifyObserver();
    }
}
