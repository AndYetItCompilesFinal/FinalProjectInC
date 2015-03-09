using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class GoodGuy : Character
    {
        public String attackName1;
        public String attackName2;
        public String attackName3;

        public String PrintStats()
        {
            return Name + "\n" + "HP: " + this.Hp + "\nDefense: " + this.Defense + "\nSpeed: " + this.Speed +
                   "\nAttack: " + this.Attack;
        }

        public void AddHp(int h)
        {
            Hp = Hp + h;
            if (Hp >= MaxHp)
            {
                Hp = MaxHp;
                Console.WriteLine(Name + " was fully healed!");
            }
            else
            {
                Console.WriteLine(Name + " has healed " + h + "hit points. They are at " + Hp + " out of " + MaxHp +
                                  " hit points.");
            }
        }

        public int AttackMenu()
        {
            int att = 0;
            while (att < 1 || att > 3)
            {
                Console.WriteLine("Choose your Attack!");
                Console.WriteLine("1. " + attackName1);
                Console.WriteLine("2. " + attackName2);
                Console.WriteLine("3. " + attackName3);
                Console.WriteLine("Enter number now: ");
                bool tryParse = int.TryParse(Console.ReadLine(), out att);
                if (!tryParse)
                    att = -1;
            }
            int baseAttack;
            switch (att)
            {
                case 1:
                    baseAttack = Attack1() + Attack;
                    break;
                case 2:
                    baseAttack = Attack2() + Attack;
                    break;
                default:
                    baseAttack = Attack3() + Attack;
                    break;
            }
            return baseAttack;
        }
    }
}
