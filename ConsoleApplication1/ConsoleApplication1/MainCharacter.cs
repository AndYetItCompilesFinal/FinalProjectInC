using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class MainCharacter : GoodGuy
    {
        private WeaponBehavior Weapon;
        //Weapon

        public MainCharacter(String Name, WeaponBehavior Weapon)
        {
            this.Weapon = Weapon;
            Hp = 50;
            Defense = 50;
            Speed = 5;
            Attack = 20;
            this.Name = Name;
        }

        public void SetWeapon(WeaponBehavior Weapon)
        {
            this.Weapon = Weapon;
        }

        public override int Attack1()
        {
            throw new NotImplementedException();
        }

        public override int Attack2()
        {
            throw new NotImplementedException();
        }

        public override int Attack3()
        {
            throw new NotImplementedException();
        }

        public override int ChooseAttack()
        {
            throw new NotImplementedException();
        }
    }
}
