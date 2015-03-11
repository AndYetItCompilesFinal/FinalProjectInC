using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Hades:BossBehavior
    {
        public Hades()
        {
            Name = "Hades";
            MaxHp = 50;      //health 50
            Hp = 50;         //hp 50
            Defense = 50;    //defense 10
            Speed = 5;       //speed 10
            Attack = 20;     //attack 10
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
