using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class PoohBear : GoodGuy
    {
        public PoohBear()
            : base("Pooh Bear", 100, 100, .3, 5, 7, "Pot Smash", "Belly Bounce", "Mega Kick")
        {
        }

        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to smash a pot of honey on his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + "tried to belly bounce his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to mega kick his enemy.");
            return 5;
        }

    }
}
