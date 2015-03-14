using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Gaston:BossBehavior
    {
        public Gaston()
            : base("Gaston", 100, 100, .8, 19, 15, "Hello", "Bye", "Use Sword", "Rage", "Gun")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to slash the enemy with his sword. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to use his rage to overpower his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to use his shotgun on his enemy.");
            return 5;
        }
    }
}