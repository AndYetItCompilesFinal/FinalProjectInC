using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class PoohBear : GoodGuy
    {
        public PoohBear()
        {
            Name = "Pooh Bear";
            MaxHp = 50;   //max hp 70
            Hp = 50;      //hp 70
            Defense = 50; //defense 15
            Speed = 5;    //speed .5
            Attack = 20;  //attack 7
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
