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
            BadGuy[] bad;
            if (num == 0)
            {
                minionBehavior = new ContainsMinion(new Minion("Minion"));
            }
            else
            {
                if (num == 1)
                {
                    bad = new BadGuy[] {new Minion("Minion 1"), new Minion("Minion 2")};

                }
                else
                {
                    bad = new BadGuy[] {new Minion("Minion 1"), new Minion("Minion 2"), new Minion("Minion 3")};

                }
                minionBehavior = new ContainsMinion(bad);
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
