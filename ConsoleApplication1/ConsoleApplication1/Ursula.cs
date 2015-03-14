using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Ursula:BossBehavior
    {
        public Ursula()
            : base("Ursula", 100, 100, .8, 19, 15, "Hello", "Bye", "Tentacle Grab", "Poison Ink", "Mega Ursula")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to grab the enemy with her tentacles. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to poison the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to transform into Mega Ursela and destroy her enemy.");
            return 5;
        }
    }
}