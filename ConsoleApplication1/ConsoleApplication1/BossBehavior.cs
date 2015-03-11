using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class BossBehavior : BadGuy
    {
        /*    Possible addition to the villans to provide banter during combat/ add more personality
        public void greeting();
        public void taunt();
        public void defeated();
        public void victory();
        */
        protected BossBehavior(string name, int maxHp, int hp, double defense, int speed, int attack,
            string greeting, string goodbye, string attackname1, string attackname2, string attackname3)
            : base(name, maxHp, hp, defense, speed, attack, greeting, goodbye, attackname1, attackname2, attackname3)
        {
            
        }
    }
}
