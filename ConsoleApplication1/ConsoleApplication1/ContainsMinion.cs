using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ContainsMinion:MinionBehavior
    {

        public ContainsMinion(BadGuy minion)
        {
            this.Minion = minion;
            this.Numofminions = 1;
            Description = "Minion";
        }

        public ContainsMinion(BadGuy[] minions)
        {
            this.Minions = minions;
            this.Numofminions = minions.Length;
            Description = Numofminions + " Minions";
        }
    }
}
