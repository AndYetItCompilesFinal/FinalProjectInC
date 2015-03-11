using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Dumbo : GoodGuy
    {
        public Dumbo()
        {
            Name = "Dumbo";
            MaxHp = 50;      //maxhp 60
            Hp = 50;         //hp 60
            Defense = 50;    //defense 10
            Speed = 5;      //speed 5
            Attack = 20;   //attack 5
            Alive = true;
            Good = true;
            attackName1 = "ATTACK ONE NAME";
            attackName2 = "ATTACK TWO NAME";
            attackName3 = "ATTACK THREE NAME";
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
