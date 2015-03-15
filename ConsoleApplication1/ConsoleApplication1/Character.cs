using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Character
    {
        protected static Random Rand = new Random();
        private String Name;
        private int MaxHp;
        private int Hp;
        private double Defense;
        private int Speed;
        private int Attack;
        private string AttackName1;
        private string AttackName2;
        private string AttackName3;

        protected Character(string name, int maxHp, int hp, double defense, int speed, int attack,
             string attackname1, string attackname2, string attackname3)
        {

            this.Name = name;
            this.MaxHp = maxHp;
            this.Hp = hp;
            this.Defense = defense;
            this.Speed = speed;
            this.Attack = attack;
            this.AttackName1 = attackname1;
            this.AttackName2 = attackname2;
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
        public string GetName()
        {
            return this.Name;
        }
        public int GetMaxHp()
        {
            return this.MaxHp;
        }
        public int GetHp()
        {
            return this.Hp;
        }
        public double GetDefense()
        {
            return this.Defense;
        }
        public int GetSpeed()
        {
            return this.Speed;
        }
        public int GetAttack()
        {
            return this.Attack;
        }
        public string GetAttackName1()
        {
            return AttackName1;
        }
        public string GetAttackName2()
        {
            return AttackName2;
        }
        public string GetAttackName3()
        {
            return AttackName3;
        }
        public void AddHp(int additionalHp)
        {
            this.Hp+=additionalHp;
            if (Hp >= MaxHp)
            {
                Hp = MaxHp;
                Console.WriteLine(Name + " was fully healed!");
            }
            else
            {
                Console.WriteLine(Name + " has healed " + additionalHp + "hit points. They are at " + Hp + " out of " + MaxHp +
                                  " hit points.");
            }

        }

        public void FullHeal()
        {
            this.Hp = this.MaxHp;
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
            Console.WriteLine(Name + " has been defeated!");
            return false;
        }
    }
}
