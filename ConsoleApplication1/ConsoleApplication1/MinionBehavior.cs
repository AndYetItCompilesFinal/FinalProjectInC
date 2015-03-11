using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class MinionBehavior
    {
        public string Description;
        public int Numofminions;
        public BadGuy Minion;
        public BadGuy[] Minions;


        public override string ToString()
        {
            return ", " + Description;
        }

    }
}
