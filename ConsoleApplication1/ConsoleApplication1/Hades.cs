using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Hades : BossBehavior
    {
        public Hades()
            : base("Hades", 100, 100, .8, 19, 15, "Hello", "Bye", "Fireball", "Decieve", "Send Pain and Panic")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to throw a fireball at his enemy. ");
            return 1;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to Decieve his enemy. ");
            return 1;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to send Pain and Panic to attack his enemy.");
            return 1;
        }


    }
}
