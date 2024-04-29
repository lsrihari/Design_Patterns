using DesignPatterns.Abstract_Factory;
using DesignPatterns.Abstract_Factory.Helpers;
using DesignPatterns.Adapter;
using DesignPatterns.Factory;
using DesignPatterns.Observer;
using DesignPatterns.Strategy;
using DesignPatterns.Strategy.Helpers;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AbstractFactory
            //Hotel A2B = new A2BHotel();
            //Vada v = A2B.CreateVada();
            //v.ServeVada();
            //Hotel Sangeethas = new SangeethasHotel();
            //Vada s = A2B.CreateVada();
            //s.ServeVada();
            #endregion

            #region Adapter
            //Square square = new Square(5);
            //Rectangle rectangle = RectangleAdapter.adapt(square);
            //Console.WriteLine(rectangle.ToString());   
            #endregion

            #region Strategy
            //To use when all obects varies between a behaviour dynammically
            //Animal sparky = new Dog();
            //Animal kitty = new Cat(); 
            //Animal tweety = new Bird();

            //Console.WriteLine("Dog :" + sparky.tryToFly());
            //Console.WriteLine("Cat :" + kitty.tryToFly());
            //Console.WriteLine("Bird :" + tweety.tryToFly());

            ////Trying to make dog also to fly
            //sparky.setFlyingAbility(new ItFlys());
            //Console.WriteLine("Dog :" + sparky.tryToFly());

            #endregion

            #region Observer
            //StockGrabber stockGrabber = new StockGrabber();

            //StockObserver stockObserver = new StockObserver(stockGrabber);
            //StockObserver stockObserver2 = new StockObserver(stockGrabber);

            //stockGrabber.setIBMPrice(119);
            //stockGrabber.setApplePrice(675);
            //stockGrabber.setGooglePrice(670);

            //stockGrabber.unregister(stockObserver2);

            //stockGrabber.setIBMPrice(112);
            //stockGrabber.setApplePrice(635);
            //stockGrabber.setGooglePrice(620);
            #endregion

            #region Factory
            EnemyshipFactory enemyshipFactory = new EnemyshipFactory();
            EnemeyShip theEnemy = null;

            string ship = Console.ReadLine();

            if (ship != "")
            {
                theEnemy = enemyshipFactory.makeEnemyShip(ship);
            }

            if(theEnemy != null)
            {
                doStuffEnemy(theEnemy);
            }
            else
            {
                Console.WriteLine("Try again...");
            }
            #endregion
        }

        private static void doStuffEnemy(EnemeyShip anEnemyShip)
        {
            anEnemyShip.displayEnemyShip();
            anEnemyShip.followHeroShip();
            anEnemyShip.enemyShipShoots();
        }
    }
}
