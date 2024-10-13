using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ukolmore.Entities;

namespace ukolmore
{

    public class Enemy
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double BaseDmg { get; set; }
        public Enemy(string name, double baseDmg, double health)
        {
            Name = name;
            BaseDmg = baseDmg;
            Health = health;
        }

        public void Attack(Player player)
        {

            player.Health -= BaseDmg;
            Console.WriteLine($"{Name} zautocil na {player.Name} a udelil {BaseDmg} dmg!");

        }


        public bool StillAlive() => Health > 0;

    }
}
