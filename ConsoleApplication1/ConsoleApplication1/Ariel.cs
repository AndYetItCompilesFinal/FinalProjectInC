using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Ariel:GoodGuy
    {
         public Ariel()
            : base("Ariel", 75, 75, .4, 18, 17,"Tail Whip", "Throw Thingamabob", "Send Sebastian")
        {
        }

        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to whip the enemy with her tail. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to throw thingamabob at her enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to send Sebastian to attack the enemy. ");
            return 5;
        }
    }
}
