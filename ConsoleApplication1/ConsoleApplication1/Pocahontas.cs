using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Pocahontas : GoodGuy
    {
        public Pocahontas()
        {
            Name = "Pocahontas";
            MaxHp = 50;   //max hp 25
            Hp = 50;      //hp 25
            Defense = 50; //defense 3
            Speed = 5;    //speed 40
            Attack = 20;  //attack 28
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
