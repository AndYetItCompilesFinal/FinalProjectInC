using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Randal : BadGuy
    {
        public Randal()
            : base("Randal", 100, 100, .8, 19, 15,"Bind", "Scare", "Invisible")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to bind his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + "tried to scare his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to attack his enemy while invisible.");
            return 5;
        }
    }
}