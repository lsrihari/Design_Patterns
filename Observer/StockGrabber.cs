using DesignPatterns.Observer.Helpers;
using System.Collections;

namespace DesignPatterns.Observer;

internal class StockGrabber : Subject
{
    private ArrayList observers =new ArrayList();
    private double ibmPrice;
    private double applPrice;
    private double gooPrice;

    public void register(IObserver newObserver)
    {
        observers.Add(newObserver);
    }

    public void unregister(IObserver deleteObserver)
    {
        int observerIndex=observers.IndexOf(deleteObserver);
        Console.WriteLine("Observer "+ (observerIndex+1)+ " deleted");
    }

    public void notifyObserver()
    {
        foreach(IObserver observer in observers)
        {
            observer.update(ibmPrice, applPrice,gooPrice);
        }
    }

    public void setIBMPrice(double newIBMPrice)
    {
        this.ibmPrice = newIBMPrice;
        notifyObserver();
    }
    public void setApplePrice(double newApplePrice)
    {
        this.applPrice = newApplePrice;
        notifyObserver();
    }
    public void setGooglePrice(double newGooglePrice)
    {
        this.gooPrice = newGooglePrice;
        notifyObserver();
    }
}
