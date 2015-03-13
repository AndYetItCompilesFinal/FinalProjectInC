using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class KingRichard:BossBehavior
    {
        public KingRichard()
            : base("King Richard", 100, 100, .8, 19, 15, "Hello", "Bye", "Use Sword", "Kick", "Hundred Hand Slap")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to slash the enemy with his sword. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to kick the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to slap the enemy.");
            return 5;
        }
    }
}