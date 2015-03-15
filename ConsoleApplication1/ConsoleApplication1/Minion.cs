using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Minion:BadGuy
    {
        public Minion(string name)
            : base(name, 50, 50, .4, 3, 5, "Sword", "Trip", "Tackle")
        {
            
        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to slash the enemy with his sword. ");
            return 1;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to trip his enemy. ");
            return 1;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to tackle his enemy.");
            return 1;
        }

    }
}
