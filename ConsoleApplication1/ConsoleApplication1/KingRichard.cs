using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class KingRichard : BadGuy
    {
        public KingRichard()
            : base("King Richard", 75, 75, .6, 19, 15, "Sword", "Kick", "Tax")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to slash his enemy with his sword. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to kick his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to tax his enemy.");
            return 5;
        }
    }
}
