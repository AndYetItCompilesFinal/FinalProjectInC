using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Poison10HP:PotionBehavior
    {
        public Poison10HP()
        {
            Description = "10 HP Poison";
            Hp = -10;
        }
    }
}
