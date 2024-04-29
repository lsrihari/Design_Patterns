using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class UFOEnemyShip:EnemeyShip
    {
        public UFOEnemyShip()
        {
            setName("UFO Enemy Ship");
            setDamage(20.0);
        }
    }
}
