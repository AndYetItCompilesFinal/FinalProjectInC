using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Character
    {
        protected static Random Rand = new Random();
        protected String Name;
        protected int MaxHp;
        protected int Hp;
        protected int Defense;
        protected int Speed;
        protected int Attack;
        protected bool Alive;
        protected bool Good;
        protected String Greeting;
        protected String GoodBye;

        public abstract int Attack1();

        public abstract int Attack2();

        public abstract int Attack3();

        public abstract int ChooseAttack();

        public bool IsGood()
        {
            return Good;
        }

        public bool IsAlive()
        {
            return Alive;
        }

        public String SayGreeting()
        {
            return Greeting;
        }

        public String SayGoodBye()
        {
            return GoodBye;
        }

        public override string ToString()
        {
            return Name;
        }


        //calculates dodge, true if dodge successful, false if dodge failed
        public bool DodgeAttempt()
        {
            return Rand.NextDouble() <= this.Defense;
        }

        //subtracts damage from hp, false if character is not alive after damage, true if they survived the hit
        public bool ApplyDamage(int d)
        {
            this.Hp = this.Hp - d;
            if (this.Hp > 0) return true;

            this.Hp = 0;
            if (this.Good == true)
            {
                Console.WriteLine(Name + " has fallen!");
                return false;
            }
            else
            {
                Console.WriteLine(Name + " has been defeated!");
                return false;
            }
        }
    }
}
