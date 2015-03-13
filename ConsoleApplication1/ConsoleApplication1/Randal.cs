using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Randal:BossBehavior
    {
        public Randal()
            : base("Randal", 100, 100, .8, 19, 15, "Hello", "Bye", "Bind", "Scare", "Invisible")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to bind his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to scare his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to attack his enemy while invisible.");
            return 5;
        }
    }
}