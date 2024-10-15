using System.Xml.Linq;

namespace ukolmore.Entities
{
    public enum PotionType
    {
        Medkit,
        Strengthka,
    }

    public class Potion
    {
        public string Name { get; set; }
        public PotionType Type { get; set; }
        public double EffectValue { get; set; }

        public Potion(string name, PotionType type, double effectValue)
        {
            Name = name;
            Type = type;
            EffectValue = effectValue;
        }

        public void UsePotion(Player player)
        {
            switch (Type)
            {
                case PotionType.Medkit:
                    player.Health += EffectValue;
                    Console.WriteLine($"{player.Name} dohealoval {EffectValue} Hp.");
                    break;
                case PotionType.Strengthka:
                    player.BaseDmg += EffectValue;
                    Console.WriteLine($"{player.Name} dostal {EffectValue} Dmg navic.");
                    break;
            }
        }
    }
}
