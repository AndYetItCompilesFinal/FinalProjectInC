using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Scar:BossBehavior
    {
        public Scar()
            : base("Scar", 100, 100, .8, 19, 15, "Hello", "Bye", "Slash", "Pounce", "Wildebeast")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to slash his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to pounce on his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to thow his enemy into a pack of wildebeast.");
            return 5;
        }
    }
}