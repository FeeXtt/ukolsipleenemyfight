using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ukolmore.Entities
{

    public class Player
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double BaseDmg { get; set; }
        public Weapon CurrentWeapon { get; set; }
        public List<Potion> Potions { get; set; }

        public Player(string name, double health, double baseDmg) { 
            Name = name;
            Health = health;
            BaseDmg = baseDmg;
        }

       

        public void Attack(Enemy enemy)
        {
            double dmg = BaseDmg + CurrentWeapon.DmgOfWeapon;
            enemy.Health -= dmg;
            Console.WriteLine($"{Name} zautocil {enemy.Name} a udelil {dmg} dmg");
            
        }
        public void UsePotion(Potion potion)
        {
            potion.UsePotion(this);
            Potions.Remove(potion);
        }
        public void TakeWeapon(Weapon weapon)
        {
            CurrentWeapon = weapon;
            Console.WriteLine($"{Name} nasel {weapon.Type}");
        }


        public bool StillAlive() => Health > 0;
    }
}
