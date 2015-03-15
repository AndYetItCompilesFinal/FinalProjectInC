using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class MainCharacter : GoodGuy
    {
        public MainCharacter(string name)
            : base(name, 100, 100, .5, 5, 20,"Sword", "Kick", "Tackle")
        {
        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName()+" tried to slash the enemy with his sword. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName()+" tried to kick the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName()+" tried to tackle the enemy.");
            return 5;
        }

    }
}
