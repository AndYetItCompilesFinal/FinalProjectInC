using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class GoodGuy : Character
    {
        protected GoodGuy(string name, int maxHp, int hp, double defense, int speed, int attack,
             string attackname1, string attackname2, string attackname3): base(name,maxHp,hp,defense,speed,attack,attackname1,attackname2,attackname3)
        {
          
        }


        public String PrintStats()
        {
            return this.GetName() + "\n" + "HP: " + this.GetHp() + "\nDefense: " + this.GetDefense() + "\nSpeed: " + this.GetSpeed() +
                   "\nAttack: " + this.GetAttack();
        }


        public override int ChooseAttack()
        {
            int att = 0;
            while (att < 1 || att > 3)
            {
                Console.WriteLine("Choose your Attack!");
                Console.WriteLine("1. " + GetAttackName1());
                Console.WriteLine("2. " + GetAttackName2());
                Console.WriteLine("3. " + GetAttackName3());
                Console.WriteLine("Enter number now: ");
                bool tryParse = int.TryParse(Console.ReadLine(), out att);
                if (!tryParse)
                    att = -1;
            }
            int baseAttack;
            switch (att)
            {
                case 1:
                    baseAttack = Attack1();
                    break;
                case 2:
                    baseAttack = Attack2();
                    break;
                default:
                    baseAttack = Attack3();
                    break;
            }
            Console.WriteLine();
            return baseAttack;
        }
    }
}
