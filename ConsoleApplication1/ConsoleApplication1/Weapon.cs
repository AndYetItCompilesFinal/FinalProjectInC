using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Weapon:WeaponBehavior
    {
        public Weapon(int damage)
        {
            this.Damage = damage;
        }
    }
}
