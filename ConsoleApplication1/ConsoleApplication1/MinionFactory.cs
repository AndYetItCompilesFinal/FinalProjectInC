using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MinionFactory
    {
        public MinionBehavior CreateParty()
        {
            int num = Random();
            BadGuy[] bad;
            if (num == 0)
            {
                bad = new  BadGuy[] {new Minion("Minion")};
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
                
            }
            return new ContainsMinion(bad); ;
        }



        public int Random()
        {
            Random random = new Random();
            return random.Next(3);
        }//end of method


    }
}
