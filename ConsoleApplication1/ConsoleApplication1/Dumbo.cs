using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Dumbo : GoodGuy
    {
        public Dumbo() : base("Dumbo", 100, 100, .7, 4, 8, "Hello", "Bye", "Pink Elephants", "Flying Headbutt", "Stomp")
        {
        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to use scary Pink Elephants to attack the enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to headbutt the enemy from the skies. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to stomp the enemy.");
            return 5;
        }

    }
}
