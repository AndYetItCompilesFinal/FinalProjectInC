using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Pluto : GoodGuy
    {
        public Pluto()
            : base("Pluto", 50, 50, .6, 10, 9, "Bite", "Pounce", "Super Bark")
        {
 
        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to bite the enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to pounce on the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to super bark the enemy.");
            return 5;
        }


    }
}
