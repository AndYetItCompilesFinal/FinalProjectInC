using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Minion:BadGuy
    {
        public Minion(string name)
            : base(name, 100, 100, .5, 3, 20, "Hello", "Bye", "attack 1", "attack 2", "attack3")
        {
            
        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to slash the enemy with his sword. ");
            return 1;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to trip the enemy. ");
            return 1;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to jump on and attack the enemy.");
            return 1;
        }

    }
}
