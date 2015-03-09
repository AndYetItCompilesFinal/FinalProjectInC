using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class WeaponBehavior
    {
        public int Damage;
        public override string ToString()
        {
            return ", " + this.Damage + " Damage Weapon";
        }
    }
}
