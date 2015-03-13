using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Syndrome:BossBehavior
    {
        public Syndrome()
            : base("Syndrome", 100, 100, .8, 19, 15, "Hello", "Bye", "Stun", "Bomb", "Machine of Death")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to stun his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to throw a bomb at his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to activate his machine to destroy his enemy.");
            return 5;
        }
    }
}