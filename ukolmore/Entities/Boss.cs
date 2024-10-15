using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukolmore.Entities
{
    public class Boss : Enemy
    {

        private bool SecondPhase;
        public Boss(string name, double baseDmg, double health): base(name, baseDmg, health)
        {
            SecondPhase = true;
        }
        public void Attack(Player player)
        {
            if (Health < 0 && !SecondPhase)
            {
                Console.WriteLine($"{Name} se dostal do druhe faze ");
                SecondPhase = true;
            }
            if (SecondPhase)
            {
                Console.WriteLine($"{Name} dal dvojnasobnz utok");
                player.Health -= BaseDmg * 2;
            }
            else
            {
                base.Attack(player);
            }
        }

    }
}
