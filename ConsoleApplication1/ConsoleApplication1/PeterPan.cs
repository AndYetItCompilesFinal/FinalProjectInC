using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class PeterPan : GoodGuy
    {
        public PeterPan()
        {
            Name = "Peter Pan";
            MaxHp = 50;      //health 30
            Hp = 50;         //hp 30
            Defense = 50;    //defense 1
            Speed = 5;       //speed 20
            Attack = 20;     //attack 30
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
