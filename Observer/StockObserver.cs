using DesignPatterns.Observer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    internal class StockObserver : IObserver
    {
        private double ibmPrice;
        private double applPrice;
        private double gooPrice;

        private static int observerIDTracker = 0;

        private int observerID;

        private Subject _StockGrabber;

        public StockObserver(Subject stockGrabber)
        {
            this._StockGrabber = stockGrabber;
            this.observerID = ++observerIDTracker;
            Console.WriteLine("New Observer: "+ this.observerID);
            stockGrabber.register(this);
        }

        public void update(double ibmPrice, double applPrice, double gooPrice)
        {
            this.ibmPrice = ibmPrice;
            this.applPrice = applPrice;
            this.gooPrice = gooPrice;

            printThePrices();
        }

        public void printThePrices()
        {
            Console.WriteLine(observerID+ "\nIBM: "
                +this.ibmPrice +"\nApple:"+this.applPrice+"\nGoogle:"+this.gooPrice);
        }
    }
}
