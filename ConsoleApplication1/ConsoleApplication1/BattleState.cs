using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class BattleState
    {
        public List<Character> Characters;
        public BadGuy[] Bad;
        public Backpack Pack;
        protected static Random Rand = new Random();


        public bool Battle(Party good, BadGuy[] b, Backpack bp)
        {
            Console.WriteLine("You are fighting:");
            Pack = bp;
            this.Bad = new BadGuy[b.Length];
            Characters = new List<Character>();
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
                Bad[i] = b[i];
                Characters.Add(Bad[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                Characters.Add(good.GetParty(i));
            }
            //add characters to order based on speed stat

            //selection sort
            SortBySpeed();

            bool win = Round(good, Bad);
            if (win)
            {
                Console.WriteLine("Your party won the fight!");
                return true;
            }
            else
            {
                Console.WriteLine("Your party lost the fight!");
                return false;
            }
        }//end of constructor


        public bool Battle(Party good, BadGuy bad, Backpack bp)
        {
            return Battle(good, new BadGuy[] { bad }, bp);
        }


        public void SortBySpeed()
        {
            for (int i = 0; i < Characters.Count - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < Characters.Count; j++)
                {
                    if (Characters[j].GetSpeed() > Characters[index].GetSpeed())
                    {
                        index = j;
                    }
                }
                if (index != i)
                {
                    Character temp = Characters[i];
                    Characters[i] = Characters[index];
                    Characters[index] = temp;
                }
            }
            //end of sort
        }

        //Continues to go through turn order and runs turn operations
        public bool Round(Party good, BadGuy[] bad)
        {
            while (good.PartyAlive() && !Victory(bad))
            {
                foreach (Character c in Characters)
                {
                    if (c.IsAlive())
                    {
                        Console.WriteLine(c.ToString() + "'s turn!");
                        Console.WriteLine();
                        //if good guy
                        if (c is GoodGuy)
                        {
                            if (DisplayMenu((GoodGuy)c))
                            {
                                return true;
                            }
                        }
                        //if badguy
                        else
                        {
                            if (!VillanTurn((BadGuy)c, good))
                            {
                                if (!good.PartyAlive())
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        //Calculates a random damage in a range
        public int Damage(int str, int basenum)
        {
            int dmg = basenum;
            for (int i = 1; i <= str; i++)
            {
                dmg += ((int)((Rand.NextDouble() * 5) + 1));
            }
            dmg += basenum;
            return dmg;
        }

        //Lets user pick to attack or use an item
        public bool DisplayMenu(GoodGuy c)
        {
            int choice;
            do
            {
                Console.WriteLine("Do you want to: ");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Item");
                Console.WriteLine("Enter your choice: ");
                bool tryParse = int.TryParse(Console.ReadLine(), out choice);
                if (!tryParse)
                {
                    choice = -1;
                }
                Console.WriteLine();
                if (choice < 1 || choice > 2)
                {

                    Console.WriteLine("Invalid menu choice");
                }

            } while (choice < 1 || choice > 2);
            if (choice == 1)
            {
                int baseAttack = c.ChooseAttack();
                int dmg = Damage(c.GetStrength(), baseAttack);
                int index = ChooseTarget(c, Bad);
                if (Bad[index].DodgeAttempt())
                {
                    Console.WriteLine("The attack missed.");
                }
                else
                {
                    Console.WriteLine("The attack hit for " + dmg + ".");
                    bool alive = Bad[index].ApplyDamage(dmg);
                    if (!alive)
                    {
                        Remove(index);
                        if (Victory(Bad))
                        {
                            return true;
                        }
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The items that are in your backpack: ");
                Console.WriteLine(Pack.ToString());
            }
            return false;
        }

        //Automatically runs through the villan's turn, returning whether the hero survived the attack
        public bool VillanTurn(BadGuy c, Party good)
        {
            int baseAttack;
            int damageValue;
            baseAttack = c.ChooseAttack();
            damageValue = Damage(c.GetStrength(), baseAttack);
            // choose hero to attack
            int choice = ((int)(Rand.NextDouble() * 3));
            bool survived = true;
            do
            {
                if (good.GetParty(choice).IsAlive())
                {
                    if (good.GetParty(choice).DodgeAttempt())
                    {
                        Console.WriteLine("The attack missed.");
                    }
                    else
                    {
                        Console.WriteLine("The attack hit for " + damageValue + ".");
                        survived = good.GetParty(choice).ApplyDamage(damageValue);
                    }
                }
            } while (!good.GetParty(choice).IsAlive());
            return survived;
        }

        //Lets the user choose the target to attack
        public int ChooseTarget(Character c, BadGuy[] bad)
        {
            int target = 0;
            while (target < 1 || target > bad.Length)
            {
                Console.WriteLine("Who do you want to attack?");
                for (int i = 0; i < bad.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + bad[i].ToString()); ;
                }
                Console.WriteLine("Enter the number here: ");

                bool tryParse = int.TryParse(Console.ReadLine(), out target);
                if (!tryParse)
                {
                    target = -1;
                }
                Console.WriteLine();

                if (target < 1 || target > 3)
                {
                    Console.WriteLine("Invalid number.");
                }
                if (!bad[target - 1].IsAlive())
                {
                    Console.WriteLine("That enemy is no longer alive. Choose a different target.");
                    target = -1;
                }
            }
            return target - 1;
        }

        //returns whether the good guys won or not
        public bool Victory(BadGuy[] bad)
        {
            for (int i = 0; i < bad.Length; i++)
            {
                if (bad[i].IsAlive())
                {
                    return false;
                }
            }
            return true;
        }

        public void Remove(int index)
        {
            if (Bad.Length != 1)
            {
                BadGuy[] temp = new BadGuy[Bad.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    temp[i] = Bad[i];
                }
                for (int i = index + 1; i < Bad.Length; i++)
                {
                    temp[i - 1] = Bad[i];
                }
                Bad = temp;
            }
        }
    }
}
