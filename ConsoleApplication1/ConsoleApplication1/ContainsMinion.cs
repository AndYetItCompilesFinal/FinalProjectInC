using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ContainsMinion:MinionBehavior
    {
        private int numofminions;

        public ContainsMinion(BadGuy minion)
        {
            this.Minion = minion;
            numofminions = 1;
            Description = "Minion";
        }

        public ContainsMinion(BadGuy[] minions)
        {
            this.Minions = minions;
            numofminions = minions.Length;
            Description = numofminions + " Minions";
        }
    }
}
