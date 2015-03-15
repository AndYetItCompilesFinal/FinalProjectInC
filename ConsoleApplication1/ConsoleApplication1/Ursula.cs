using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Ursula : BadGuy
    {
        public Ursula()
            : base("Ursula", 100, 100, .6, 19, 15,"Tentacle Grab", "Poison Ink", "Curse")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to grab the enemy with her tentacles. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to poison her enemy with ink. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to curse her enemy.");
            return 5;
        }
    }
}