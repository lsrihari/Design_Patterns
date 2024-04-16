using DesignPatterns.Strategy.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    internal class Animal
    {
        private string _name;
        private double _height;
        private int _weight;
        private string sound;
        public Flys flyingType;

        public void setName(string name) { this._name=name; }
        public string getName() { return this._name; }

        public void setHeight(double height) { 
            if(height>0)
            {
                this._height = height;
            }
            else
            {
                Console.WriteLine("Height must be greater than 0.");
            }
        }

        public double getHeight() { return this._height; }

        public void setWeight(int weight)
        {
            if (weight > 0)
            {
                this._weight = weight;
            }
            else
            {
                Console.WriteLine("Weight must be greater than 0.");
            }
        }

        public double getWeight() { return this._weight; }

        public void setSound(string sound) { this.sound = sound; }
        public string getSound() { return this.sound; }

        public void setFlyingAbility (Flys newFly)
        {
            flyingType= newFly;
        }

        public String tryToFly()
        {
            return flyingType.fly();
        }
    }
}
