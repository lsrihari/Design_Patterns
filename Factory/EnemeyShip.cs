using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal abstract class EnemeyShip
    {
        private string name;
        private double amtDamage;

        public string getName() { return name; }
        public void setName(string name) { this.name = name;}

        public double getDamage() { return this.amtDamage; }
        public void setDamage(double newDamage) {  this.amtDamage = newDamage;}

        public void followHeroShip()
        {
            Console.WriteLine(getName() + " is following the hero.");
        }
        public void displayEnemyShip()
        {
            Console.WriteLine(getName() + " is on the screen.");
        }
        public void enemyShipShoots()
        {
            Console.WriteLine(getName() + "attacks and does " + getDamage());
        }

    }
}
