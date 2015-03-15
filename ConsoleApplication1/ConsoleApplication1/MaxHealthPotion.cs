using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MaxHealthPotion:PotionBehavior
    {
        public MaxHealthPotion()
        {
            Description = "Max Health Potion";
            Hp = 50;
        }
    }
}
