using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class RocketEnemyShip:EnemeyShip
    {
        public RocketEnemyShip()
        {
            setName("Rocket Enemy Ship");
            setDamage(10.0);
        }
    }
}
