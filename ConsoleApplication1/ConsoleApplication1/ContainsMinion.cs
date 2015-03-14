using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ContainsMinion:MinionBehavior
    {
        public ContainsMinion(BadGuy[] minions):base(minions.Length + " Minion(s)",minions)
        {
        }
    }
}
