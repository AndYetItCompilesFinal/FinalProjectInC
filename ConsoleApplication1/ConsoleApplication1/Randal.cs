using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Randal : BadGuy
    {
        public Randal()
            : base("Randal", 100, 100, .8, 19, 15, "Surprise Attack", "Scare", "Tail Whip")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to surprise attack his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to scare his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to attack his enemy with a tail whip.");
            return 5;
        }
    }
}