using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ChickenLittle : GoodGuy
    {
        public ChickenLittle()
        {
            Name = "Chicken Little";
            MaxHp = 50;    //maxHp 40
            Hp = 50;       //hp 40
            Defense = 50; //defense 2
            Speed = 5;    //speed 30
            Attack = 20;  //attack 35
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
