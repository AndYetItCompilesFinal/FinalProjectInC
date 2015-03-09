using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Pluto : GoodGuy
    {
        public Pluto()
        {
            Name = "Pluto";
            MaxHp = 50;
            Hp = 50;
            Defense = 50;
            Speed = 5;
            Attack = 20;
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
