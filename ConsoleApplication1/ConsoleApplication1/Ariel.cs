using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Ariel:GoodGuy
    {
         public Ariel()
            : base("Ariel", 50, 50, .4, 18, 17, "Hello", "Bye", "Flipper Whip", "Thingamabob", "Charm")
        {
        }

        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to whip the enemy with her flipper. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to hit the enemy with her thingamabob. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to charm the enemy to attack themselves.");
            return 5;
        }
    }
}
