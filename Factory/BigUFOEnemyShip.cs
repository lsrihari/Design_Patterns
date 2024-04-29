using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class BigUFOEnemyShip : UFOEnemyShip
    {
        public BigUFOEnemyShip() {
            setName("Big UFO Enemy Ship");
            setDamage(40.0);
        }
    }
}
