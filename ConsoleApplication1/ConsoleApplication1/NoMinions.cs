using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class NoMinions:MinionBehavior
    {
        public NoMinions()
        {

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
