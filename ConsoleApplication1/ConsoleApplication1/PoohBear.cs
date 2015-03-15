using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class PoohBear : GoodGuy
    {
        public PoohBear()
            : base("Pooh Bear", 50, 50, .3, 5, 7, "Throw Pot of Honey", "Send Bees", "Use honey to trap")
        {
        }

        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to throw a pot of honey at his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to send bees to his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to use honey to trap his enemy.");
            return 5;
        }

    }
}
