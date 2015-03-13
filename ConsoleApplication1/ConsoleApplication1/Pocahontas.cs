using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Pocahontas : GoodGuy
    {
        public Pocahontas()
            : base("Pocahontas", 50, 50, .5, 20, 16, "Hello", "Bye", "Arrow", "Spirit of the Woods", "Smack")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to shoot an arrow at her enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to send the animals to attack the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to smack the enemy.");
            return 5;
        }

    }
}
