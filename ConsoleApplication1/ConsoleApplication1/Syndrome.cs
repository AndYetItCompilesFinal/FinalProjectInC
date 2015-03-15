using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Syndrome : BadGuy
    {
        public Syndrome()
            : base("Syndrome", 100, 100, .8, 19, 15, "Stun with Monologue", "Bomb", "Attack with Robot")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to stun his enemy with monologue. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to throw a bomb at his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to attack his enemy with a robot.");
            return 5;
        }
    }
}
