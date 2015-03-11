using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class MainCharacter : GoodGuy
    {
        protected WeaponBehavior Weapon;

        public MainCharacter(string name, WeaponBehavior weapon)
            : base(name, 100, 100, .5, 5, 20, "Hello", "Bye", "attack 1", "attack 2", "attack3")
        {
            this.Weapon = weapon;
        }

        public void SetWeapon(WeaponBehavior weapon)
        {
            this.Weapon = weapon;
        }

        public override int Attack1()
        {
            Console.WriteLine(this.Name+" tried to slash the enemy with his sword. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name+"tried to trip the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name+" tried to jump on and attack the enemy.");
            return 5;
        }

    }
}
