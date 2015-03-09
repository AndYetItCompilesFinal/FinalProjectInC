using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MinionFactory
    {
        public MinionBehavior createParty()
        {
            int num = random();
            MinionBehavior minionBehavior;
            if (num == 0)
            {
                minionBehavior = new Minion();
            }
            else
                if (num == 1)
                {
                    minionBehavior = new MinionParty2();
                }
                else
                {
                    minionBehavior = new MinionParty3();
                }
            return minionBehavior;
        }



        public int random()
        {
            Random random = new Random();
            return random.Next(3);
        }//end of method


    }
}
