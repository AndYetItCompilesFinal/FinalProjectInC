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
        protected double Defense;
        protected int Speed;
        protected int Attack;
        protected string Greeting;
        protected string GoodBye;
        protected string AttackName1;
        protected string AttackName2;
        protected string AttackName3;

        protected Character(string name, int maxHp, int hp, double defense, int speed, int attack,
            string greeting, string goodbye, string attackname1, string attackname2, string attackname3)
        {

            this.Name = name;
            this.MaxHp = maxHp;
            this.Hp = hp;
            this.Defense = defense;
            this.Speed = speed;
            this.Attack = attack;
            this.Greeting = greeting;
            this.GoodBye = goodbye;
            this.AttackName1 = attackname1;
            this.AttackName2 = attackname1;
            this.AttackName3 = attackname3;


        }

        public abstract int Attack1();

        public abstract int Attack2();

        public abstract int Attack3();

        public abstract int ChooseAttack();


        public bool IsAlive()
        {
            return Hp>0;
        }

        public String SayGreeting()
        {
            return Greeting;
        }

        public String SayGoodBye()
        {
            return GoodBye;
        }

        public int GetStrength()
        {
            return this.Attack;
        }

        public int GetSpeed()
        {
            return this.Speed;
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
            //if (this.Good == true)
            //{
            //    Console.WriteLine(Name + " has fallen!");
            //    return false;
            //}
            //else
            //{
            Console.WriteLine(Name + " has been defeated!");
            return false;
            //}
        }
    }
}
