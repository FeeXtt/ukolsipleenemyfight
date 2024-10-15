using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukolmore.Entities
{
    public class EnemyFactory
    {
        public static Enemy CreateOger()
        {
            return new Enemy("Oger", 5, 50);
        }

        public static Enemy CreateGoblin()
        {
            return new Enemy("Goblin", 7, 20);
        }

        public static Boss CreateBoss()
        {
            return new Boss("Final Boss", 10, 100);
        }

    }
}
