using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class KingRichard : BadGuy
    {
        public KingRichard()
            : base("King Richard", 100, 100, .8, 19, 15, "Use Sword", "Kick", "Hundred Hand Slap")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to slash the enemy with his sword. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + "tried to kick the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to slap the enemy.");
            return 5;
        }
    }
}
