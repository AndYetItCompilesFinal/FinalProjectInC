using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class HealthPotionHP10:PotionBehavior
    {
        public HealthPotionHP10()
        {
            Description = "10 HP Health Potion";
            Hp = 10;
        }
    }
}
