using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class EnemyshipFactory
    {
        public EnemeyShip makeEnemyShip(string newShipType)
        {
            EnemeyShip enShip = null;

            if (newShipType == "1")
            {
                return new RocketEnemyShip();
            }
            else if (newShipType == "2"){
                return new BigUFOEnemyShip();
            }
            else if(newShipType == "3")
            {
                return new UFOEnemyShip();
            }
            return enShip;
        }
    }
}
