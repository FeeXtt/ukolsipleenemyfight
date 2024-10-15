using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukolmore.Entities
{
    public class Room
    {
        public Enemy Enemy { get; set; }
        public Weapon Treasure { get; set; }
        public Room( Enemy enemy = null, Weapon treasure = null)
        {
            
            Enemy = enemy;
            Treasure = treasure;
        }

        public void GoIn(Player player)
        {
            Console.WriteLine("Vesel si do mistnosti");

            if (Enemy != null)
            {

                Console.WriteLine($"Narazil jsi na {Enemy.Name}");
            }
            else if (Treasure != null)
            {
                player.TakeWeapon(Treasure);
            }
            else
            {
                Console.WriteLine("Mistnost je prazdna");
            }
        }
    }
}
