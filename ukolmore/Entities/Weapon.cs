using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukolmore.Entities
{
    public enum WeaponType
    {
        Sword,
        Bow,
        Dagger,
        Axe,

    }
    public class Weapon
    {
        public WeaponType Type { get; set; }
        public double DmgOfWeapon { get; set; }
        public Weapon(WeaponType type)
        {
            Type = type;
            switch (Type)
            {
                case WeaponType.Sword:
                    DmgOfWeapon = 10;
                    break;
                case WeaponType.Bow:
                    DmgOfWeapon = 7;
                    break;
                case WeaponType.Dagger:
                    DmgOfWeapon = 5;
                    break;
                case WeaponType.Axe:
                    DmgOfWeapon = 12;
                    break;
                default:
                    DmgOfWeapon = 0;
                    break;
            }
        }
        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
