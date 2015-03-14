using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Pluto : GoodGuy
    {
        public Pluto()
            : base("Pluto", 75, 75, .6, 15, 13, "Hello", "Bye", "Bite", "Pounce", "Super Bark")
        {
 
        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to bite the enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to pounce on the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to Super Bark the enemy.");
            return 5;
        }


    }
}
