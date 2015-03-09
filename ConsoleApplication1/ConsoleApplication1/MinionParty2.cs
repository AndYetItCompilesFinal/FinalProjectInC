using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MinionParty2:MinionBehavior
    {
        public MinionParty2()
        {
            description = "2 Minions";
            numofminions = 2;
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
