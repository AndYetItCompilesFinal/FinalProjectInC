using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Gaston : BadGuy
    {
        public Gaston()
            : base("Gaston", 100, 100, .8, 19, 15, "Use Sword", "Rage", "Gun")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to slash the enemy with his sword. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + "tried to use his rage to overpower his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to use his shotgun on his enemy.");
            return 5;
        }
    }
}