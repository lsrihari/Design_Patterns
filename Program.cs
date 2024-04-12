using DesignPatterns.Abstract_Factory;
using DesignPatterns.Abstract_Factory.Helpers;
using DesignPatterns.Adapter;

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
            Square square = new Square(5);
            Rectangle rectangle = RectangleAdapter.adapt(square);
            Console.WriteLine(rectangle.ToString());   
            #endregion
        }
    }
}
