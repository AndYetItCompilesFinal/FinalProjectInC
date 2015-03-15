using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Dumbo : GoodGuy
    {
        public Dumbo() : base("Dumbo", 50, 50, .7, 8, 8, "Sonic Trumpet", "Flying Headbutt", "Stomp")
        {
        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to use his trunk to sonic trumpet the enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to headbutt the enemy from the sky. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to stomp the enemy.");
            return 5;
        }

    }
}
