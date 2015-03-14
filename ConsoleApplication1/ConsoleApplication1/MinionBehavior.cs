using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class MinionBehavior
    {
        private string Description;
        private BadGuy[] Minions;
        public MinionBehavior(string description, BadGuy[] minions)
        {
            this.Description = description;
            this.Minions = minions;
        }
        public MinionBehavior()
        {

        }

        public BadGuy[] GetMinions()
        {
            return this.Minions;
        }

        public override string ToString()
        {
            return ", " + Description;
        }
 

    }
}
