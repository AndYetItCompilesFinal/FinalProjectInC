﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Hades : BadGuy
    {
        public Hades()
            : base("Hades", 100, 100, .6, 19, 15, "Fireball", "Decieve", "Send Pain and Panic")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to throw a fireball at his enemy. ");
            return 1;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to decieve his enemy. ");
            return 1;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to send Pain and Panic to attack his enemy.");
            return 1;
        }


    }
}
