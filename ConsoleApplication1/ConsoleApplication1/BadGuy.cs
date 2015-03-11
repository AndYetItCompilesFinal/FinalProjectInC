using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class BadGuy:Character
    {
 

        protected BadGuy(string name, int maxHp, int hp, double defense, int speed, int attack,
            string greeting, string goodbye, string attackname1, string attackname2, string attackname3)
            : base(name, maxHp, hp, defense, speed, attack, greeting, goodbye, attackname1, attackname2, attackname3)
        {
            
        }

        public override int ChooseAttack()
        {
            int baseAttack;
            int choice = ((int)(Rand.NextDouble() * 3));
            if (choice == 1)
            {
                baseAttack = Attack1();
            }
            else if (choice == 2)
            {
                baseAttack = Attack2();
            }
            else
            {
                baseAttack = Attack3();
            }
            return baseAttack + Attack;
        }
    }
}
